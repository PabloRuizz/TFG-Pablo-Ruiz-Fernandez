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
        private static readonly string CarpetaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DatosArchivos");

        public static void Guardar<T>(List<T> datos, string nombreArchivo)
        {
            if (!Directory.Exists(CarpetaBase))
                Directory.CreateDirectory(CarpetaBase);

            string rutaCompleta = Path.Combine(CarpetaBase, nombreArchivo);

            using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(fs, datos);
            }
        }

        public static List<T> Cargar<T>(string nombreArchivo)
        {
            string rutaCompleta = Path.Combine(CarpetaBase, nombreArchivo);

            if (!File.Exists(rutaCompleta))
                return new List<T>();

            using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                return (List<T>)serializer.Deserialize(fs);
            }
        }
    }
}