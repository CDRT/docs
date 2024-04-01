Imports System.IO
Imports System.Xml


Public Class Form1

    Public missing_xml As New List(Of String)
    Public missing_dir As New List(Of String)
    Public missing_exe As New List(Of String)
    Public retrieved_xml As New List(Of String)
    Private WithEvents _Downloader As WebFileDownloader

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.TextBox1.Text = OpenFileDialog1.FileName.ToString
                displayLog()
            End If
        Catch ex As Exception
            MsgBox("Exception in btnBrowse_Click(): " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub displayLog()
        Try

            If System.IO.File.Exists(Me.TextBox1.Text.ToString) Then

                'If Me.flpResult.Controls.Count > 0 Then
                '    Me.flpResult.Controls.Clear()
                'End If
                'Dim _log As String = Me.TextBox1.Text.ToString

                'If File.Exists(_log) Then
                '    Dim tf_log As New StreamReader(_log)
                '    Dim read_line As String = tf_log.ReadLine()
                '    While Not read_line.Contains("Message: The command is:")
                '        read_line = tf_log.ReadLine()
                '    End While

                '    Dim line1 As New Label
                '    line1.AutoSize = True
                '    line1.Text = read_line
                '    Me.flpResult.Controls.Add(line1)

                '    read_line = tf_log.ReadLine()
                '    While Not read_line.Contains("Message: Application runs with the framework:")
                '        read_line = tf_log.ReadLine()
                '    End While

                '    Dim line2 As New Label
                '    line2.Text = read_line
                '    line2.AutoSize = True
                '    Me.flpResult.Controls.Add(line2)

                '    read_line = tf_log.ReadLine()
                '    While Not read_line.Contains("Message: Data to be set in the Environment Manager to use with Quest: ")
                '        read_line = tf_log.ReadLine()
                '    End While

                '    Dim line3 As New Label
                '    line3.Text = tf_log.ReadLine() & vbCrLf & tf_log.ReadLine & vbCrLf & tf_log.ReadLine
                '    line3.AutoSize = True
                '    Me.flpResult.Controls.Add(line3)

                '    read_line = tf_log.ReadLine()
                '    While Not read_line.Contains("Message: 'Share name' to use:")
                '        read_line = tf_log.ReadLine()
                '    End While

                '    Dim line4 As New Label
                '    line4.Text = read_line
                '    line4.AutoSize = True
                '    Me.flpResult.Controls.Add(line4)

                '    read_line = tf_log.ReadLine()
                '    While Not read_line.Contains("Message: Resulted order of candidate list:")
                '        read_line = tf_log.ReadLine()
                '    End While

                '    read_line = tf_log.ReadLine()
                '    Dim line5 As New ListBox
                '    line5.BorderStyle = BorderStyle.None
                '    line5.BeginUpdate()
                '    line5.Items.Clear()
                '    line5.Width = Me.flpResult.Width - 10
                '    line5.MultiColumn = False
                '    line5.BackColor = Color.Black
                '    line5.ForeColor = Color.White
                '    line5.HorizontalScrollbar = True

                '    While read_line <> ""
                '        line5.Items.Add(read_line)
                '        read_line = tf_log.ReadLine()

                '    End While

                '    line5.Height = line5.Items.Count * 18
                '    line5.EndUpdate()
                '    Me.flpResult.Controls.Add(line5)

                '    Dim line6 As New ListBox
                '    line6.BorderStyle = BorderStyle.None
                '    line6.BeginUpdate()
                '    line6.Items.Clear()
                '    line6.Width = Me.flpResult.Width - 10
                '    line6.MultiColumn = False
                '    line6.BackColor = Color.GhostWhite
                '    line6.ForeColor = Color.Black
                '    line6.HorizontalScrollbar = True
                '    read_line = tf_log.ReadLine()
                '    While Not read_line Is Nothing
                '        If read_line.Contains("update installation failed") Then
                '            line6.Items.Add(read_line.Trim())
                '        End If
                '        read_line = tf_log.ReadLine()
                '    End While

                '    Me.flpResult.Controls.Add(line6)

                '    Me.Update()
                'Else
                '    MsgBox("Log file not found at path specified.", MsgBoxStyle.OkOnly, "TI Log Viewer")
                'End If

                Dim _log As String = Me.TextBox1.Text.ToString
                Dim _packageNames As New List(Of String)
                'clear rtbView first
                Me.rtbViewer.Clear()

                'read line and add it to rtbViewer
                If File.Exists(_log) Then
                    Dim tf_log As New StreamReader(_log)
                    Dim read_line As String = tf_log.ReadLine()
                    If Not read_line.Contains("[Thin Installer build:") And Not read_line.Contains("[Lenovo System Update build:") Then
                        Me.rtbViewer.SelectionColor = Color.Red
                        Me.rtbViewer.AppendText("This file is not a valid System Update or ThinInstaller Log file.")
                        Exit Sub
                    End If
                    Dim dCount As Integer = 1
                    While Not tf_log.EndOfStream
                        If read_line.Contains("[Thin Installer build:") Or read_line.Contains("[Lenovo System Update build:") Then
                            Me.rtbViewer.SelectionColor = Color.Green
                            Me.rtbViewer.AppendText(read_line & vbCrLf)
                        ElseIf read_line.Contains("Message: Data to be set in the Environment Manager to use with Quest:") Then
                            Me.rtbViewer.SelectionColor = Color.Green
                            read_line = tf_log.ReadLine()
                            Me.rtbViewer.AppendText(read_line & vbCrLf)
                            read_line = tf_log.ReadLine()
                            Me.rtbViewer.SelectionColor = Color.Green
                            Me.rtbViewer.AppendText(read_line & vbCrLf)
                            read_line = tf_log.ReadLine()
                            Me.rtbViewer.SelectionColor = Color.Green
                            Me.rtbViewer.AppendText(read_line & vbCrLf)
                        ElseIf read_line.Contains("Message: 'Share name' to use:") Then
                            Me.rtbViewer.SelectionColor = Color.Black
                            Me.rtbViewer.AppendText(read_line & vbCrLf)
                        ElseIf read_line.Contains("Message: Executing the PostProcess CleanUpProcess") Then
                            read_line = tf_log.ReadLine()
                            read_line = tf_log.ReadLine()
                            read_line = tf_log.ReadLine()
                            read_line = tf_log.ReadLine()
                            Me.rtbViewer.SelectionColor = Color.Green
                            Me.rtbViewer.AppendText(read_line & vbCrLf)
                        ElseIf read_line.Contains("Message: the File to download is completed:") Then

                            While Not read_line.Contains("Message: the Downloader process was finished without problems")
                                If read_line.Contains("Message: the File to download is completed:") Then
                                    Me.rtbViewer.AppendText(read_line.Substring(44) & vbCrLf)
                                End If
                                read_line = tf_log.ReadLine()
                            End While

                        ElseIf read_line.Contains("at Tvsu.Coreq.LoadCoreqsProcessor.ProcessUpdatesImplementation(Update[] ups)") Then
                            read_line = tf_log.ReadLine()
                            Me.rtbViewer.AppendText(vbCrLf)
                            Dim i As Integer = 1
                            dCount = 1
                            read_line = tf_log.ReadLine()
                            While read_line <> ""
                                Me.rtbViewer.SelectionColor = Color.Black
                                Me.rtbViewer.AppendText(i.ToString & vbTab & read_line & vbCrLf)
                                i += 1
                                read_line = tf_log.ReadLine()
                            End While

                            'ElseIf read_line.Contains("Message: Beginning Coreq process:") Then
                            '    Dim n As Integer = 1
                            '    Dim outer As Boolean = True
                            '    Dim inner As Boolean = True
                            '    While outer
                            '        read_line = tf_log.ReadLine()
                            '        If read_line.Contains("at Tvsu.Gur.GUR2.EvaluateDetectInstall()") Then
                            '            read_line = tf_log.ReadLine()
                            '            If read_line.Contains("Rule result:") Then
                            '                Me.rtbViewer.AppendText(n.ToString & vbTab & "DetectInstall" & vbTab & read_line & vbCrLf)
                            '            End If
                            '            While inner
                            '                read_line = tf_log.ReadLine()

                            '            End While
                            '        End If
                            '    End While
                        ElseIf read_line.Contains("at Tvsu.Gur.GUR2.EvaluateDetectInstall()") Then
                            read_line = tf_log.ReadLine()
                            If read_line.Contains("Rule result") Then
                                Me.rtbViewer.SelectionColor = Color.DarkMagenta
                                Me.rtbViewer.AppendText(dCount.ToString & "." & vbTab & "DetectInstall: " & read_line & vbCrLf)
                                dCount += 1
                            End If

                        ElseIf read_line.Contains("at Tvsu.Gur.GUR2.EvaluateDependencies(Boolean useCoreqs)") Then
                            read_line = tf_log.ReadLine()
                            If read_line.Contains("Rule result") Then
                                Me.rtbViewer.SelectionColor = Color.DarkMagenta
                                Me.rtbViewer.AppendText(vbTab & "Dependencies: " & read_line & vbCrLf)
                            End If

                        ElseIf read_line.Contains("Message: Expected return code:") Then
                            Me.rtbViewer.SelectionColor = Color.DarkGreen
                            Me.rtbViewer.AppendText("Return code: " & read_line & vbCrLf)

                        ElseIf read_line.Contains("at Tvsu.Engine.Process.PackageInstallerProcess.InstallNewUpdates()") Then
                            read_line = tf_log.ReadLine()
                            If read_line.Contains("failed") Then
                                Me.rtbViewer.SelectionColor = Color.Red
                            Else
                                Me.rtbViewer.SelectionColor = Color.DarkGreen
                            End If

                            Me.rtbViewer.AppendText("Install Result: " & read_line & vbCrLf)

                        ElseIf read_line.Contains(" failed") Then
                            If Not read_line.Contains("constraint") Then
                                Me.rtbViewer.SelectionColor = Color.Red
                                Me.rtbViewer.AppendText(read_line & vbCrLf)
                            End If
                        ElseIf read_line.Contains("Message: Error reading C:\ProgramData\Lenovo\SystemUpdate\session\system\SSClientCommon") Then
                                'Me.rtbViewer.SelectionColor = Color.Red
                                'Me.rtbViewer.AppendText(read_line & vbCrLf)
                                read_line = tf_log.ReadLine()
                                read_line = tf_log.ReadLine()
                                read_line = tf_log.ReadLine()
                                read_line = tf_log.ReadLine()
                                'skip over SSCLIENTCOMMON check as it always throws an exception unless there is an UTS available.

                            ElseIf read_line.Contains("Exception:") Then
                                Me.rtbViewer.SelectionColor = Color.Red
                                Me.rtbViewer.AppendText(read_line & vbCrLf)
                                read_line = tf_log.ReadLine()
                                Me.rtbViewer.SelectionColor = Color.Red
                                Me.rtbViewer.AppendText(read_line & vbCrLf)
                                read_line = tf_log.ReadLine()
                                Me.rtbViewer.SelectionColor = Color.Red
                                Me.rtbViewer.AppendText(read_line & vbCrLf)
                            Else
                                'Me.rtbViewer.SelectionColor = Color.Gray
                                'Me.rtbViewer.AppendText(read_line & vbCrLf)
                            End If

                        read_line = tf_log.ReadLine()
                    End While
                    tf_log.Close()

                End If
            Else
                MsgBox("Path specified is not a valid log file.", MsgBoxStyle.OkOnly, "TI Log Viewer")
            End If



        Catch ex As Exception
            MsgBox("Exception in btnCheck_Click(): " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub WriteLog()

        Try
            Dim TextFile As New StreamWriter("RepositoryCheck.log")

            If retrieved_xml.Count > 0 Then
                TextFile.WriteLine("Retrieved XML descriptors:")
                For Each item As String In retrieved_xml
                    TextFile.WriteLine(item)
                Next
                TextFile.WriteLine(" ")
            End If

            If missing_dir.Count > 0 Then
                TextFile.WriteLine("Missing package subdirectories:")
                For Each item As String In missing_dir
                    TextFile.WriteLine(item)
                Next
                TextFile.WriteLine(" ")
            End If

            If missing_xml.Count > 0 Then
                TextFile.WriteLine("Missing XML package descriptors:")
                For Each item As String In missing_xml
                    TextFile.WriteLine(item)
                Next
                TextFile.WriteLine(" ")
            End If

            If missing_exe.Count > 0 Then
                TextFile.WriteLine("Missing package executables:")
                For Each item As String In missing_exe
                    TextFile.WriteLine(item)
                Next
            End If
            TextFile.Close()

        Catch ex As Exception
            MsgBox("Exception in WriteLog(): " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Me.TextBox1.Text <> "" Then
            Me.btnExit.Enabled = True
        Else
            Me.btnExit.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.TextBox1.Text = "E:\ur1"
        Me.Text = "SU-TI Log Viewer v" & My.Application.Info.Version.ToString
        Me.Height = My.Computer.Screen.WorkingArea.Height
        Me.SetDesktopLocation(0, 0)
    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If files.Count = 1 Then
            If files(0).EndsWith(".log") Or files(0).EndsWith(".txt") Then
                Me.TextBox1.Text = files(0)
                displayLog()
            End If
        End If
    End Sub
End Class
