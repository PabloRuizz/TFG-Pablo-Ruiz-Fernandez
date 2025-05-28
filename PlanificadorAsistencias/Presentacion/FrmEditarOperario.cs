using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using static Presentacion.CustomUI;



namespace Presentacion
{
    public partial class FrmEditarOperario : Form
    {
        private Operario operario;

        public FrmEditarOperario(Operario op)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            operario = op;
        }

        private void FrmEditarOperario_Load(object sender, EventArgs e)
        {
            txtNombre.Text = operario.Nombre;

            chkImagen.Checked = operario.Habilidades.Contains("Imagen");
            chkImpresion.Checked = operario.Habilidades.Contains("Impresión");
            chkInstalaciones.Checked = operario.Habilidades.Contains("Instalaciones");
            chkInformatica.Checked = operario.Habilidades.Contains("Informática");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            operario.Nombre = nombre;

            var habilidades = new List<string>();
            if (chkImagen.Checked) habilidades.Add("Imagen");
            if (chkImpresion.Checked) habilidades.Add("Impresión");
            if (chkInstalaciones.Checked) habilidades.Add("Instalaciones");
            if (chkInformatica.Checked) habilidades.Add("Informática");

            operario.Habilidades = habilidades;

            MessageBox.Show("Cambios guardados.");
            this.Close();
        }
    }
}