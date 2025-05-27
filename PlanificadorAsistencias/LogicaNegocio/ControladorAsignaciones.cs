using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Datos;

namespace LogicaNegocio
{
    public class ControladorAsignaciones
    {
        private List<AsignacionVehiculo> asignaciones;
        private string ruta = "asignaciones.xml";

        public ControladorAsignaciones()
        {
            asignaciones = GestorDatos.Cargar<AsignacionVehiculo>(ruta);
        }

        public void AsignarVehiculo(int operarioId, int vehiculoId)
        {
            var existente = asignaciones.FirstOrDefault(a => a.OperarioId == operarioId);
            if (existente != null)
                existente.VehiculoId = vehiculoId;
            else
                asignaciones.Add(new AsignacionVehiculo { OperarioId = operarioId, VehiculoId = vehiculoId });

            GestorDatos.Guardar(asignaciones, ruta);
        }

        public int? ObtenerVehiculoAsignado(int operarioId)
        {
            var asignacion = asignaciones.FirstOrDefault(a => a.OperarioId == operarioId);
            return asignacion?.VehiculoId;
        }

        public List<AsignacionVehiculo> ObtenerTodas()
        {
            return asignaciones;
        }

        public void Guardar()
        {
            GestorDatos.Guardar(asignaciones, ruta);
        }

        public void EliminarAsignacion(int operarioId)
        {
            var a = asignaciones.FirstOrDefault(x => x.OperarioId == operarioId);
            if (a != null)
            {
                asignaciones.Remove(a);
                Guardar();
            }
        }
    }
}