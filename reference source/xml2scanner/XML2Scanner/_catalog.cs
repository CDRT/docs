using Microsoft.VisualBasic.CompilerServices;

namespace XML2Scanner
{
    public class _catalog
    {
        // Package Count
        private int m_pkgcnt;

        public int Cpkgcnt
        {

            get
            {

                return m_pkgcnt;

            }

            set
            {

                m_pkgcnt = value;

            }

        }

        // Catalog CRC

        private string m_pkgcrc;

        public int Cpkgcrc
        {

            get
            {

                return Conversions.ToInteger(m_pkgcrc);

            }

            set
            {

                m_pkgcrc = value.ToString();

            }

        }

        // Package Name
        private int m_pkgname;

        public string Cpkgname
        {

            get
            {

                return m_pkgname.ToString();

            }

            set
            {

                m_pkgname = Conversions.ToInteger(value);

            }

        }
    }
}