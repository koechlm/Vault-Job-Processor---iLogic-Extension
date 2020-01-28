/*=====================================================================
  
  This file is part of the Autodesk Vault API Code Samples.

  Copyright (C) Autodesk Inc.  All rights reserved.

THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
PARTICULAR PURPOSE.
=====================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Autodesk.VltInvSrv.iLogicSampleJob
{

    [XmlRoot("settings")]
    public class Settings
    {
        [XmlElement("iLogicAddinDLLs")]
        public string iLogicAddinDLLs;

        [XmlElement("iLogicLogLevel")]
        public string iLogicLogLevel;

        [XmlElement("iLogicLogDir")]
        public string iLogicLogDir;

        [XmlElement("VaultRuleFullFileName")]
        public string VaultRuleFullFileName;

        [XmlElement("ExternalRuleName")]
        public string ExternalRuleName;

        [XmlElement("ExternalRuleDirectory")]
        public string ExternalRuleDirectory;

        [XmlElement("PropagateProps")]
        public string PropagateProps;

        [XmlElement("InternalRulesOption")]
        public string InternalRulesOption;


        private Settings()
        {

        }

        public void Save()
        {
            try
            {
                string codeFolder = Util.GetAssemblyPath();
                string xmlPath = Path.Combine(codeFolder, "Settings.xml");

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(xmlPath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    serializer.Serialize(writer, this);
                }
            }
            catch
            { }
        }

        public static Settings Load()
        {
            Settings retVal = new Settings();


            string codeFolder = Util.GetAssemblyPath();
            string xmlPath = Path.Combine(codeFolder, "Settings.xml");

            using (System.IO.StreamReader reader = new System.IO.StreamReader(xmlPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                retVal = (Settings)serializer.Deserialize(reader);
            }


            return retVal;
        }
    }

}
