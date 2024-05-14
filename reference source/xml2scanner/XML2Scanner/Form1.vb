Imports System.IO
Imports System.Security.Cryptography
Imports System.Xml

'
' command line options for debugging (set in project properties)
'
' -os=win8 -allmt -url=download.lenovo.com/67267/test/catalog
'
'


Public Class Form1

#Region "Globals"
    Private catalog_base_path As String = ""
    Private catalog_base_pathX As String = "http://download.lenovo.com/catalog/"
    Private catalog_base_pathS As String = "https://download.lenovo.com/catalog/"
    Private package_base_path As String = "http://download.lenovo.com/ibmdl/pub/pc/pccbbs/"
    Private local_base_path As String = Application.UserAppDataPath & "\"
    'DECLARE THIS WITHEVENTS SO WE GET EVENTS ABOUT DOWNLOAD PROGRESS
    Private WithEvents _Downloader As WebFileDownloader
    Public ds As DataSet
    Public bindingSource As BindingSource
    Private taxonomy As String = ".\taxonomy.ini"
    Private mt As New List(Of String)
    Private subseries As New List(Of String)
    Private badCatalogCRC As New List(Of String)
    Private downlevelPackages As New List(Of String)
    Private cnt As Integer = 0
    Private key As String = "HKEY_CURRENT_USER\Software\Lenovo\XML2Scanner"
    'Private cmd As Boolean = False
    Private allmt As Boolean = False
    Private alternateURL As Boolean = False

#End Region

    Private Function tstamper() As String
        Dim y As String = Now.Year.ToString
        Dim m As String = Now.Month.ToString
        If m.Length = 1 Then
            m = "0" & m
        End If
        Dim d As String = Now.Day.ToString
        If d.Length = 1 Then
            d = "0" & d
        End If
        Dim h As String = Now.Hour.ToString
        If h.Length = 1 Then
            h = "0" & h
        End If
        Dim mm As String = Now.Minute.ToString
        If mm.Length = 1 Then
            mm = "0" & mm
        End If
        Dim s As String = Now.Second.ToString
        If s.Length = 1 Then
            s = "0" & s
        End If

        Return y & "-" & m & "-" & d & "_" & h & mm & s

    End Function


