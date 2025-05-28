using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;
using static Presentacion.CustomUI;

namespace Presentacion
{
    public partial class FrmGenerarPlanificador : Form
    {
        private ControladorOrdenes controladorOrdenes;
        private ControladorOperario controladorOperario;
        private ControladorAsignaciones controladorAsignaciones;
        private Planificador planificador;

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
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var ordenes = controladorOrdenes.ObtenerOrdenes();
            var operarios = controladorOperario.ObtenerOperarios();
            var asignaciones = controladorAsignaciones.ObtenerTodas();

            int maxPorOperario = 3; // puedes cambiarlo o hacerlo configurable
            var rutas = planificador.GenerarPlanning(ordenes, operarios, asignaciones, maxPorOperario);

            lstResultados.Items.Clear();

            foreach (var ruta in rutas)
            {
                lstResultados.Items.Add($"👷 Operario: {ruta.Operario.Nombre} ({ruta.OrdenesAsignadas.Count} órdenes)");
                foreach (var orden in ruta.OrdenesAsignadas)
                {
                    lstResultados.Items.Add($"   → #{orden.NumeroOrden} | {orden.TipoDispositivo} | {orden.CodigoPostal}");
                }
                lstResultados.Items.Add(""); // espacio entre operarios
            }

            if (!rutas.Any())
            {
                MessageBox.Show("No se ha podido generar planificación con los datos actuales.");
            }
            else
            {
                MessageBox.Show("Planning generado correctamente.");
            }


            
            var asignadas = rutas.SelectMany(r => r.OrdenesAsignadas).ToList();
            var noAsignadas = ordenes.Where(o => o.Estado == "Pendiente" && !asignadas.Contains(o)).ToList();

            lstNoAsignadas.Items.Clear();
            foreach (var orden in noAsignadas)
            {
                lstNoAsignadas.Items.Add($"❌ #{orden.NumeroOrden} - {orden.TipoDispositivo} - {orden.CodigoPostal}");
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
