Public Class _catalog
    'Package Count
    Private m_pkgcnt As Integer

    Public Property Cpkgcnt() As Integer

        Get

            Return m_pkgcnt

        End Get

        Set(ByVal value As Integer)

            m_pkgcnt = value

        End Set

    End Property

    ' Catalog CRC

    Private m_pkgcrc As String

    Public Property Cpkgcrc() As Integer

        Get

            Return m_pkgcrc

        End Get

        Set(ByVal value As Integer)

            m_pkgcrc = value

        End Set

    End Property

    'Package Name
    Private m_pkgname As Integer

    Public Property Cpkgname() As String

        Get

            Return m_pkgname

        End Get

        Set(ByVal value As String)

            m_pkgname = value

        End Set

    End Property
End Class
