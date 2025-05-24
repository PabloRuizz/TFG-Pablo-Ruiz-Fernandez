using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ControladorOperario
    {
        private List<Operario> listaOperarios = new List<Operario>();

        public void CrearOperario(Operario nuevo)
        {
            nuevo.Id = listaOperarios.Count + 1;
            listaOperarios.Add(nuevo);
        }

        public List<Operario> ObtenerOperarios()
        {
            return listaOperarios;
        }
    }
}
