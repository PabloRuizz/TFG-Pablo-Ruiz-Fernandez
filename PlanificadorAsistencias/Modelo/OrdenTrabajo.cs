using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class OrdenTrabajo
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int Prioridad { get; set; }
        public bool EnGarantia { get; set; }
        public string Ubicacion { get; set; }
        public Operario OperarioAsignado { get; set; }
    }
}