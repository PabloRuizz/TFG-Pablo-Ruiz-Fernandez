using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class AsignacionVehiculo
    {
        public int OperarioId { get; set; }
        public int VehiculoId { get; set; }
    }
}
