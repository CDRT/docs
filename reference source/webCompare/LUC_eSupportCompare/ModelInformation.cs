using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUC_eSupportCompare
{
    public class ModelInformation : IComparable
    {
        string friendlyName, modelType, parentURL;
        List<string> bios;

        /**
         * Constructor
         * @param fName The friendly name of the machine
         * @param model The current type of the machine
         * @param url The parent url for that machine
         */
        public ModelInformation(string fName, string model, string url)
        {
            friendlyName = fName;
            modelType = model;
            parentURL = url;
            bios = new List<string>();
        }//end ModelInformation

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            ModelInformation otherModel = obj as ModelInformation;
            if (otherModel != null)
                return this.friendlyName.CompareTo(otherModel.friendlyName);
            else
                throw new ArgumentException("Object is not ModelInformation");
        }

        public override int GetHashCode()
        {
            return this.friendlyName.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var item = obj as ModelInformation;

            if (item == null)
            {
                return false;
            }

            return this.getName().Equals(item.getName());
        }

        /**
         * Set the bios version for a model
         * @param bios The shortened name of the bios
         */
        public void addBiosVerison(string biosVersion)
        {
            if (bios.Contains(biosVersion) || String.IsNullOrEmpty(biosVersion))
                return;
            bios.Add(biosVersion);
        }//end setBiosVersion

        /**
         * Set the bios version for a model
         * @param bios The shortened name of the bios
         */
        public void setName(string name)
        {
            friendlyName = name;
        }//end setBiosVersion

        /**
         * Returns the inner section of the url to find the BIOS version
         * @returns A portion of the url
         */
        public string getParentID()
        {
            return parentURL;
        }//end getParentID

        /**
         * Returns the inner section of the url to find the BIOS version
         * @returns A portion of the url
         */
        public string getMTM()
        {
            return modelType;
        }//end getParentID

        /** 
         * Returns the inner section of the url to find the BIOS version
         * @returns A portion of the url
         */
        public string getName()
        {
            return friendlyName;
        }//end getParentID

        /**
         * Prints out the ModelInformation in the SCUP format
         * @returns a string with the name, type, and version
         */
        public string printSCUP()
        {
            string results = "";
            foreach (string biosVersion in bios)
            {
                if (!results.Equals(""))
                    results += (",");
                results += (friendlyName + " = " + modelType + " = " + biosVersion);

            }
            return results.Replace(",", Environment.NewLine);
        }//end printSCUP

        public string printMTM()
        {
            return friendlyName + " = " + modelType;
        }
    } //end ModelInformation
}
