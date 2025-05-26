using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Datos
{
    public static class GestorDatos
    {
        public static void Guardar<T>(List<T> datos, string rutaArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter writer = new StreamWriter(rutaArchivo))
            {
                serializer.Serialize(writer, datos);
            }
        }

        public static List<T> Cargar<T>(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
                return new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextReader reader = new StreamReader(rutaArchivo))
            {
                return (List<T>)serializer.Deserialize(reader);
            }
        }
    }
}