using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace JenkinsInterfaceTest
{
    [Serializable()]
    internal class AppInitData
    {
        private string CommandList;


        public AppInitData() { }
        public AppInitData(string commandlist)
        {
            CommandList = commandlist;
        }

        public string commandlist
        {
            get { return CommandList; }
            set { CommandList = value; }
        }


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
            AppInitData result = new AppInitData();
            var serializer = new XmlSerializer(typeof(AppInitData));
            using (var stream = new StringReader(FilePath))
            using (var reader = XmlReader.Create(stream))
            {
                result = (AppInitData)serializer.Deserialize(reader);
            }
            return result;
        }

    }
}
