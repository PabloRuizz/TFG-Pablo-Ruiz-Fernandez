using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace LogicaNegocio
{
    public class ControladorVehiculo
    {
        private List<Vehiculo> listaVehiculos;
        private string ruta = "vehiculos.xml";

        public ControladorVehiculo()
        {
            listaVehiculos = GestorDatos.Cargar<Vehiculo>(ruta);
        }

        public void CrearVehiculo(Vehiculo nuevo)
        {
            nuevo.Id = listaVehiculos.Count + 1;
            listaVehiculos.Add(nuevo);
            GestorDatos.Guardar(listaVehiculos, ruta);
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            return listaVehiculos;
        }

        public void EliminarVehiculo(int id)
        {
            var v = listaVehiculos.FirstOrDefault(x => x.Id == id);
            if (v != null)
            {
                listaVehiculos.Remove(v);
                GestorDatos.Guardar(listaVehiculos, ruta);
            }
        }

        public Vehiculo ObtenerVehiculoPorId(int id)
        {
            return listaVehiculos.FirstOrDefault(v => v.Id == id);
        }

        public void GuardarCambios()
        {
            GestorDatos.Guardar(listaVehiculos, ruta);
        }
    }
}