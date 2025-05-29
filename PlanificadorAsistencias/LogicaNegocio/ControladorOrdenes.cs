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
            if (NumeroOrdenExiste(nueva.NumeroOrden))
                throw new System.InvalidOperationException("El número de orden ya existe.");

            // ✔️ Evita duplicados aunque haya huecos por eliminaciones
            nueva.Id = listaOrdenes.Any()
                ? listaOrdenes.Max(o => o.Id) + 1
                : 1;

            listaOrdenes.Add(nueva);
            Guardar();
        }


        public void Guardar()
        {
            GestorDatos.Guardar(listaOrdenes, ruta);
        }

        public List<OrdenTrabajo> ObtenerOrdenes()
        {
            return listaOrdenes;
        }

        public OrdenTrabajo ObtenerOrdenPorId(int id)
        {
            return listaOrdenes.FirstOrDefault(o => o.Id == id);
        }

        public bool NumeroOrdenExiste(string numeroOrden)
        {
            return listaOrdenes.Any(o => o.NumeroOrden == numeroOrden);
        }

        public void EliminarOrden(int id)
        {
            var orden = listaOrdenes.FirstOrDefault(o => o.Id == id);
            if (orden != null)
            {
                listaOrdenes.Remove(orden);
                Guardar();
            }
        }

        public void EditarOrden(OrdenTrabajo actualizada)
        {
            var index = listaOrdenes.FindIndex(o => o.Id == actualizada.Id);
            if (index != -1)
            {
                listaOrdenes[index] = actualizada;
                Guardar();
            }
        }
    }
}
