using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class SerializeObject
    {
        public int ID
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        [XmlIgnoreAttribute]
        public string notSerialize;
    }

    public class SerizlizedToXMLFilesApp
    {
        [STAThread]
        static void Main()
        {
            Serialize();
            Deserialize();
        }

        static void Serialize()
        {
            SerializeObject serializeObject = new SerializeObject();
            serializeObject.ID = 1;
            serializeObject.UserName = "Maosn";
            serializeObject.Password = "This ia a handsome guy！";
            serializeObject.notSerialize = "中建八局文旅公司";

            FileStream fs = new FileStream("DataFile.xml", FileMode.Create);
            XmlSerializer formatter = new XmlSerializer(typeof(SerializeObject));
            try
            {
                formatter.Serialize(fs, serializeObject);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


        static void Deserialize()
        {
            SerializeObject serializeObject = null;

            FileStream fs = new FileStream("DataFile.xml", FileMode.Open);
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(SerializeObject));
                serializeObject = (SerializeObject)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            Console.WriteLine("反序列Serializable的结果：ID->" + serializeObject.ID + ", UserName->" + serializeObject.UserName + ", Password->" + serializeObject.Password);
            Console.WriteLine("反序列化NonSerialized结果：" + serializeObject.notSerialize);
        }
    }
}