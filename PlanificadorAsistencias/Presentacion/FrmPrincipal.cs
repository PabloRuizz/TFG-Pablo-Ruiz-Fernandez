using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.CustomUI;


namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private ControladorOperario controladorOperario;
        private ControladorVehiculo controladorVehiculo;
        private ControladorOrdenes controladorOrdenes;
        private ControladorAsignaciones controladorAsignaciones;

        public FrmPrincipal()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

            controladorOperario = new ControladorOperario();
            controladorVehiculo = new ControladorVehiculo();
            controladorOrdenes = new ControladorOrdenes();
            controladorAsignaciones = new ControladorAsignaciones();
        }

        private void btnCrearOperario_Click(object sender, EventArgs e)
        {
            FrmCrearOperario form = new FrmCrearOperario(controladorOperario);
            form.ShowDialog();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            FrmCrearVehiculo form = new FrmCrearVehiculo(controladorVehiculo);
            form.ShowDialog();
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrdenes form = new FrmRegistrarOrdenes(controladorOrdenes);
            form.ShowDialog();
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            FrmSeleccionarRecursos form = new FrmSeleccionarRecursos(controladorOperario, controladorVehiculo);
            form.ShowDialog();
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            FrmVerOrdenes form = new FrmVerOrdenes(controladorOrdenes);
            form.ShowDialog();
        }

        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            FrmGenerarPlanificador frm = new FrmGenerarPlanificador(controladorOrdenes, controladorOperario, controladorAsignaciones);
            frm.ShowDialog();
        }

        private void btnGestionOperarios_Click(object sender, EventArgs e)
        {
            FrmGestionOperarios frm = new FrmGestionOperarios(controladorOperario);
            frm.ShowDialog();
        }

        private void btnGestionVehiculos_Click(object sender, EventArgs e)
        {
            FrmGestionVehiculos frm = new FrmGestionVehiculos(controladorVehiculo);
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
