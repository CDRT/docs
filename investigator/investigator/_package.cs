using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigator
{
    class _package
    {
        // Package ID

        private string m_pkgid;

        public string CPkgID
        {

            get
            {

                return m_pkgid;

            }

            set
            {

                m_pkgid = value;

            }

        }

        // Package Name

        private string m_pkgname;

        public string CPackageName
        {

            get
            {

                return m_pkgname;

            }

            set
            {

                m_pkgname = value;

            }

        }

        // Package Version

        private string m_version;

        public string CVersion
        {

            get
            {

                return m_version;

            }

            set
            {

                m_version = value;

            }

        }

        // Package Type

        private string m_pkgtype;

        public string CPackageType
        {

            get
            {

                return m_pkgtype;

            }

            set
            {

                m_pkgtype = value;

            }

        }

        // Package Reboot

        private string m_reboot;

        public string CReboot
        {

            get
            {

                return m_reboot;

            }

            set
            {

                m_reboot = value;

            }

        }

        // Package Brand

        private string m_brand;

        public string CBrand
        {

            get
            {

                return m_brand;

            }

            set
            {

                m_brand = value;

            }

        }

        // Package Severity

        private string m_severity;

        public string CSeverity
        {

            get
            {

                return m_severity;

            }

            set
            {

                m_severity = value;

            }

        }

        // Package Title

        private string m_title;

        public string CTitle
        {

            get
            {

                return m_title;

            }

            set
            {

                m_title = value;

            }

        }

        // Release Date

        private DateTime m_released;

        public DateTime CReleased
        {

            get
            {

                return m_released;

            }

            set
            {

                m_released = value;

            }

        }

        // URL to XML2
        private string m_urlxml2;

        public string CURLxml2
        {

            get
            {

                return m_urlxml2;

            }

            set
            {

                m_urlxml2 = value;

            }

        }

        // Category
        private string m_category;

        public string CCategory
        {

            get
            {

                return m_category;

            }

            set
            {

                m_category = value;

            }

        }

        // URL to EXE
        private string m_urlexe;

        public string CURLexe
        {

            get
            {

                return m_urlexe;

            }

            set
            {

                m_urlexe = value;

            }

        }

        // CRC of EXE
        private string m_crcexe;

        public string CCRCexe
        {

            get
            {
                return m_crcexe;
            }

            set
            {
                m_crcexe = value;
            }

        }

        // URL to Readme TXT
        private string m_urltxt;

        public string CURLtxt
        {

            get
            {
                return m_urltxt;
            }

            set
            {
                m_urltxt = value;
            }

        }


        // XML2 crc
        private string m_xml2crc;

        public string Cxml2crc
        {

            get
            {

                return m_xml2crc;

            }

            set
            {

                m_xml2crc = value;

            }

        }

        // XML2 CRC actual
        private string m_xml2crcactual;
        public string Cxml2crcactual
        {

            get
            {

                return m_xml2crcactual;

            }

            set
            {

                m_xml2crcactual = value;

            }

        }

        // XML2 crc check
        private string m_xml2valid;

        public string Cxml2valid
        {

            get
            {

                return m_xml2valid;

            }

            set
            {

                m_xml2valid = value;

            }

        }

        // EXE crc check
        private string m_exevalid;

        public string Cexevalid
        {

            get
            {

                return m_exevalid;

            }

            set
            {

                m_exevalid = value;

            }

        }

        // Language tags
        private string m_langs;

        public string Clangs
        {

            get
            {

                return m_langs;

            }

            set
            {

                m_langs = value;

            }

        }

        // Setup command
        private string m_setup;
        public string Csetup
        {

            get
            {

                return m_setup;

            }

            set
            {

                m_setup = value;

            }

        }

    }
}