#Region "Form handlers"
    Private Sub processArgs()
        Try
            Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
            Dim flagMTSearch As Boolean = False
            Dim flagGoodArgs As Boolean = False
            Dim mt As String = ""
            Dim os As String = "all"
            Dim clearcache As Boolean = False
            Dim https As Boolean = False


            For Each s As String In CommandLineArgs
                s = s.ToLower
                Dim arg() As String = s.Split("=")
                Select Case arg(0).Trim

                    Case "-help"
                        MsgBox("Command line help:" & vbCrLf & "-mt=<MT>  Specifies to search just for the 4-character machine type provided" _
                               & vbCrLf & "-os=<OS>  Specifies the OS to search for: xp, vista, win7, win8, all" _
                               & vbCrLf & "-allmt    Specifies to do a search for all machine types in the taxonomy.ini for infrastructure testing")
                        Me.Close()

                    Case "-mt"
                        If arg(1).Trim.Length <> 4 Then
                            flagGoodArgs = False
                        Else
                            flagMTSearch = True
                            mt = arg(1).Trim.ToUpper
                            If Not ("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(mt(0)) And "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(mt(1)) And "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(mt(2)) And "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(mt(3))) Then
                                flagGoodArgs = False
                            Else
                                flagGoodArgs = True
                                Me.TextBox1.Text = mt
                            End If

                        End If


                    Case "-os"
                        If arg(1).Trim.ToLower = "win10" Then
                            os = "win10"
                            Me._rbWin10.Checked = True
                            Me._rbWin7.Checked = False
                            Me._rbWin81.Checked = False
                            Me.ComboBox1.SelectedIndex = 4
                            Me.cbWin10.CheckState = CheckState.Checked
                            Me.cbWin8.CheckState = CheckState.Unchecked
                            Me.cbWin7.CheckState = CheckState.Unchecked
                            Me.cbWinXP.CheckState = CheckState.Unchecked
                            Me.cbWinVista.CheckState = CheckState.Unchecked
                            flagGoodArgs = True
                        ElseIf arg(1).Trim.ToLower = "win8" Then
                            os = "win8"
                            Me._rbWin81.Checked = True
                            Me._rbWin7.Checked = False
                            Me._rbWin10.Checked = False
                            Me.ComboBox1.SelectedIndex = 3
                            Me.cbWin8.CheckState = CheckState.Checked
                            Me.cbWin10.CheckState = CheckState.Unchecked
                            Me.cbWin7.CheckState = CheckState.Unchecked
                            Me.cbWinXP.CheckState = CheckState.Unchecked
                            Me.cbWinVista.CheckState = CheckState.Unchecked
                            flagGoodArgs = True
                        ElseIf arg(1).Trim.ToLower = "win7" Then
                            os = "win7"
                            Me._rbWin7.Checked = True
                            Me._rbWin81.Checked = False
                            Me._rbWin10.Checked = False
                            Me.ComboBox1.SelectedIndex = 2
                            Me.cbWin7.CheckState = CheckState.Checked
                            Me.cbWin10.CheckState = CheckState.Unchecked
                            Me.cbWin8.CheckState = CheckState.Unchecked
                            Me.cbWinXP.CheckState = CheckState.Unchecked
                            Me.cbWinVista.CheckState = CheckState.Unchecked
                            flagGoodArgs = True
                        ElseIf arg(1).Trim.ToLower = "xp" Then
                            os = "xp"
                            Me.ComboBox1.SelectedIndex = 0
                            Me.cbWinXP.CheckState = CheckState.Checked
                            Me.cbWin10.CheckState = CheckState.Unchecked
                            Me.cbWin8.CheckState = CheckState.Unchecked
                            Me.cbWin7.CheckState = CheckState.Unchecked
                            Me.cbWinVista.CheckState = CheckState.Unchecked
                            flagGoodArgs = True
                        ElseIf arg(1).Trim.ToLower = "vista" Then
                            os = "vista"
                            Me.ComboBox1.SelectedIndex = 1
                            Me.cbWinVista.CheckState = CheckState.Checked
                            Me.cbWin7.CheckState = CheckState.Unchecked
                            Me.cbWin10.CheckState = CheckState.Unchecked
                            Me.cbWin8.CheckState = CheckState.Unchecked
                            Me.cbWinXP.CheckState = CheckState.Unchecked
                            flagGoodArgs = True
                        ElseIf arg(1).Trim.ToLower = "all" Then
                            os = "all"
                            Me.cbWinVista.CheckState = CheckState.Checked
                            Me.cbWinXP.CheckState = CheckState.Checked
                            Me.cbWin7.CheckState = CheckState.Checked
                            Me.cbWin8.CheckState = CheckState.Checked
                            Me.cbWin10.CheckState = CheckState.Checked
                            flagGoodArgs = True
                        Else
                            flagGoodArgs = False
                        End If
                        Me.Update()

                    Case "-clearcache"
                        clearcache = True
                        flagGoodArgs = True

                    Case "-https"
                        https = True
                        Me.CheckBox1.CheckState = CheckState.Checked
                        flagGoodArgs = True

                    Case "-allmt"
                        allmt = True
                        flagGoodArgs = True

                    Case "-url"
                        alternateURL = True
                        catalog_base_pathX = "http://" & arg(1)
                        catalog_base_pathS = "https://" & arg(1)
                        flagGoodArgs = True

                    Case Else
                        flagGoodArgs = False

                End Select

            Next
            If ((os = "all" Or os = "") And flagMTSearch) Then
                MsgBox("You must specify an OS when performing a single machine type audit.")
                Application.Exit()
            End If
            If CommandLineArgs.Count > 0 Then
                If flagGoodArgs Then
                    If flagMTSearch Then
                        'Me.cmd = True
                        'Console.WriteLine("[" & tstamper() & "] Performing a catalog search for " & mt & " and " & os)
                        Me.btnSearchCatalog.PerformClick()
                        'Console.WriteLine("[" & tstamper() & "] Completed. Writing log file.")
                        Me.writeLog(True)
                        If clearcache Then
                            'Console.WriteLine("[" & tstamper() & "] Clearing cache.")
                            Me.btnClear.PerformClick()
                        End If
                    Else
                        'Console.WriteLine("[" & tstamper() & "] Performing multiple catalog scan")
                        Me.btnThink.PerformClick()

                        If clearcache Then
                            'Console.WriteLine("[" & tstamper() & "] Clearing cache.")
                            Me.btnClear.PerformClick()
                        End If
                    End If
                Else
                    MsgBox("Usage:  XML2Scanner.exe [-mt=1234] [-os=win8|win7|vista|xp|all] [-https] [-clearcache] [-allmt]" & vbCrLf & "For a complete catalog audit, specify -os=all")
                End If
                Application.Exit()
            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
            Application.Exit()
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CurrentDirectory = My.Application.Info.DirectoryPath

        Me.setStatus("Saving files to: " & local_base_path)
        Me.ComboBox1.SelectedIndex = 4
        Me._rbWin10.Checked = True

        Try
            Me.TextBox1.Text = My.Computer.Registry.GetValue(Me.key, "LastMT", "")
            Dim lastOS As String = My.Computer.Registry.GetValue(Me.key, "LastOS", "Win10")
            Select Case lastOS
                Case "Win10"
                    Me._rbWin10.Checked = True

                Case "Win7"
                    Me._rbWin7.Checked = True

                Case "Win8"
                    Me._rbWin81.Checked = True

                Case Else
                    Me._rbWin10.Checked = True

            End Select

        Catch ex As Exception
            Me.TextBox1.Text = "20E1"
        End Try

        Me.TextBox1.CharacterCasing = CharacterCasing.Upper
        Me.Text = Me.Text & " - " & My.Application.Info.Version.ToString
        Me.ListBox1.SelectedIndex = -1
        Me.CheckBox1.CheckState = CheckState.Unchecked
        Me.catalog_base_path = Me.catalog_base_pathX
        'If Me.TextBox1.Text <> "" And Me.ComboBox1.SelectedIndex <> -1 Then
        If Me.TextBox1.Text <> "" Then
            Me.AcceptButton = Me.btnSearchCatalog
        End If

        'ds = New DataSet
        'ds.Tables.Add("packages")
        'ds.Tables("packages").Columns.Add("pkgid")
        'ds.Tables("packages").Columns.Add("title")
        'ds.Tables("packages").Columns.Add("released")
        'ds.Tables("packages").Columns.Add("crc")
        'bindingSource.DataSource = ds.Tables("packages")

        'Me.DataGridView1.DataSource = bindingSource
        Me.processArgs()

    End Sub

    Private Sub btnSearchCatalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCatalog.Click
        Me.ListBox1.Items.Clear()
        Me.DataGridView1.Rows.Clear()
        My.Computer.Registry.SetValue(key, "LastMT", Me.TextBox1.Text.ToString)
        If Me._rbWin10.Checked Then
            My.Computer.Registry.SetValue(key, "LastOS", "Win10")
        ElseIf Me._rbWin7.Checked Then
            My.Computer.Registry.SetValue(key, "LastOS", "Win7")
        ElseIf Me._rbWin81.Checked Then
            My.Computer.Registry.SetValue(key, "LastOS", "Win8")
        End If

        Me.TabControl1.SelectedTab = tp_status
        ProcessCatalog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.TextBox2.Text <> "" Then
            Dim s As String = Me.TextBox2.Text
            If Not s.Contains("_2_.xml") Then
                s = s & "_2_.xml"
            End If
            ProcessPackage(s)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.TextBox1.Text = Me.TextBox1.Text.ToUpper
        If Me.TextBox1.Text.Length = 4 Then
            If Me._rbWin7.Checked Or Me._rbWin81.Checked Or Me._rbWin10.Checked Then
                Me.btnSearchCatalog.Enabled = True
                Me.btnSearchCatalog.Focus()
            Else
                Me.btnSearchCatalog.Enabled = False
            End If
        Else
            Me.btnSearchCatalog.Enabled = False
        End If

        Me.AcceptButton = Me.btnSearchCatalog

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length > 6 Then
            Me.Button2.Enabled = True
        End If

        Me.AcceptButton = Me.Button2
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedIndex > -1 Then
            Me.btnSearchCatalog.Enabled = True
        Else
            Me.btnSearchCatalog.Enabled = False
        End If
    End Sub

    Private Sub _rbWin7_CheckedChanged(sender As Object, e As EventArgs) Handles _rbWin7.CheckedChanged
        If Me._rbWin7.Checked Or Me._rbWin81.Checked Or Me._rbWin10.checked Then
            Me.btnSearchCatalog.Enabled = True
        Else
            Me.btnSearchCatalog.Enabled = False
        End If
    End Sub

    Private Sub setStatus(ByVal texts As String)
        Me.ListBox1.Items.Add(texts)
        Me.ListBox1.SelectedItems.Clear()
        Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1
        Me.Update()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Try
            Process.Start(DataGridView1.CurrentRow.Cells.Item("xml2_path").Value & "?t=" & Now.Ticks.ToString)
        Catch ex As Exception
            MsgBox("Could not load XML2 file:" & ex.Message.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim CopytoClip As String
        Dim I As Integer
        Clipboard.Clear()
        CopytoClip = ""
        For I = 0 To ListBox1.SelectedItems.Count - 1

            CopytoClip = CopytoClip & Me.ListBox1.SelectedItems(I) & vbCrLf

        Next I
        Clipboard.SetText(CopytoClip)
    End Sub

#End Region

#Region "Catalog Handlers"
    Public Function getSHA256hash(ByVal fileName As String) As String
        Try
            If fileName = "" Then
                Return ""
            End If

            If Not File.Exists(fileName) Then
                Return ""
            End If

            Dim fs As New FileStream(fileName, FileMode.Open)
            Dim sha As New SHA256Managed()
            Dim result() As Byte = sha.ComputeHash(fs)
            fs.Close()
            Return BitConverter.ToString(result).Replace("-", "")

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub setColumns()
        Try
            Me.DataGridView1.Columns("PkgID").Visible = Me.cbPackageID.Checked
            Me.DataGridView1.Columns("PackageName").Visible = Me.cbPackageName.Checked
            Me.DataGridView1.Columns("Title").Visible = Me.cbTitle.Checked
            Me.DataGridView1.Columns("Version").Visible = Me.cbVersion.Checked
            Me.DataGridView1.Columns("Released").Visible = Me.cbReleased.Checked
            Me.DataGridView1.Columns("PackageType").Visible = Me.cbPackageType.Checked
            Me.DataGridView1.Columns("category").Visible = Me.cbCategory.Checked
            Me.DataGridView1.Columns("RebootType").Visible = Me.cbReboot.Checked
            Me.DataGridView1.Columns("Severity").Visible = Me.cbSeverity.Checked
            Me.DataGridView1.Columns("Brand").Visible = Me.cbBrand.Checked
            Me.DataGridView1.Columns("Setup").Visible = Me.cbSetup.Checked
            Me.DataGridView1.Columns("language").Visible = Me.cbLanguage.Checked
            Me.DataGridView1.Columns("Valid").Visible = Me.cbValid.Checked
            Me.DataGridView1.Columns("xml2_path").Visible = Me.cbXML2Path.Checked
            Me.DataGridView1.Columns("CRC").Visible = Me.cbCRC_Catalog.Checked
            Me.DataGridView1.Columns("crcactual").Visible = Me.cbCRC_Actual.Checked
            Me.DataGridView1.Columns("Comment").Visible = Me.cbComment.Checked

        Catch ex As Exception

        End Try
    End Sub
    Private Function getOSsuffix() As String
        Dim OS_suffix As String = ""
        If Me._rbWin7.Checked Then
            OS_suffix = "Win7"
        ElseIf Me._rbWin81.Checked Then
            OS_suffix = "Win8"
        ElseIf Me._rbWin10.Checked Then
            OS_suffix = "Win10"
        Else
            OS_suffix = "Win10"
        End If
        Return OS_suffix
    End Function
    Private Sub ProcessCatalog()
        Try
            Dim OS_suffix As String = getOSsuffix()

            Dim file_to_download As String = Me.TextBox1.Text & "_" & OS_suffix & ".xml"
            Dim desc_to_download As String = Me.TextBox1.Text & "_" & OS_suffix & "_DESC.xml"
            Me.setStatus("Downloading catalog descriptor: " & catalog_base_path & desc_to_download)

            _Downloader = New WebFileDownloader
            If _Downloader.DownloadFileWithProgress(catalog_base_path & desc_to_download & "?t=" & Now.Ticks().ToString, local_base_path & desc_to_download) Then


                Me.setStatus("Downloading catalog: " & catalog_base_path & file_to_download)
                Me.setStatus("To: " & local_base_path & file_to_download)

                If _Downloader.DownloadFileWithProgress(catalog_base_path & file_to_download & "?t=" & Now.Ticks().ToString, local_base_path & file_to_download) Then

                    Dim expectedCRC As String = getCatalogCRC(local_base_path & desc_to_download).ToLower
                    Me.setStatus("Expected CRC: " & expectedCRC)

                    Dim actualCRC As String = getSHA256hash(local_base_path & file_to_download).ToLower
                    Me.setStatus("Actual CRC: " & actualCRC)

                    If expectedCRC = actualCRC Then
                        Me.setStatus("CRCs Match!!")
                    Else
                        Me.setStatus("** CRCs DO NOT MATCH!! **")
                    End If
                    Dim pkgNameList As New List(Of String)
                    Dim pkgsList As List(Of _package) = getPackages(local_base_path & file_to_download)
                    Dim pkgNameListDL As New List(Of String)
                    If pkgsList IsNot Nothing Then
                        'Loop through and add pkg to DataGridView1
                        For Each pkg As _package In pkgsList
                            Me.DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual)

                            If pkgNameList.Contains(pkg.CPackageName) Then
                                If Not pkgNameListDL.Contains(pkg.CPackageName) Then
                                    pkgNameListDL.Add(pkg.CPackageName)
                                End If
                            Else
                                pkgNameList.Add(pkg.CPackageName)
                            End If

                        Next
                        If pkgNameListDL.Count > 0 Then
                            For Each z As String In pkgNameListDL
                                For Each y As _package In pkgsList
                                    If z = y.CPackageName Then
                                        Me.downlevelPackages.Add(y.CPkgID & vbTab & y.CPackageName & vbTab & y.CReleased & vbTab & "http://download.lenovo.com/catalog/" & Me.TextBox1.Text & "_" & ComboBox1.SelectedItem & ".xml" & vbTab & y.CURLxml2)
                                    End If
                                Next
                            Next
                        End If
                    End If
                    setColumns()
                    Me.DataGridView1.AutoResizeColumns()
                    Me.DataGridView1.Sort(DataGridView1.Columns("Valid"), System.ComponentModel.ListSortDirection.Ascending)
                    Me.SetBGColor()
                    Me.setStatus("Got all packages.")
                    Me.TabControl1.SelectedTab = tp_packages

                Else
                    Me.setStatus("Could not download catalog.")

                    Dim expectedCRC As String = getCatalogCRC(local_base_path & desc_to_download).ToLower
                    Me.setStatus("Expected CRC: " & expectedCRC)

                    Dim actualCRC As String = getSHA256hash(local_base_path & file_to_download).ToLower
                    Me.setStatus("Actual CRC: " & actualCRC)

                    If expectedCRC = actualCRC Then
                        Me.setStatus("CRCs Match!!")
                    Else
                        Me.setStatus("** CRCs DO NOT MATCH!! **")
                    End If

                    Dim pkgsList As List(Of _package) = getPackages(local_base_path & file_to_download)
                    If pkgsList IsNot Nothing Then
                        'Loop through and add pkg to DataGridView1
                        For Each pkg As _package In pkgsList
                            'Dim dRow As DataRow = ds.Tables("packages").NewRow()
                            'dRow.Item(0) = pkg.CPkgID
                            'dRow.Item(1) = pkg.CTitle
                            'dRow.Item(2) = ""
                            'dRow.Item(3) = pkg.Cxml2crc
                            'ds.Tables("packages").Rows.Add(dRow)

                            Me.DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual)
                        Next
                    End If
                    Me.DataGridView1.AutoResizeColumns()
                    Me.setStatus("Got all packages.")
                    Me.TabControl1.SelectedTab = tp_packages


                End If
            Else
                Me.setStatus("Could not download catalog descriptor.")
            End If

        Catch ex As Exception
            MsgBox("ProcessCatalog: " & ex.Message.ToString)
        End Try
    End Sub

    Private Function getCatalogCRC(ByVal catalog As String) As String
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            'Create the XML Document
            m_xmld = New XmlDocument()

            'Load the Xml file
            m_xmld.Load(catalog)

            'Get the list of name nodes
            m_nodelist = m_xmld.SelectNodes("/catalog")

            'Loop through the nodes
            For Each m_node In m_nodelist
                
                'Get the location Element Value
                Dim locationValue = m_node.ChildNodes.Item(0).InnerText

                'Get the checksum Element Value
                Dim crcValue = m_node.ChildNodes.Item(1).InnerText

                Return crcValue
            Next
            Return ""

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return ""
        End Try
    End Function
