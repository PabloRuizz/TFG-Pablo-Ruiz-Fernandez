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
using static Presentacion.CustomUI;



namespace Presentacion
{
    public partial class FrmCrearVehiculo : Form
    {
        private ControladorVehiculo controlador;

        public FrmCrearVehiculo(ControladorVehiculo controlador)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            this.controlador = controlador;
        }

        private void FrmCrearVehiculo_Load(object sender, EventArgs e)
        {
            // Llenar combo con tipos de vehículos
            cmbTipo.Items.Add("Coche");
            cmbTipo.Items.Add("Furgoneta pequeña");
            cmbTipo.Items.Add("Furgoneta grande");
            cmbTipo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();
            string tipo = cmbTipo.SelectedItem.ToString();
            int capacidad = (int)nudCapacidad.Value;

            if (string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return;
            }

            Vehiculo nuevo = new Vehiculo
            {
                Matricula = matricula,
                Tipo = tipo,
                Capacidad = capacidad,
                Disponible = true
            };

            controlador.CrearVehiculo(nuevo);

            MessageBox.Show("Vehículo creado correctamente.");
            this.Close();
        }
    }
}