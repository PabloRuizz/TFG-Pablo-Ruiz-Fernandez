using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace LogicaNegocio
{
    public class Asignacion
    {
        public Operario Operario { get; set; }
        public List<OrdenTrabajo> OrdenesAsignadas { get; set; } = new List<OrdenTrabajo>();
        public double DistanciaTotal { get; set; }
    }

    public class Planificador
    {
        // Coordenadas reales por código postal (ejemplos de Cantabria)
        private Dictionary<string, (double lat, double lon)> coordenadas = new Dictionary<string, (double lat, double lon)>
        {
            { "39001", (43.4623, -3.8099) },
            { "39002", (43.4636, -3.8044) },
            { "39300", (43.3887, -4.0472) },
            { "39770", (43.3934, -3.4459) },
            { "39470", (43.2107, -4.1385) },
            // Añadir más según necesidad
        };

        private double CalcularDistanciaHaversine((double lat, double lon) origen, (double lat, double lon) destino)
        {
            double R = 6371; // Radio de la Tierra en km
            double dLat = Math.PI / 180 * (destino.lat - origen.lat);
            double dLon = Math.PI / 180 * (destino.lon - origen.lon);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(Math.PI / 180 * origen.lat) * Math.Cos(Math.PI / 180 * destino.lat) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c;
        }

        private double ObtenerDistanciaPorCP(string origenCP, string destinoCP)
        {
            if (origenCP == destinoCP) return 0.0;

            if (coordenadas.ContainsKey(origenCP) && coordenadas.ContainsKey(destinoCP))
            {
                var coord1 = coordenadas[origenCP];
                var coord2 = coordenadas[destinoCP];
                return CalcularDistanciaHaversine(coord1, coord2);
            }

            return 50.0; // Distancia por defecto si no hay coordenadas
        }

        public List<Asignacion> GenerarPlanificacion(List<OrdenTrabajo> ordenes, List<Operario> operarios)
        {
            var pendientes = ordenes.Where(o => o.Estado == "Pendiente").ToList();
            var disponibles = operarios.Where(op => op.Disponible && op.VehiculoAsignado != null).ToList();

            List<Asignacion> resultado = new List<Asignacion>();

            foreach (var operario in disponibles)
            {
                var asignacion = new Asignacion { Operario = operario };

                // Filtrar órdenes compatibles por habilidades
                var compatibles = pendientes.Where(o => operario.Habilidades.Any(h => o.Cliente.TipoDispositivo.ToLower().Contains(h.ToLower()))).ToList();

                string basePostal = "39001"; // punto de partida

                var ordenadas = compatibles.OrderBy(o => ObtenerDistanciaPorCP(basePostal, o.Ubicacion)).ToList();

                foreach (var orden in ordenadas)
                {
                    double distancia = ObtenerDistanciaPorCP(basePostal, orden.Ubicacion);
                    asignacion.OrdenesAsignadas.Add(orden);
                    asignacion.DistanciaTotal += distancia;

                    orden.Estado = "Asignada";
                    orden.OperarioAsignado = operario;
                    pendientes.Remove(orden);

                    basePostal = orden.Ubicacion;
                }

                if (asignacion.OrdenesAsignadas.Count > 0)
                    resultado.Add(asignacion);
            }

            return resultado;
        }
    }
}
