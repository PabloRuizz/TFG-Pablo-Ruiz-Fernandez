using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace LogicaNegocio
{
    public class ControladorOrdenes
    {
        private List<OrdenTrabajo> listaOrdenes;
        private string ruta = "ordenes.xml";

        public ControladorOrdenes()
        {
            listaOrdenes = GestorDatos.Cargar<OrdenTrabajo>(ruta);
        }

        public void CrearOrden(OrdenTrabajo nueva)
        {
            nueva.Id = listaOrdenes.Count + 1;
            listaOrdenes.Add(nueva);
            GestorDatos.Guardar(listaOrdenes, ruta);
        }

        public List<OrdenTrabajo> ObtenerOrdenes()
        {
            return listaOrdenes;
        }

        public void EliminarOrden(int id)
        {
            var orden = listaOrdenes.Find(o => o.Id == id);
            if (orden != null)
            {
                listaOrdenes.Remove(orden);
                GestorDatos.Guardar(listaOrdenes, ruta);
            }
        }

        public OrdenTrabajo ObtenerOrdenPorId(int id)
        {
            return listaOrdenes.Find(o => o.Id == id);
        }
    }
}