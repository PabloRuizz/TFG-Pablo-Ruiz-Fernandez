using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace LogicaNegocio
{
    public static class GestorCoordenadas
    {
        private static List<CoordenadaPostal> coordenadas = new List<CoordenadaPostal>();

        public static void CargarDesdeCSV(string rutaArchivo)
        {
            coordenadas.Clear();

            var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // omitir cabecera
            foreach (var linea in lineas)
            {
                var partes = linea.Split(new[] { ';', ',' }); // por si usas ; o , como separador

                if (partes.Length >= 3 &&
                    double.TryParse(partes[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double lat) &&
                    double.TryParse(partes[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double lon))
                {
                    coordenadas.Add(new CoordenadaPostal
                    {
                        CodigoPostal = partes[0].Trim(),
                        Latitud = lat,
                        Longitud = lon
                    });
                }
            }
        }

        public static CoordenadaPostal ObtenerPorCodigo(string codigoPostal)
        {
            return coordenadas.FirstOrDefault(c => c.CodigoPostal == codigoPostal);
        }
    }
}
