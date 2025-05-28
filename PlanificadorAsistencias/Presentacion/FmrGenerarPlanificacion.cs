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

            var rutas = planificador.GenerarPlanning(ordenes, operarios, asignaciones);

            lstResultados.Items.Clear();

            foreach (var ruta in rutas)
            {
                lstResultados.Items.Add($"👷 Operario: {ruta.Operario.Nombre}");
                foreach (var orden in ruta.OrdenesAsignadas)
                {
                    lstResultados.Items.Add($"   → #{orden.NumeroOrden} | {orden.TipoDispositivo} | {orden.CodigoPostal}");
                }
                lstResultados.Items.Add(""); // espacio entre bloques
            }

            if (!rutas.Any())
                MessageBox.Show("No se ha podido generar planificación con los datos actuales.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
