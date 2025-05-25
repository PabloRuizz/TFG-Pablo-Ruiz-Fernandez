using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ControladorOrdenes
    {
        private List<OrdenTrabajo> listaOrdenes = new List<OrdenTrabajo>();

        public void CrearOrden(OrdenTrabajo nueva)
        {
            nueva.Id = listaOrdenes.Count + 1;
            listaOrdenes.Add(nueva);
        }

        public List<OrdenTrabajo> ObtenerOrdenes()
        {
            return listaOrdenes;
        }
    }
}