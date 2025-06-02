using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaNegocio
{
    public class Planificador
    {
        public List<RutaOptima> GenerarPlanning(
            List<OrdenTrabajo> ordenes,
            List<Operario> operarios,
            List<AsignacionVehiculo> asignaciones,
            int maxOrdenesPorOperario = 4)
        {
            Console.WriteLine($"📌 Máximo de órdenes por operario: {maxOrdenesPorOperario}");

            var resultado = new List<RutaOptima>();
            var asignadas = new HashSet<OrdenTrabajo>();
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
                Console.WriteLine($"\n🔍 Evaluando orden #{orden.NumeroOrden} - {orden.TipoDispositivo} - {orden.CodigoPostal}");

                Zona zonaOrden = ZonaGeograficaHelper.DeterminarZona(orden.CodigoPostal);

                var compatibles = rutasPorOperario.Keys
                    .Where(op =>
                        op.ZonasAsignadas.Contains(zonaOrden) &&
                        op.Habilidades.Any(h => orden.TipoDispositivo.Trim().Equals(h.Trim(), StringComparison.OrdinalIgnoreCase)) &&
                        rutasPorOperario[op].OrdenesAsignadas.Count < maxOrdenesPorOperario)
                    .OrderBy(op => rutasPorOperario[op].OrdenesAsignadas.Count)
                    .ToList();

                if (compatibles.Any())
                {
                    var seleccionado = compatibles.First();
                    rutasPorOperario[seleccionado].OrdenesAsignadas.Add(orden);
                    asignadas.Add(orden);

                    Console.WriteLine($"✅ Asignada a: {seleccionado.Nombre}. Total asignadas ahora: {rutasPorOperario[seleccionado].OrdenesAsignadas.Count}");
                }
                else
                {
                    foreach (var op in rutasPorOperario.Keys)
                    {
                        bool zonaOk = op.ZonasAsignadas.Contains(zonaOrden);
                        bool habilidadOk = op.Habilidades.Any(h => orden.TipoDispositivo.Trim().Equals(h.Trim(), StringComparison.OrdinalIgnoreCase));
                        bool cupoOk = rutasPorOperario[op].OrdenesAsignadas.Count < maxOrdenesPorOperario;

                        if (!zonaOk || !habilidadOk || !cupoOk)
                        {
                            Console.WriteLine($"❌ {op.Nombre} descartado - Zona: {zonaOk}, Habilidad: {habilidadOk}, Cupo: {cupoOk}");
                        }
                    }

                    Console.WriteLine("⚠️ Ningún operario fue compatible para esta orden.");
                }
            }

            foreach (var ruta in rutasPorOperario.Values)
            {
                ruta.OrdenesAsignadas = OrdenarRutaOptima(ruta.OrdenesAsignadas);
            }

            foreach (var ruta in rutasPorOperario.Values)
            {
                ruta.OrdenesAsignadas = OrdenarRutaOptima(ruta.OrdenesAsignadas);
                ruta.DistanciaTotalKm = CalcularDistanciaTotal(ruta.OrdenesAsignadas);
            }


            return rutasPorOperario.Values
                .Where(r => r.OrdenesAsignadas.Any())
                .ToList();
        }

        private List<OrdenTrabajo> OrdenarRutaOptima(List<OrdenTrabajo> ordenes)
        {
            if (ordenes.Count <= 1)
                return ordenes;

            string codigoPostalInicio = "39004"; // PUNTO DE PARTIDA FIJO (ej: taller)
            var coordInicio = GestorCoordenadas.ObtenerPorCodigo(codigoPostalInicio);

            var resultado = new List<OrdenTrabajo>();
            var restantes = new List<OrdenTrabajo>(ordenes);

            // Elegir la primera orden más cercana al punto de inicio
            OrdenTrabajo actual = null;
            double minInicio = double.MaxValue;

            foreach (var orden in restantes)
            {
                var coordOrden = GestorCoordenadas.ObtenerPorCodigo(orden.CodigoPostal);
                if (coordOrden != null && coordInicio != null)
                {
                    double dist = CalculadorDistancias.CalcularDistancia(coordInicio, coordOrden);
                    if (dist < minInicio)
                    {
                        minInicio = dist;
                        actual = orden;
                    }
                }
            }

            if (actual == null)
                return ordenes; // no hay coordenadas válidas, devolvemos sin cambiar orden

            resultado.Add(actual);
            restantes.Remove(actual);

            // Continuar como vecino más cercano
            while (restantes.Count > 0)
            {
                var coordActual = GestorCoordenadas.ObtenerPorCodigo(actual.CodigoPostal);
                OrdenTrabajo siguiente = null;
                double minDist = double.MaxValue;

                foreach (var candidata in restantes)
                {
                    var coordCandidata = GestorCoordenadas.ObtenerPorCodigo(candidata.CodigoPostal);
                    if (coordActual != null && coordCandidata != null)
                    {
                        double dist = CalculadorDistancias.CalcularDistancia(coordActual, coordCandidata);
                        if (dist < minDist)
                        {
                            minDist = dist;
                            siguiente = candidata;
                        }
                    }
                }

                if (siguiente != null)
                {
                    resultado.Add(siguiente);
                    restantes.Remove(siguiente);
                    actual = siguiente;
                }
                else
                {
                    break;
                }
            }

            return resultado;
        }


        private double CalcularDistanciaTotal(List<OrdenTrabajo> ordenes)
        {
            double total = 0.0;

            for (int i = 0; i < ordenes.Count - 1; i++)
            {
                var origen = GestorCoordenadas.ObtenerPorCodigo(ordenes[i].CodigoPostal);
                var destino = GestorCoordenadas.ObtenerPorCodigo(ordenes[i + 1].CodigoPostal);

                if (origen != null && destino != null)
                {
                    total += CalculadorDistancias.CalcularDistancia(origen, destino);
                }
            }

            return Math.Round(total, 2); // Redondeado a 2 decimales
        }


    }
}
