using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace LogicaNegocio
{
    public static class CalculadorDistancias
    {
        public static double CalcularDistancia(CoordenadaPostal c1, CoordenadaPostal c2)
        {
            double R = 6371.0; // Radio de la Tierra en km
            double dLat = GradosARadianes(c2.Latitud - c1.Latitud);
            double dLon = GradosARadianes(c2.Longitud - c1.Longitud);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(GradosARadianes(c1.Latitud)) * Math.Cos(GradosARadianes(c2.Latitud)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private static double GradosARadianes(double grados)
        {
            return grados * Math.PI / 180.0;
        }
    }
}