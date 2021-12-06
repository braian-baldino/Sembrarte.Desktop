using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Infrastructure.Serializer
{
    public static class Xml<T> where T : class, new()
    {
        /// <summary>
        /// Saves the given data in a binary XML file in My Documents.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool SaveBinaryXml(string fileName, T data)
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(fileName) && !ReferenceEquals(data, null))
            {
                try
                {
                    string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string path = Path.Combine(myDocs, "Sembrarte App");
                    Directory.CreateDirectory(path);
                    FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.Create);
                    BinaryFormatter ser = new BinaryFormatter();

                    ser.Serialize(fs, data);
                    fs.Close();
                    retorno = true;
                }
                catch (Exception ex)
                {

                    throw new Exception("Binary Serialization Error.", ex);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Reads data from a binary file in Sembrarte App in My Documents.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool ReadBinary(string fileName, out T data)
        {
            data = default(T);
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    foreach (string _dir in Directory.GetDirectories(myDocs))
                    {
                        if (_dir == (myDocs + "\\" + "Sembrarte App"))
                        {
                            foreach (string item in Directory.GetFiles(_dir))
                            {
                                if (item == (_dir + "\\" + fileName))
                                {
                                    FileStream fStream = new FileStream(item, FileMode.Open);
                                    BinaryFormatter serializer = new BinaryFormatter();
                                    data = (T)serializer.Deserialize(fStream);
                                    fStream.Close();
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error en serializacion", e);
                }
            }
            return false;
        } 
    }
}
