using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public static class ZonaGeograficaHelper
    {
        public static Zona DeterminarZona(string codigoPostal)
        {
            if (!int.TryParse(codigoPostal, out int cp)) return Zona.Desconocida;

            if ((cp >= 39000 && cp <= 39129) || (cp >= 39600 && cp <= 39619))
                return Zona.Centro;

            if ((cp >= 39620 && cp <= 39699) || (cp >= 39200 && cp <= 39299))
                return Zona.Sur;

            if ((cp >= 39130 && cp <= 39199) || (cp >= 39700 && cp <= 39799) || (cp >= 39800 && cp <= 39899))
                return Zona.Este;

            if ((cp >= 39300 && cp <= 39399) || (cp >= 39400 && cp <= 39499) || (cp >= 39500 && cp <= 39599))
                return Zona.Oeste;

            return Zona.Desconocida;
        }
    }
}