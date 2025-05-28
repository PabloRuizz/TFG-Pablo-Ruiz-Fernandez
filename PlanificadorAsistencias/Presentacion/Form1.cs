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

namespace Presentacion
{
    public partial class FrmEditarOrden : Form
    {
        private OrdenTrabajo orden;

        public FrmEditarOrden(OrdenTrabajo orden)
        {
            InitializeComponent();
            this.orden = orden;
        }

        private void FrmEditarOrden_Load(object sender, EventArgs e)
        {
            txtDireccion.Text = orden.Direccion;
            txtCodigoPostal.Text = orden.CodigoPostal;
            cmbDispositivo.Items.AddRange(new string[] { "Imagen", "Informática", "Impresión", "Instalación" });
            cmbDispositivo.SelectedItem = orden.TipoDispositivo;
            txtEstado.Text = orden.Estado;
            txtObservaciones.Text = orden.Observaciones;
            dtpFecha.Value = orden.FechaAsignacion;
            chkGarantia.Checked = orden.EnGarantia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            orden.Direccion = txtDireccion.Text.Trim();
            orden.CodigoPostal = txtCodigoPostal.Text.Trim();
            orden.TipoDispositivo = cmbDispositivo.SelectedItem?.ToString() ?? "";
            orden.Estado = txtEstado.Text.Trim();
            orden.Observaciones = txtObservaciones.Text.Trim();
            orden.FechaAsignacion = dtpFecha.Value;
            orden.EnGarantia = chkGarantia.Checked;

            MessageBox.Show("Orden actualizada.");
            this.Close();
        }
    }
}
