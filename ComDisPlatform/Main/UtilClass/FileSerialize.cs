using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MainProcess.UtilClass
{
    class FileSerialize
    {
        public static void Serialize<T>(T o, string filePath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, o);
                stream.Flush();
                stream.Close();
            }
            catch (Exception)
            {
            }
        }
        public static T DeSerialize<T>(string filePath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream destream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                T o = (T)formatter.Deserialize(destream);
                destream.Flush();
                destream.Close();
                return o;
            }
            catch (Exception)
            {
            }
            return default(T);
        }
    }
}
