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
    public partial class FrmEditarVehiculo : Form
    {
        private Vehiculo vehiculo;

        public FrmEditarVehiculo(Vehiculo v)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            vehiculo = v;
        }

        private void FrmEditarVehiculo_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = vehiculo.Matricula;
            cmbTipo.Items.AddRange(new string[] { "Coche", "Furgoneta pequeña", "Furgoneta grande" });
            cmbTipo.SelectedItem = vehiculo.Tipo;
            nudCapacidad.Value = vehiculo.Capacidad;
            chkDisponible.Checked = vehiculo.Disponible;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();
            string tipo = cmbTipo.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Debes completar todos los campos.");
                return;
            }

            vehiculo.Matricula = matricula;
            vehiculo.Tipo = tipo;
            vehiculo.Capacidad = (int)nudCapacidad.Value;
            vehiculo.Disponible = chkDisponible.Checked;

            MessageBox.Show("Vehículo actualizado correctamente.");
            this.Close();
        }
    }
}