using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Modelo;
using System.IO;


namespace Presentacion
{
    public partial class FrmGenerarPlanificacion : Form
    {
        private ControladorOperario controladorOperario;
        private ControladorOrdenes controladorOrdenes;
        private Planificador planificador;

        public FrmGenerarPlanificacion(ControladorOperario cOp, ControladorOrdenes cOr)
        {
            InitializeComponent();
            controladorOperario = cOp;
            controladorOrdenes = cOr;
            planificador = new Planificador();
        }

        private void FrmGenerarPlanificacion_Load(object sender, EventArgs e)
        {
            List<Asignacion> resultado = planificador.GenerarPlanificacion(
                controladorOrdenes.ObtenerOrdenes(),
                controladorOperario.ObtenerOperarios()
            );

            foreach (var asignacion in resultado)
            {
                string resumen = $"Operario: {asignacion.Operario.Nombre}\n" +
                                 $"Total órdenes: {asignacion.OrdenesAsignadas.Count}\n" +
                                 $"Distancia total: {asignacion.DistanciaTotal:F1} km\n";

                foreach (var orden in asignacion.OrdenesAsignadas)
                {
                    resumen += $"  - Orden #{orden.Id} en {orden.Ubicacion} ({orden.Cliente.TipoDispositivo})\n";
                }

                resumen += "----------------------------\n";

                txtResultado.AppendText(resumen);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            List<Asignacion> resultado = planificador.GenerarPlanificacion(
                controladorOrdenes.ObtenerOrdenes(),
                controladorOperario.ObtenerOperarios()
            );

            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "CSV (*.csv)|*.csv";
            dialogo.FileName = "planificacion.csv";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Operario,ID Orden,Cliente,Dispositivo,Ubicación,Fecha,Distancia Total");

                foreach (var asignacion in resultado)
                {
                    foreach (var orden in asignacion.OrdenesAsignadas)
                    {
                        sb.AppendLine($"{asignacion.Operario.Nombre}," +
                                      $"{orden.Id}," +
                                      $"{orden.Cliente.Nombre}," +
                                      $"{orden.Cliente.TipoDispositivo}," +
                                      $"{orden.Ubicacion}," +
                                      $"{orden.FechaAsignacion.ToShortDateString()}," +
                                      $"{asignacion.DistanciaTotal:F2}");
                    }
                }

                File.WriteAllText(dialogo.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Planificación exportada correctamente en formato CSV.");
            }
        }
    }
}

