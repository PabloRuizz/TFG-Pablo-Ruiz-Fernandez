using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public bool Disponible { get; set; }
    }
}
