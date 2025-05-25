using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ControladorVehiculo
    {
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public void CrearVehiculo(Vehiculo nuevo)
        {
            nuevo.Id = listaVehiculos.Count + 1;
            listaVehiculos.Add(nuevo);
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            return listaVehiculos;
        }
    }
}