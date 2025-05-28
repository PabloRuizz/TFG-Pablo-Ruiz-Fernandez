using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace LogicaNegocio
{
    public class Planificador
    {
        public List<RutaOptima> GenerarPlanning(
     List<OrdenTrabajo> ordenes,
     List<Operario> operarios,
     List<AsignacionVehiculo> asignaciones,
     int maxOrdenesPorOperario = 3)
        {
            var resultado = new List<RutaOptima>();

            var ordenesPendientes = ordenes
                .Where(o => o.Estado == "Pendiente")
                .ToList();

            var operariosDisponibles = operarios
                .Where(o => o.Disponible)
                .ToList();

            // Agrupar órdenes por zona (primeros 3 dígitos del CP)
            var ordenesPorZona = ordenesPendientes
                .GroupBy(o => o.CodigoPostal.Substring(0, Math.Min(3, o.CodigoPostal.Length)))
                .ToList();

            foreach (var operario in operariosDisponibles)
            {
                var habilidades = operario.Habilidades.Select(h => h.ToLower()).ToList();
                var ruta = new RutaOptima { Operario = operario };

                // Buscar zonas con órdenes compatibles
                foreach (var zona in ordenesPorZona)
                {
                    foreach (var orden in zona)
                    {
                        bool habilidadCompatible = habilidades.Any(h => orden.TipoDispositivo.ToLower().Contains(h));

                        if (habilidadCompatible && !ruta.OrdenesAsignadas.Contains(orden))
                        {
                            ruta.OrdenesAsignadas.Add(orden);

                            if (ruta.OrdenesAsignadas.Count >= maxOrdenesPorOperario)
                                break;
                        }
                    }

                    if (ruta.OrdenesAsignadas.Count >= maxOrdenesPorOperario)
                        break;
                }

                if (ruta.OrdenesAsignadas.Any())
                {
                    resultado.Add(ruta);

                    // Eliminar las órdenes asignadas para que no se repitan
                    ordenesPendientes = ordenesPendientes
                        .Except(ruta.OrdenesAsignadas)
                        .ToList();
                }
            }

            return resultado;
        }
    }
}
