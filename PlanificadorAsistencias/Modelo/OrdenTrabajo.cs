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
        public string NumeroOrden { get; set; }
        public Cliente Cliente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public bool EnGarantia { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; } 
        public string TipoDispositivo { get; set; } 
        public string Observaciones { get; set; } 
        public Operario OperarioAsignado { get; set; }
    }
}