using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class RutaOptima
{
    public Operario Operario { get; set; }
    public List<OrdenTrabajo> OrdenesAsignadas { get; set; } = new List<OrdenTrabajo>();
    public float DistanciaTotal { get; set; } // opcional
}
