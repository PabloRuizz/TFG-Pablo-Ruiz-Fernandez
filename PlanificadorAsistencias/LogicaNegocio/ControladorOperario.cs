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
    }
}
