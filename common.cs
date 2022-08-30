using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SeleniumAutomation
{
    public class common
    {
        public static string EppBaseIstallPath = "C:/Users/Nikhill/Source/Repos/SeleniumAutomation";
        public static Dictionary<string, string> gettestdata(string testname, string testdatafile)
        {
            try
            {
                Dictionary<string, string> test_dict = new Dictionary<string, string>();
                string elepath = EppBaseIstallPath + "/" + testdatafile;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(elepath);
                XmlNodeList xmlnode = xmlDoc.GetElementsByTagName(testname);
                foreach (XmlNode node in xmlnode)
                {
                    foreach (XmlNode subnode in node)
                    {
                        test_dict.Add(subnode.Name, subnode.InnerText);
                    }
                }
                return test_dict;
            }
            catch (Exception ex)
            {
                throw new Exception("XMLFile" + ex.Message);
            }
        }
    }
}

