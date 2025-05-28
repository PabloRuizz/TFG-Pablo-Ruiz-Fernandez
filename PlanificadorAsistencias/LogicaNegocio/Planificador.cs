using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using LogicaNegocio;


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
            var asignadas = new HashSet<OrdenTrabajo>();

            // Inicializar rutas por operario disponible
            var rutasPorOperario = new Dictionary<Operario, RutaOptima>();

            foreach (var op in operarios.Where(o => o.Disponible))
            {
                rutasPorOperario[op] = new RutaOptima
                {
                    Operario = op,
                    OrdenesAsignadas = new List<OrdenTrabajo>()
                };
            }

            var ordenesPendientes = ordenes.Where(o => o.Estado == "Pendiente").ToList();

            foreach (var orden in ordenesPendientes)
            {
                // Determinar la zona de la orden
                Zona zonaOrden = ZonaGeograficaHelper.DeterminarZona(orden.CodigoPostal);

                // Buscar operarios compatibles por zona y habilidad
                var compatibles = rutasPorOperario.Keys
                    .Where(op => op.ZonasAsignadas.Contains(zonaOrden)) // zona compatible
                    .Where(op => op.Habilidades.Any(h =>
                        orden.TipoDispositivo.Equals(h, StringComparison.OrdinalIgnoreCase))) // habilidad compatible
                    .Where(op => rutasPorOperario[op].OrdenesAsignadas.Count < maxOrdenesPorOperario) // no sobrecargado
                    .OrderBy(op => rutasPorOperario[op].OrdenesAsignadas.Count) // menos carga primero
                    .ToList();

                if (compatibles.Any())
                {
                    var seleccionado = compatibles.First();
                    rutasPorOperario[seleccionado].OrdenesAsignadas.Add(orden);
                    asignadas.Add(orden);
                }
            }

            return rutasPorOperario.Values
                .Where(r => r.OrdenesAsignadas.Any())
                .ToList();
        }

    }
}