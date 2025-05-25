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

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private ControladorOperario controladorOperario;
        private ControladorVehiculo controladorVehiculo;
        private ControladorOrdenes controladorOrdenes = new ControladorOrdenes();

        public FrmPrincipal()
        {
            InitializeComponent();

            controladorOperario = new ControladorOperario();
            controladorVehiculo = new ControladorVehiculo();
        }

        private ControladorOperario controlador = new ControladorOperario();

        private void btnNuevoOperario_Click(object sender, EventArgs e)
        {
            FrmCrearOperario form = new FrmCrearOperario(controlador);
            form.ShowDialog();
        }


        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            FrmCrearVehiculo form = new FrmCrearVehiculo(controladorVehiculo);
            form.ShowDialog();
        }

        private void btnSeleccionarRecursos_Click(object sender, EventArgs e)
        {
            FrmSeleccionarRecursos frm = new FrmSeleccionarRecursos(controladorOperario, controladorVehiculo);
            frm.ShowDialog();
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrdenes form = new FrmRegistrarOrdenes(controladorOrdenes);
            form.ShowDialog();
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            FrmVerOrdenes frm = new FrmVerOrdenes(controladorOrdenes);
            frm.ShowDialog();
        }

    }
}
