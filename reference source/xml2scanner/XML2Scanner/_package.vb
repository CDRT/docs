Public Class _package
    ' Package ID

    Private m_pkgid As String

    Public Property CPkgID() As String

        Get

            Return m_pkgid

        End Get

        Set(ByVal value As String)

            m_pkgid = value

        End Set

    End Property

    ' Package Name

    Private m_pkgname As String

    Public Property CPackageName() As String

        Get

            Return m_pkgname

        End Get

        Set(ByVal value As String)

            m_pkgname = value

        End Set

    End Property

    ' Package Version

    Private m_version As String

    Public Property CVersion() As String

        Get

            Return m_version

        End Get

        Set(ByVal value As String)

            m_version = value

        End Set

    End Property

    ' Package Type

    Private m_pkgtype As String

    Public Property CPackageType() As String

        Get

            Return m_pkgtype

        End Get

        Set(ByVal value As String)

            m_pkgtype = value

        End Set

    End Property

    ' Package Reboot

    Private m_reboot As String

    Public Property CReboot() As String

        Get

            Return m_reboot

        End Get

        Set(ByVal value As String)

            m_reboot = value

        End Set

    End Property

    ' Package Brand

    Private m_brand As String

    Public Property CBrand() As String

        Get

            Return m_brand

        End Get

        Set(ByVal value As String)

            m_brand = value

        End Set

    End Property

    ' Package Severity

    Private m_severity As String

    Public Property CSeverity() As String

        Get

            Return m_severity

        End Get

        Set(ByVal value As String)

            m_severity = value

        End Set

    End Property

    ' Package Title

    Private m_title As String

    Public Property CTitle() As String

        Get

            Return m_title

        End Get

        Set(ByVal value As String)

            m_title = value

        End Set

    End Property

    ' Release Date

    Private m_released As Date

    Public Property CReleased() As Date

        Get

            Return m_released

        End Get

        Set(ByVal value As Date)

            m_released = value

        End Set

    End Property

    ' URL to XML2
    Private m_urlxml2 As String

    Public Property CURLxml2() As String

        Get

            Return m_urlxml2

        End Get

        Set(ByVal value As String)

            m_urlxml2 = value

        End Set

    End Property

    ' Category
    Private m_category As String

    Public Property CCategory() As String

        Get

            Return m_category

        End Get

        Set(ByVal value As String)

            m_category = value

        End Set

    End Property

    ' URL to EXE
    Private m_urlexe As String

    Public Property CURLexe() As String

        Get

            Return m_urlexe

        End Get

        Set(ByVal value As String)

            m_urlexe = value

        End Set

    End Property

    ' CRC of EXE
    Private m_crcexe As String

    Public Property CCRCexe() As String

        Get
            Return m_crcexe
        End Get

        Set(ByVal value As String)
            m_crcexe = value
        End Set

    End Property

    'URL to Readme TXT
    Private m_urltxt As String

    Public Property CURLtxt() As String

        Get
            Return m_urltxt
        End Get

        Set(ByVal value As String)
            m_urltxt = value
        End Set

    End Property


    'XML2 crc
    Private m_xml2crc As String

    Public Property Cxml2crc() As String

        Get

            Return m_xml2crc

        End Get

        Set(ByVal value As String)

            m_xml2crc = value

        End Set

    End Property

    'XML2 CRC actual
    Private m_xml2crcactual As String
    Public Property Cxml2crcactual() As String

        Get

            Return m_xml2crcactual

        End Get

        Set(ByVal value As String)

            m_xml2crcactual = value

        End Set

    End Property

    'XML2 crc check
    Private m_xml2valid As String

    Public Property Cxml2valid() As String

        Get

            Return m_xml2valid

        End Get

        Set(ByVal value As String)

            m_xml2valid = value

        End Set

    End Property

    'EXE crc check
    Private m_exevalid As String

    Public Property Cexevalid() As String

        Get

            Return m_exevalid

        End Get

        Set(ByVal value As String)

            m_exevalid = value

        End Set

    End Property

    'Language tags
    Private m_langs As String

    Public Property Clangs() As String

        Get

            Return m_langs

        End Get

        Set(ByVal value As String)

            m_langs = value

        End Set

    End Property

    'Setup command
    Private m_setup As String
    Public Property Csetup() As String

        Get

            Return m_setup

        End Get

        Set(ByVal value As String)

            m_setup = value

        End Set

    End Property
End Class
