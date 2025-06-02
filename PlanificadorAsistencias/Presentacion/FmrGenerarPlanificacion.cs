using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;
using static Presentacion.CustomUI;
using System.IO;
using System.Text;

namespace Presentacion
{
    public partial class FrmGenerarPlanificador : Form
    {
        private ControladorOrdenes controladorOrdenes;
        private ControladorOperario controladorOperario;
        private ControladorAsignaciones controladorAsignaciones;
        private Planificador planificador;
        private List<RutaOptima> rutasPlanificadas;

        public FrmGenerarPlanificador(
            ControladorOrdenes ordenes,
            ControladorOperario operarios,
            ControladorAsignaciones asignaciones)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            controladorOrdenes = ordenes;
            controladorOperario = operarios;
            controladorAsignaciones = asignaciones;
            planificador = new Planificador();
        }

        private void FrmGenerarPlanificador_Load(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "CodigosPostalesCantabria.csv");
            GestorCoordenadas.CargarDesdeCSV(ruta);


        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var ordenes = controladorOrdenes.ObtenerOrdenes();
            var operarios = controladorOperario.ObtenerOperarios();
            var asignaciones = controladorAsignaciones.ObtenerTodas();

            int maxPorOperario = 4; // puedes cambiarlo o hacerlo configurable
            rutasPlanificadas = planificador.GenerarPlanning(ordenes, operarios, asignaciones, maxPorOperario);

            //var rutas = planificador.GenerarPlanning(ordenes, operarios, asignaciones, maxPorOperario);

            lstResultados.Items.Clear();

            foreach (var ruta in rutasPlanificadas)
            {
                lstResultados.Items.Add($"👷 Operario: {ruta.Operario.Nombre} ({ruta.OrdenesAsignadas.Count} órdenes, {ruta.DistanciaTotalKm} km)");
                foreach (var orden in ruta.OrdenesAsignadas)
                {
                    lstResultados.Items.Add($"   → #{orden.NumeroOrden} | {orden.TipoDispositivo} | {orden.CodigoPostal}");
                }
                lstResultados.Items.Add(""); // espacio entre operarios
            }

            if (!rutasPlanificadas.Any())
            {
                MessageBox.Show("No se ha podido generar planificación con los datos actuales.");
            }
            else
            {
                MessageBox.Show("Planning generado correctamente.");
            }



            var asignadas = rutasPlanificadas.SelectMany(r => r.OrdenesAsignadas).ToList();
            var noAsignadas = ordenes.Where(o => o.Estado == "Pendiente" && !asignadas.Contains(o)).ToList();

            lstNoAsignadas.Items.Clear();
            foreach (var orden in noAsignadas)
            {
                lstNoAsignadas.Items.Add($"❌ #{orden.NumeroOrden} - {orden.TipoDispositivo} - {orden.CodigoPostal}");
            }

        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            if (rutasPlanificadas == null || !rutasPlanificadas.Any())
            {
                MessageBox.Show("No hay planning generado para exportar.");
                return;
            }

            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "planning.csv");

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    // Cabecera
                    sw.WriteLine("Operario;Orden;TipoDispositivo;CódigoPostal;Dirección;Cliente");

                    foreach (var ruta in rutasPlanificadas)
                    {
                        foreach (var orden in ruta.OrdenesAsignadas)
                        {
                            sw.WriteLine($"{ruta.Operario.Nombre};" +
                                         $"{orden.NumeroOrden};" +
                                         $"{orden.TipoDispositivo};" +
                                         $"{orden.CodigoPostal};" +
                                         $"{orden.Direccion};" +
                                         $"{orden.Cliente.Nombre}");
                        }
                    }
                }

                MessageBox.Show($"Archivo exportado correctamente en:\n{rutaArchivo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el archivo CSV:\n" + ex.Message);
            }
        }

        private void btnVerCoordenadas_Click(object sender, EventArgs e)
        {
            if (lstNoAsignadas.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una orden de la lista 'No asignadas'.");
                return;
            }

            // Extraer el número de orden desde el texto mostrado (ej. "❌ #123 - Imagen - 39002")
            string texto = lstNoAsignadas.SelectedItem.ToString();
            string[] partes = texto.Split('#');
            if (partes.Length < 2)
            {
                MessageBox.Show("No se pudo extraer el número de orden.");
                return;
            }

            string numeroStr = partes[1].Split(' ')[0];
            if (!int.TryParse(numeroStr, out int numeroOrden))
            {
                MessageBox.Show("Número de orden no válido.");
                return;
            }

            // Buscar la orden
            var orden = controladorOrdenes.ObtenerOrdenes()
                .FirstOrDefault(o => o.NumeroOrden == numeroOrden.ToString());


            if (orden == null)
            {
                MessageBox.Show("No se encontró la orden.");
                return;
            }

            // Obtener coordenadas
            var coordenada = GestorCoordenadas.ObtenerPorCodigo(orden.CodigoPostal);
            if (coordenada != null)
            {
                MessageBox.Show($"Coordenadas de {orden.CodigoPostal}:\n" +
                                $"Latitud: {coordenada.Latitud}\n" +
                                $"Longitud: {coordenada.Longitud}");
            }
            else
            {
                MessageBox.Show("No se encontraron coordenadas para ese código postal.");
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

