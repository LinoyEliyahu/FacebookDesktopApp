using System.Xml.Serialization;
using System.IO;

namespace LogicUnit
{
    public class AppSettings
    {
        public bool RememberUser { get; set; }

        public string AccessToken { get; set; }

        private AppSettings()
        {
            RememberUser = false;
            AccessToken = null;
        }

        public static AppSettings LoadDataFromFile()
        {
            AppSettings obj = new AppSettings();

            if (File.Exists(@"UserData.xml"))
            {
                using (Stream stream = new FileStream(@"UserData.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

        public void SaveDataToFile(string i_UserAccessToken)
        {
            if (!File.Exists(@"UserData.xml"))
            {
                using (Stream stream = new FileStream(@"UserData.xml", FileMode.Create))
                {
                    AccessToken = i_UserAccessToken;
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(@"UserData.xml", FileMode.Truncate))
                {
                    AccessToken = i_UserAccessToken;
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        public void DeleteFile()
        {
            if (File.Exists(@"UserData.xml"))
            {
                File.Delete(@"UserData.xml");
            }
        }
    }
}
