using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace LogicaNegocio
{
    public class ControladorOperario
    {
        private List<Operario> listaOperarios;
        private string ruta = "operarios.xml";

        public ControladorOperario()
        {
            listaOperarios = GestorDatos.Cargar<Operario>(ruta);
        }

        public void CrearOperario(Operario nuevo)
        {
            nuevo.Id = listaOperarios.Count + 1;
            listaOperarios.Add(nuevo);
            GestorDatos.Guardar(listaOperarios, ruta);
        }

        public List<Operario> ObtenerOperarios()
        {
            return listaOperarios;
        }

        public void EliminarOperario(int id)
        {
            var op = listaOperarios.FirstOrDefault(o => o.Id == id);
            if (op != null)
            {
                listaOperarios.Remove(op);
                GestorDatos.Guardar(listaOperarios, ruta);
            }
        }

        public Operario ObtenerOperarioPorId(int id)
        {
            return listaOperarios.FirstOrDefault(o => o.Id == id);
        }

        public void GuardarCambios()
        {
            GestorDatos.Guardar(listaOperarios, ruta);
        }

    }
}
