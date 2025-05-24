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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private ControladorOperario controlador = new ControladorOperario();

        private void btnNuevoOperario_Click(object sender, EventArgs e)
        {
            FrmCrearOperario form = new FrmCrearOperario(controlador);
            form.ShowDialog();
        }

    }
}