#End Region

#Region "Package Handlers"
    Public Function getSHAhash(ByVal fileName As String, ByVal hashtype As String) As String
        Try
            If fileName = "" Then
                Return ""
            End If

            If Not File.Exists(fileName) Then
                Return ""
            End If

            Dim fs As New FileStream(fileName, FileMode.Open)
            Dim sha As New SHA1Managed()
            Dim sha256 As New SHA256Managed()
            Dim result() As Byte
            Select Case hashtype
                Case "sha1"
                    result = sha.ComputeHash(fs)

                Case "sha256"
                    result = sha256.ComputeHash(fs)

            End Select

            fs.Close()
            Return BitConverter.ToString(result).Replace("-", "")

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Function getPackages(ByVal catalog As String) As List(Of _package)
        Try
            Dim m_list As New List(Of _package)
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            'Create the XML Document
            m_xmld = New XmlDocument()

            'Load the Xml file
            m_xmld.Load(catalog)

            'Get the list of package nodes
            m_nodelist = m_xmld.SelectNodes("/packages/package")

            Me.setStatus("Total packages (" & catalog.Substring(catalog.LastIndexOf("\") + 1) & "): " & m_nodelist.Count.ToString)
            Me.setStatus("Getting details for packages, please wait...")

            'Loop through the nodes
            For Each m_node In m_nodelist
                Dim thisPkg As New _package
                'Get the location Element Value
                thisPkg.CURLxml2 = m_node.ChildNodes.Item(0).InnerText

                'Get package ID
                Dim dot As Integer = thisPkg.CURLxml2.LastIndexOf(".")
                If dot > 30 Then
                    thisPkg.CPkgID = thisPkg.CURLxml2.Substring(thisPkg.CURLxml2.LastIndexOf("/") + 1, (thisPkg.CURLxml2.LastIndexOf(".") - thisPkg.CURLxml2.LastIndexOf("/") - 4))
                    'Get the category
                    thisPkg.CCategory = m_node.ChildNodes.Item(1).InnerText

                    'Get the languages
                    Dim m_nodelist_langs As XmlNodeList
                    Dim m_node_lang As XmlNode
                    Dim langs As String = ""
                    m_nodelist_langs = m_node.ChildNodes.Item(2).ChildNodes
                    For Each m_node_lang In m_nodelist_langs
                        langs &= m_node_lang.InnerText & ", "
                    Next
                    If langs.Length > 2 Then
                        langs = langs.Substring(0, langs.Length - 2)
                    End If

                    thisPkg.Clangs = langs

                    'Get the checksum Element Value
                    thisPkg.Cxml2crc = m_node.ChildNodes.Item(3).InnerText

                    'Get title and release date
                    getTitle(thisPkg)
                Else
                    thisPkg.CTitle = "Issue encountered with XML Package Descriptor file."
                End If

                m_list.Add(thisPkg)
            Next
            Return m_list
        Catch ex As Exception
            'setStatus("getPackages: " & ex.Message.ToString)
            Return Nothing

        End Try

    End Function

    Private Sub getTitle(ByRef thisPkg As _package)
        Try
            _Downloader = New WebFileDownloader
            _Downloader.DownloadFileWithProgress(thisPkg.CURLxml2 & "?t=" & Now.Ticks.ToString, local_base_path & thisPkg.CPkgID & "_2_.xml")
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            'Dim m_node As XmlNode

            'Create the XML Document
            m_xmld = New XmlDocument()

            'Load the Xml file
            m_xmld.Load(local_base_path & thisPkg.CPkgID & "_2_.xml")

            'Get the PackageName
            m_nodelist = m_xmld.SelectNodes("/Package")
            thisPkg.CPackageName = m_nodelist.Item(0).Attributes.ItemOf("name").Value
            thisPkg.CVersion = m_nodelist.Item(0).Attributes.ItemOf("version").Value

            'Get the Title node and pull text for <Desc> child node
            m_nodelist = m_xmld.SelectNodes("/Package/Title")
            thisPkg.CTitle = m_nodelist.Item(0).ChildNodes.Item(0).InnerText

            'Get the ReleaseDate node and pull innertext
            m_nodelist = m_xmld.SelectNodes("/Package/ReleaseDate")
            thisPkg.CReleased = m_nodelist.Item(0).InnerText

            'Get the PackageType node and pull "type" attribute
            m_nodelist = m_xmld.SelectNodes("/Package/PackageType")
            Select Case m_nodelist.Item(0).Attributes.ItemOf("type").Value
                Case 1
                    thisPkg.CPackageType = "1|Application"
                Case 2
                    thisPkg.CPackageType = "2|Driver"
                Case 3
                    thisPkg.CPackageType = "3|BIOS"
                Case 4
                    thisPkg.CPackageType = "4|Firmware"
                Case Else
                    thisPkg.CPackageType = "Other"
            End Select

            'Get the Severity node and pull "type" attribute
            m_nodelist = m_xmld.SelectNodes("/Package/Severity")
            Select Case m_nodelist.Item(0).Attributes.ItemOf("type").Value
                Case 1
                    thisPkg.CSeverity = "1|Critical"
                Case 2
                    thisPkg.CSeverity = "2|Recommended"
                Case 3
                    thisPkg.CSeverity = "3|Optional"

                Case Else
                    thisPkg.CSeverity = "Optional"
            End Select

            'Get the Brand node and pull "type" attribute
            m_nodelist = m_xmld.SelectNodes("/Package/Brand")
            Select Case m_nodelist.Item(0).Attributes.ItemOf("type").Value
                Case 1
                    thisPkg.CBrand = "1|All"
                Case 2
                    thisPkg.CBrand = "2|Think"
                Case 3
                    thisPkg.CBrand = "3|Lenovo Notebook"
                Case 4
                    thisPkg.CBrand = "4|Lenovo Desktop"
                Case Else
                    thisPkg.CBrand = "Other"
            End Select

            'Get the Reboot node and pull "type" attribute
            m_nodelist = m_xmld.SelectNodes("/Package/Reboot")
            Select Case m_nodelist.Item(0).Attributes.ItemOf("type").Value
                Case 0
                    thisPkg.CReboot = "0|No Reboot Required"
                Case 1
                    thisPkg.CReboot = "1|Forces Reboot"
                Case 2
                    thisPkg.CReboot = "2|Reserved"
                Case 3
                    thisPkg.CReboot = "3|Requires a Reboot"
                Case 4
                    thisPkg.CReboot = "4|Forces Shutdown"
                Case 5
                    thisPkg.CReboot = "5|Forced Reboot Delayed"
                Case Else
                    thisPkg.CReboot = "Other"
            End Select

            'Get the setup command
            m_nodelist = m_xmld.SelectNodes("/Package/Install")
            thisPkg.Csetup = m_nodelist.Item(0).ChildNodes.Item(0).InnerText

            'get detectinstall and add to file
            'm_nodelist = m_xmld.SelectNodes("/Package/DetectInstall")
            'Dim di As String = m_nodelist.Item(0).InnerXml
            'My.Computer.FileSystem.WriteAllText(local_base_path & "\di.xml", thisPkg.CPkgID & vbCrLf & di & vbCrLf & vbCrLf, True)

            'get the readme file
            m_nodelist = m_xmld.SelectNodes("/Package/Files/Readme/File")
            _Downloader = New WebFileDownloader
            If _Downloader.DownloadFileWithProgress(thisPkg.CURLxml2.Substring(0, thisPkg.CURLxml2.LastIndexOf("/") + 1) & m_nodelist.Item(0).ChildNodes.Item(0).InnerText & "?t=" & Now.Ticks.ToString, local_base_path & m_nodelist.Item(0).ChildNodes.Item(0).InnerText) Then
                thisPkg.CURLtxt = thisPkg.CURLxml2.Substring(0, thisPkg.CURLxml2.LastIndexOf("/") + 1) & m_nodelist.Item(0).ChildNodes.Item(0).InnerText
            End If

            If File.Exists(local_base_path & thisPkg.CPkgID & "_2_.xml") Then
                thisPkg.Cxml2crcactual = getSHA256hash(local_base_path & thisPkg.CPkgID & "_2_.xml").ToLower
                If thisPkg.Cxml2crc = thisPkg.Cxml2crcactual Then
                    thisPkg.Cxml2valid = "yes"
                Else
                    thisPkg.Cxml2valid = "no"
                End If

            End If

        Catch ex As Exception
            'setStatus("getTitle: " & ex.Message.ToString)
        End Try
    End Sub


    Private Sub ProcessPackage(ByVal pkgid As String, Optional ByVal xmlUrl As String = "")
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim found As String = ""
            Dim search As Boolean = False
            If xmlUrl = "" And pkgid <> "" Then
                search = True
                Dim file_mobiles As String = package_base_path & "mobiles/" & pkgid
                Dim file_thinkcentre As String = package_base_path & "thinkcentre_drivers/" & pkgid
                Dim file_tvt As String = package_base_path & "thinkvantage_en/" & pkgid
                Dim file_thinkcentre_bios As String = package_base_path & "thinkcentre_bios/" & pkgid
                Dim file_thinkcentre_sw As String = package_base_path & "thinkcentre_software/" & pkgid
                Dim file_options As String = package_base_path & "options/" & pkgid

                Me.setStatus("Searching for package: " & pkgid)

                _Downloader = New WebFileDownloader
                If _Downloader.DownloadFileWithProgress(file_mobiles & "?t=" & Now.Ticks.ToString, local_base_path & pkgid) Then
                    found = file_mobiles
                End If
                If _Downloader.DownloadFileWithProgress(file_thinkcentre & "?t=" & Now.Ticks.ToString, local_base_path & pkgid) Then
                    found = file_thinkcentre
                End If
                If _Downloader.DownloadFileWithProgress(file_tvt & "?t=" & Now.Ticks.ToString, local_base_path & pkgid) Then
                    found = file_tvt
                End If
                If _Downloader.DownloadFileWithProgress(file_thinkcentre_bios & "?t=" & Now.Ticks.ToString, local_base_path & pkgid) Then
                    found = file_thinkcentre_bios
                End If
                If _Downloader.DownloadFileWithProgress(file_thinkcentre_sw & "?t=" & Now.Ticks.ToString, local_base_path & pkgid) Then
                    found = file_thinkcentre_sw
                End If
                If _Downloader.DownloadFileWithProgress(file_options & "?t=" & Now.Ticks.ToString, local_base_path & pkgid) Then
                    found = file_options
                End If
            ElseIf pkgid = "" And xmlUrl <> "" Then
                search = False
                found = xmlUrl
            End If

            If found <> "" And search Then
                Me.setStatus("Found package: " & found)
                Process.Start(found)
                Dim exeFileName As String = ""
                If checkExe(found, exeFileName) Then
                    Me.setStatus("Installer CRC valid: " & exeFileName)
                Else
                    Me.setStatus("** INSTALLER (" & exeFileName & ") CRC INVALID!!! **")
                End If
            ElseIf found <> "" And Not search Then
                Dim exeFileName As String = ""
                If checkExe(found, exeFileName) Then
                    MsgBox("CRC check of the executable file(s), " & exeFileName & ", passed.", MsgBoxStyle.Information, "CRC is valid")
                Else
                    MsgBox("** CRC check of the executable file(s), " & exeFileName & ", failed!!! **", MsgBoxStyle.Critical, "Invalid CRC")
                End If
            Else
                Me.setStatus("Package not found!")
            End If
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            MsgBox("ProcessPackage: " & ex.Message.ToString)
        End Try
    End Sub

    Function checkExe(ByVal xmlUrl As String, Optional ByRef exeRef As String = Nothing) As Boolean

        Try
            Dim m_list As New List(Of _package)
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            Dim installerCheck As Boolean = True
            Dim externalCheck As Boolean = True
            Dim installer As String = ""
            Dim external As String = ""

            'Create the XML Document
            m_xmld = New XmlDocument()

            'Load the Xml file
            m_xmld.Load(xmlUrl & "?t=" & Now.Ticks.ToString)

            'Get the list of name nodes
            m_nodelist = m_xmld.SelectNodes("/Package/Files/Installer/File")
            'Loop through the nodes
            For Each m_node In m_nodelist
                Dim exe As String = ""
                Dim expected As String = ""
                Dim exeURL As String = xmlUrl.Substring(0, xmlUrl.LastIndexOf("/") + 1)
                'Get the location of exe
                exe = m_node.ChildNodes.Item(0).InnerText
                installer = exe
                exeURL = exeURL & exe
                expected = m_node.ChildNodes.Item(1).InnerText
                Dim hashtype As String = ""
                If expected.Length > 41 Then
                    hashtype = "sha256"
                Else
                    hashtype = "sha1"
                End If

                _Downloader = New WebFileDownloader
                If _Downloader.DownloadFileWithProgress(exeURL, local_base_path & exe) Then
                    Dim actual As String = getSHAhash(local_base_path & exe, hashtype)
                    If expected.ToLower = actual.ToLower Then
                        installerCheck = True
                    Else
                        installerCheck = False
                    End If
                Else
                    installerCheck = False
                End If
            Next
            'check external detection files
            m_nodelist = m_xmld.SelectNodes("/Package/Files/External/File")
            For Each m_node In m_nodelist
                Dim exeExternal As String = ""
                Dim expected As String = ""
                Dim exeURL As String = xmlUrl.Substring(0, xmlUrl.LastIndexOf("/") + 1)
                'Get the location of exe
                exeExternal = m_node.ChildNodes.Item(0).InnerText
                external = exeExternal
                exeURL = exeURL & exeExternal
                expected = m_node.ChildNodes.Item(1).InnerText
                Dim hashtype As String = ""
                If expected.Length > 41 Then
                    hashtype = "sha256"
                Else
                    hashtype = "sha1"
                End If
                _Downloader = New WebFileDownloader
                If _Downloader.DownloadFileWithProgress(exeURL, local_base_path & exeExternal) Then
                    Dim actual As String = getSHAhash(local_base_path & exeExternal, hashtype)
                    If expected.ToLower = actual.ToLower Then
                        externalCheck = True
                    Else
                        externalCheck = False
                    End If
                Else
                    externalCheck = False
                End If
            Next
            If installerCheck And externalCheck Then
                exeRef = installer & ", " & external
                Return True
            ElseIf Not installerCheck And externalCheck Then
                exeRef = installer
                Return False
            ElseIf installerCheck And Not externalCheck Then
                exeRef = external
                Return False
            End If
        Catch ex As Exception
            Me.setStatus("checkExe: " & ex.Message.ToString)
            Return False
        End Try
    End Function
#End Region

    '#Region "Download Helpers"
    '    'FIRES WHEN WE HAVE GOTTEN THE DOWNLOAD SIZE, SO WE KNOW WHAT BOUNDS TO GIVE THE PROGRESS BAR
    '    Private Sub _Downloader_FileDownloadSizeObtained(ByVal iFileSize As Long) Handles _Downloader.FileDownloadSizeObtained
    '        ProgBar.Value = 0
    '        ProgBar.Maximum = Convert.ToInt32(iFileSize)
    '        ProgBar.Visible = False
    '        Me.Update()
    '    End Sub

    '    'FIRES WHEN DOWNLOAD IS COMPLETE
    '    Private Sub _Downloader_FileDownloadComplete() Handles _Downloader.FileDownloadComplete
    '        ProgBar.Value = ProgBar.Maximum
    '        'Me.setStatus("File Download Complete")
    '        ProgBar.Visible = False
    '        Me.Update()
    '    End Sub
    '#End Region

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            Dim files() As String = Directory.GetFiles(local_base_path)
            Dim i As Integer = 0
            For Each _file As String In files
                i += 1
                System.IO.File.Delete(_file)
            Next
            Me.setStatus("Cleared " & i.ToString & " session files.")
        Catch ex As Exception
            Me.setStatus("btnClear_Click(): " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnThink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThink.Click

        If Not Me.cbWin7.Checked And Not Me.cbWinVista.Checked And Not Me.cbWinXP.Checked And Not Me.cbWin8.Checked And Not Me.cbWin10.Checked Then
            Exit Sub
        End If
        Try
            Me.ListBox1.SelectedItems.Clear()
            Me.ListBox1.Items.Clear()
            Me.DataGridView1.Rows.Clear()
            Me.TabControl1.SelectedTab = tp_status
            Dim fr As System.IO.StreamReader
            Dim ln As String
            If File.Exists(taxonomy) = False Then
                MessageBox.Show("Could not find taxonomy.ini file. File should exist in same directory as XML2Scanner.exe.", "Missing taxonomy", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            fr = File.OpenText(taxonomy)
            ln = fr.ReadLine()
            mt.Clear()
            subseries.Clear()
            cnt = 0
            Dim scratch As String = ""
            Dim prev As String = ""
            Do Until ln Is Nothing
                'Me.TextBox1.Text = ln
                scratch = ln.Substring(0, ln.IndexOf("="))
                If scratch <> prev Then
                    mt.Add(ln.Substring(ln.Length - 4))
                    If Not allmt Then
                        prev = scratch
                    End If
                End If

                ln = fr.ReadLine()
            Loop
            Me.setStatus("Found " & mt.Count.ToString & " sub-series.")
            Dim start As DateTime = Now

            Me.setStatus("Start analysis at " & start.ToString("H:mm:ss"))
            Me.setStatus(" ")
            Me.setStatus("Catalogs checked = 0")
            Me.ListBox1.SelectedItems.Clear()
            If mt.Count > 0 Then
                _Downloader = New WebFileDownloader
                For Each _mt As String In mt
                    If Me.cbWin10.Checked Then
                        mtValidate(_mt, "Win10")
                    End If
                    If Me.cbWin8.Checked Then
                        mtValidate(_mt, "Win8")
                    End If
                    If Me.cbWin7.Checked Then
                        mtValidate(_mt, "Win7")
                    End If
                    If Me.cbWinXP.Checked Then
                        mtValidate(_mt, "WinXP")
                    End If
                    If Me.cbWinVista.Checked Then
                        mtValidate(_mt, "WinVista")
                    End If

                Next

            End If
            Dim finish As DateTime = Now
            Dim elapsed As TimeSpan = finish.Subtract(start)

            Me.ListBox1.SelectedItems.Clear()
            Me.ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)

            Me.setStatus("Finished. Elapsed time = " & String.Format("{0:00}:{1:00}:{2:00}", elapsed.TotalHours, elapsed.Minutes, elapsed.Seconds))
            Me.setStatus("Catalog Descriptors with bad CRCs = " & Me.badCatalogCRC.Count.ToString)
            For Each s As String In badCatalogCRC
                Me.setStatus(s)
            Next
            'If Me.cmd Then
            '    Console.WriteLine("[" & tstamper() & "] Completed. Writing log file.")
            'End If
            writeLog()

            Threading.Thread.Sleep(5000)
            Me.SetBGColor()
            Me.TabControl1.SelectedTab = tp_packages

        Catch ex As Exception
            MsgBox("Exception in Think(): " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub mtValidate(ByVal _mt As String, ByVal _os As String)
        Try

            Dim uriCatalogDescXP As String = _mt & "_WinXP_DESC.xml"
            Dim uriCatalogXP As String = _mt & "_WinXP.xml"
            Dim uriCatalogDesc7 As String = _mt & "_Win7_DESC.xml"
            Dim uriCatalog7 As String = _mt & "_Win7.xml"
            Dim uriCatalogDescV As String = _mt & "_WinVista_DESC.xml"
            Dim uriCatalogV As String = _mt & "_WinVista.xml"
            Dim uriCatalogDesc8 As String = _mt & "_Win8_DESC.xml"
            Dim uriCatalog8 As String = _mt & "_Win8.xml"
            Dim uriCatalogDesc10 As String = _mt & "_Win10_DESC.xml"
            Dim uriCatalog10 As String = _mt & "_Win10.xml"
            Dim targetCat As String = ""
            Dim targetCatDesc As String = ""
            Select Case _os
                Case "Win10"
                    targetCat = uriCatalog10
                    targetCatDesc = uriCatalogDesc10

                Case "Win8"
                    targetCat = uriCatalog8
                    targetCatDesc = uriCatalogDesc8

                Case "WinXP"
                    targetCat = uriCatalogXP
                    targetCatDesc = uriCatalogDescXP

                Case "Win7"
                    targetCat = uriCatalog7
                    targetCatDesc = uriCatalogDesc7

                Case "WinVista"
                    targetCat = uriCatalogV
                    targetCatDesc = uriCatalogDescV

            End Select
            'Win7
            Dim status As String = "Catalogs checked = "
            _Downloader = New WebFileDownloader
            Me.Cursor = Cursors.WaitCursor
            If _Downloader.DownloadFileWithProgress(catalog_base_path & targetCatDesc, local_base_path & targetCatDesc) Then
                If _Downloader.DownloadFileWithProgress(catalog_base_path & targetCat, local_base_path & targetCat) Then
                    Dim expectedCRC As String = getCatalogCRC(local_base_path & targetCatDesc).ToLower

                    Dim actualCRC As String = getSHA256hash(local_base_path & targetCat).ToLower

                    If expectedCRC <> actualCRC Then
                        Me.badCatalogCRC.Add(catalog_base_path & targetCatDesc)
                    Else
                        cnt += 1
                        Dim i As Integer = Me.ListBox1.Items.Count - 1

                        Me.ListBox1.SelectedItems.Clear()
                        If Me.ListBox1.Items.Count > 1 Then
                            Me.ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                            Me.ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                        End If
                        Me.ListBox1.Items.Add(status & cnt.ToString)

                        Dim pkgsList As List(Of _package) = getPackages(local_base_path & targetCat)
                        Dim pkgNameList As New List(Of String)
                        Dim pkgNameListDL As New List(Of String)
                        If pkgsList IsNot Nothing Then
                            'Loop through and add pkg to DataGridView1
                            For Each pkg As _package In pkgsList
                                'is the CRC correct?
                                Dim found As Boolean = False
                                If pkg.Cxml2valid = "no" Or pkg.Cxml2valid = "" Then

                                    For Each itm As DataGridViewRow In DataGridView1.Rows
                                        If itm.Cells("xml2_path").Value = pkg.CURLxml2 Then
                                            found = True
                                            Exit For
                                        End If
                                    Next
                                    If Not found Then
                                        Me.DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual, _mt & "_" & _os & ".xml")
                                    End If
                                End If
                                'Is it a downlevel package?
                                found = False
                                'For Each item As String In pkgNameList
                                '    If pkg.CPackageName = item Then
                                '        found = True
                                '        If Not pkgNameListDL.Contains(item) Then
                                '            pkgNameListDL.Add(item)
                                '        End If
                                '        'Me.downlevelPackages.Add(pkg.CPkgID & vbTab & pkg.CPackageName & vbTab & "http://download.lenovo.com/catalog/" & _mt & "_" & _os & ".xml" & vbTab & pkg.CURLxml2)
                                '        Exit For
                                '    End If
                                'Next

                                'If Not found And pkg.CPackageName <> "" Then
                                '    pkgNameList.Add(pkg.CPackageName)
                                'End If

                                If pkgNameList.Contains(pkg.CPackageName) Then
                                    If Not pkgNameListDL.Contains(pkg.CPackageName) Then
                                        pkgNameListDL.Add(pkg.CPackageName)
                                    End If
                                Else
                                    pkgNameList.Add(pkg.CPackageName)
                                End If

                            Next
                            If pkgNameListDL.Count > 0 Then
                                For Each z As String In pkgNameListDL
                                    For Each y As _package In pkgsList
                                        If z = y.CPackageName Then
                                            Me.downlevelPackages.Add(y.CPkgID & vbTab & y.CPackageName & vbTab & y.CReleased & vbTab & "http://download.lenovo.com/catalog/" & _mt & "_" & _os & ".xml" & vbTab & y.CURLxml2)
                                        End If
                                    Next
                                Next
                            End If


                        End If

                    End If
                Else
                    Me.ListBox1.Items.Add("Failed to download " & catalog_base_path & targetCat)
                    Me.Update()
                End If
            Else
                Me.ListBox1.Items.Add("Failed to download " & catalog_base_path & targetCatDesc)
                Me.Update()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Exception in mtValidate(): " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub writeLog(Optional ByVal mtSearch As Boolean = False)
        Dim tstamp As String = tstamper() 'Now.Year.ToString & Now.Month.ToString & Now.Day.ToString & "-" & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString
        Dim out As New StreamWriter(".\scan_log_" & tstamp & ".txt", False, System.Text.Encoding.UTF8)
        out.WriteLine("Catalog Scan Log: " & Now.Month.ToString & "/" & Now.Day.ToString & "/" & Now.Year.ToString & " - " & Now.Hour.ToString & ":" & Now.Minute.ToString)
        out.WriteLine(" ")
        If Not mtSearch Then
            out.WriteLine("Catalogs with incorrect CRC in Catalog DESC file:")
            For Each s As String In badCatalogCRC
                out.WriteLine(s)
            Next
            out.WriteLine(" ")
        End If

        If Not mtSearch Then
            out.WriteLine("Packages in Catalogs with incorrect CRC values:")
        Else
            out.WriteLine("Packages in the catalog for " & Me.TextBox1.Text & "_" & getOSsuffix() & ":")
        End If

        Dim header As String = ""
        For Each ch As DataGridViewColumn In DataGridView1.Columns
            header = header & ch.HeaderText & vbTab
        Next
        out.WriteLine(header)
        Try
            For Each dr As DataGridViewRow In Me.DataGridView1.Rows
                Dim ln As String = ""
                For Each itm As DataGridViewCell In dr.Cells
                    If itm.Value Is Nothing Then
                        ln = ln & vbTab
                    Else
                        ln = ln & itm.Value.ToString & vbTab
                    End If

                Next
                out.WriteLine(ln)
            Next
        Catch ex As Exception
            MsgBox("Exception in writelog(): " & ex.Message.ToString)
        End Try

        out.WriteLine(" ")
        out.WriteLine("Down level packages:")
        out.WriteLine("Package ID" & vbTab & "Package Name" & vbTab & "Released" & vbTab & "Catalog found in" & vbTab & "Package XML2 URL")

        Try
            For Each item As String In Me.downlevelPackages
                out.WriteLine(item)
            Next
        Catch ex As Exception

        End Try

        out.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.catalog_base_path = Me.catalog_base_pathS
        Else
            Me.catalog_base_path = Me.catalog_base_pathX
        End If
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        Me.SetBGColor()

    End Sub

    Private Sub SetBGColor()
        Dim cnt As Integer = DataGridView1.Rows.Count - 1

        Do While cnt >= 0
            If cnt Mod 2 = 1 Then
                Me.DataGridView1.Rows(cnt).DefaultCellStyle.BackColor = Color.Cornsilk
            Else
                Me.DataGridView1.Rows(cnt).DefaultCellStyle.BackColor = Color.White
            End If
            If Me.DataGridView1.Rows(cnt).Cells("Valid").Value <> "yes" Then
                Me.DataGridView1.Rows(cnt).DefaultCellStyle.BackColor = Color.LightGray
                Me.DataGridView1.Rows(cnt).DefaultCellStyle.ForeColor = Color.Blue

            End If
            cnt -= 1
        Loop
    End Sub

    Private Sub linkTaxonomy_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTaxonomy.LinkClicked
        Process.Start("https://download.lenovo.com/luc/bios.txt")
    End Sub

    Private Sub cbPackageID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBrand.CheckedChanged, cbCategory.CheckedChanged, cbComment.CheckedChanged, cbCRC_Actual.CheckedChanged, cbCRC_Catalog.CheckedChanged, cbPackageID.CheckedChanged, cbPackageName.CheckedChanged, cbPackageType.CheckedChanged, cbReboot.CheckedChanged, cbReleased.CheckedChanged, cbSetup.CheckedChanged, cbSeverity.CheckedChanged, cbTitle.CheckedChanged, cbValid.CheckedChanged, cbVersion.CheckedChanged, cbXML2Path.CheckedChanged
        setColumns()
    End Sub

    Private Sub cbWin7_CheckStateChanged(sender As Object, e As EventArgs) Handles cbWin7.CheckStateChanged, cbWin10.CheckStateChanged, cbWinXP.CheckStateChanged, cbWin8.CheckStateChanged, cbWinVista.CheckStateChanged
        Me.AcceptButton = Me.btnThink
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count = 1 Then
            Me.btnCheckCRC.Enabled = True
        Else
            Me.btnCheckCRC.Enabled = False
        End If
    End Sub

    Private Sub btnCheckCRC_Click(sender As Object, e As EventArgs) Handles btnCheckCRC.Click
        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim xmlURL As String = row.Cells("xml2_path").Value.ToString
        ProcessPackage("", xmlURL)
    End Sub

    Private Sub cbPackageID_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbPackageID.CheckedChanged

    End Sub

    Private Sub linkDocks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDocks.LinkClicked
        Process.Start("https://download.lenovo.com/luc/docks.txt")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
