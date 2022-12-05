using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Globalization;

namespace JenkinsInterfaceTest
{
    [Serializable()]
    public class AppInitData
    {
        private string CommandList;
        private string UserName;
        private string Token;
        private string DefaultSitePath;


        public AppInitData() { }
        public AppInitData(string commandlist, string username, string token, string defaultsitepath)
        {
            CommandList = commandlist;
            UserName = username;
            Token = token;
            DefaultSitePath = defaultsitepath;
        }

        public string commandlist { get { return CommandList; } set { CommandList = value; } }
        public string username { get { return UserName; } set { UserName= value; } }
        public string token { get { return Token; } set { Token= value; } }
        public string defaultsitepath { get { return DefaultSitePath; } set { DefaultSitePath= value; } }


        public bool WriteToDisk(AppInitData data, string fileName)
        {
            // ADD CODE TO SERIALIZE THE CLASS INTO A FILE
            var serializer = new XmlSerializer(typeof(AppInitData));
            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
            return true;
        }


        public  AppInitData ReadFromDisk(string FilePath)
        {
            // ADD CODE TO SERIALIZE THE CLASS INTO A FILE
            AppInitData results = new AppInitData();
            var serializer = new XmlSerializer(typeof(AppInitData));
            using (var stream = new StreamReader(FilePath))
            {
                 results = (AppInitData)serializer.Deserialize(stream);
            }
            // process reesults to class?
            return results;
        }

    }
}
