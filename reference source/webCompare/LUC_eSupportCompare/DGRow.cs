using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUC_eSupportCompare
{
    public class DGRow
    {
        const int ON_BOTH = 0;
        const int VERSION_MISMATCH = 1;
        const int EXE_MISMATCH = 2;
        const int HASH_TYPE_MISMATCH = 3;
        const int HASH_CONTENT_MISMATCH = 4;
        const int CRC_EXE_MISMATCH = 5;
        const int CRC_XML_MISMATCH = 6;
        const int NOT_ON_ESUPPORT = 7;
        const int NOT_ON_SU = 8;
        const int MATCHED_DIFF_PACKAGE = 9;

        //public int location { get; set; }
        public string name { get; set; }
        public string package { get; set; }
        public string eSupportVersion { get; set; }
        public string eSupportDSLink { get; set; }
        public string eSupportExeLink { get; set; }
        public string eSupportCategory { get; set; }
        public string eSupportReleaseDate { get; set; }
        public string eSupportHash { get; set; }
        public string suVersion { get; set; }
        public string suCatalogLink { get; set; }
        public string suExeLink { get; set; }
        public string suCategory { get; set; }
        public string suReleaseDate { get; set; }
        public string suGivenEXEHash { get; set; }
        public string suComputedEXEHash { get; set; }
        public string suGivenXMLHash { get; set; }
        public string suComputedXMLHash { get; set; }
        public string Issues { get; set; }

        public string lucVersion { get; set; }

        public string lucXML { get; set; }
        public string model { get; set; }

        public DGRow(DownloadItem e, DownloadItem s, string m)
        {
            if (e != null && s != null)
            {
                name = e.Name;
                package = e.ID;
                eSupportVersion = e.Version;
                eSupportDSLink = e.PageURL;
                eSupportExeLink = e.ExeURL;
                eSupportCategory = e.Category;
                try
                {
                    string[] temp = e.ReleaseDate.Split(' ')[0].Split('/');
                    eSupportReleaseDate = String.Format("{0}-{1}-{2}", temp[2], temp[0], temp[1]);
                }
                catch (Exception ex)
                {

                }
                eSupportHash = e.GivenEXEHash.ToUpper();
                suVersion = s.Version;
                suCatalogLink = s.PageURL;
                suExeLink = s.ExeURL;
                suCategory = s.Category;
                suReleaseDate = s.ReleaseDate;
                suGivenEXEHash = s.GivenEXEHash.ToUpper();
                suComputedEXEHash = s.ComputedEXEHash;
                suGivenXMLHash = s.GivenXMLHash.ToUpper();
                suComputedXMLHash = s.ComputedXMLHash;
                //location = ON_BOTH;
            }
            else if (e == null && s != null)
            {
                eSupportVersion = "";
                eSupportDSLink = "";
                eSupportExeLink = "";
                eSupportCategory = "";
                eSupportReleaseDate = "";
                eSupportHash = "";
                suVersion = s.Version;
                suCatalogLink = s.PageURL;
                suExeLink = s.ExeURL;
                name = s.Name;
                package = s.ID;
                suCategory = s.Category;
                suReleaseDate = s.ReleaseDate;
                suGivenEXEHash = s.GivenEXEHash.ToUpper();
                suComputedEXEHash = s.ComputedEXEHash;
                suGivenXMLHash = s.GivenXMLHash.ToUpper();
                suComputedXMLHash = s.ComputedXMLHash;
                // location = NOT_ON_ESUPPORT;
            }
            else
            {
                name = e.Name;
                package = e.ID;
                eSupportVersion = e.Version;
                eSupportDSLink = e.PageURL;
                eSupportExeLink = e.ExeURL;
                eSupportCategory = e.Category;
                try
                {
                    string[] temp = e.ReleaseDate.Split(' ')[0].Split('/');
                    eSupportReleaseDate = String.Format("{0}-{1}-{2}", temp[2], temp[0], temp[1]);
                }
                catch (Exception ex)
                {

                }

                eSupportHash = e.GivenEXEHash.ToUpper();
                suVersion = "";
                suCatalogLink = "";
                suExeLink = "";
                suCategory = "";
                suReleaseDate = "";
                suGivenEXEHash = "";
                suComputedEXEHash = "";
                suGivenXMLHash = "";
                suComputedXMLHash = "";
                // location = NOT_ON_SU;
            }
            model = m;




            if (!string.IsNullOrWhiteSpace(eSupportVersion) && !string.IsNullOrWhiteSpace(suVersion))
            {
                //make four parts
                Version esVer = new Version();
                Version suVer = new Version();

                bool isValidE = Version.TryParse(eSupportVersion, out esVer);
                bool isValidS = Version.TryParse(suVersion, out suVer);
                if (isValidE && isValidS)
                {

                    if (esVer.Build == -1)
                    {
                        esVer = new Version(esVer.ToString() + ".0.0");
                    }
                    if (esVer.Revision == -1)
                    {
                        esVer = new Version(esVer.ToString() + ".0");
                    }
                    if (suVer.Build == -1)
                    {
                        suVer = new Version(suVer.ToString() + ".0.0");
                    }
                    if (suVer.Revision == -1)
                    {
                        suVer = new Version(suVer.ToString() + ".0");
                    }
                    if (!esVer.Equals(suVer))
                        Issues += VERSION_MISMATCH + " ";
                }
                else if (eSupportVersion != suVersion)
                    Issues += VERSION_MISMATCH + " ";

            }
            if (eSupportExeLink != suExeLink && !string.IsNullOrWhiteSpace(eSupportExeLink) && !string.IsNullOrWhiteSpace(suExeLink))
                Issues += EXE_MISMATCH + " ";
            if (eSupportHash != suGivenEXEHash && !string.IsNullOrWhiteSpace(eSupportHash) && !string.IsNullOrWhiteSpace(suGivenEXEHash))
            {
                if (eSupportHash.Length == suGivenEXEHash.Length)
                {
                    Issues += HASH_CONTENT_MISMATCH + " ";
                }
                else
                {
                    Issues += HASH_TYPE_MISMATCH + " ";
                }
            }

            if (suComputedEXEHash != suGivenEXEHash && !string.IsNullOrWhiteSpace(suComputedEXEHash) && !string.IsNullOrWhiteSpace(suGivenEXEHash))
                Issues += CRC_EXE_MISMATCH + " ";
            if (suComputedXMLHash != suGivenXMLHash && !string.IsNullOrWhiteSpace(suComputedXMLHash) && !string.IsNullOrWhiteSpace(suGivenXMLHash))
                Issues += CRC_XML_MISMATCH + " ";
            if (string.IsNullOrEmpty(suVersion))
                Issues += NOT_ON_SU + " ";
            if (string.IsNullOrEmpty(eSupportVersion))
                Issues += NOT_ON_ESUPPORT + " ";

        }

        public string ToDelimitedString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}",
                this.Issues, this.package, this.name, this.eSupportVersion, this.eSupportExeLink, this.eSupportDSLink, this.eSupportReleaseDate,
                this.eSupportHash, this.eSupportCategory, this.suVersion, this.suExeLink, this.suCatalogLink, this.suReleaseDate, this.suGivenXMLHash,
                this.suComputedXMLHash, this.suGivenEXEHash, this.suComputedEXEHash, this.suCategory, this.lucVersion));
            return result.ToString();
        }
    }
}
