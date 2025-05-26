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
using LogicaNegocio;

namespace Presentacion
{
    public partial class FrmSeleccionarRecursos : Form
    {
        private ControladorOperario controladorOperario;
        private ControladorVehiculo controladorVehiculo;

        private List<Operario> operarios;
        private List<Vehiculo> vehiculos;

        public FrmSeleccionarRecursos(ControladorOperario opCtrl, ControladorVehiculo vehCtrl)
        {
            InitializeComponent();
            controladorOperario = opCtrl;
            controladorVehiculo = vehCtrl;
        }

        private void FrmSeleccionarRecursos_Load(object sender, EventArgs e)
        {
            operarios = controladorOperario.ObtenerOperarios();
            vehiculos = controladorVehiculo.ObtenerVehiculos().Where(v => v.Disponible).ToList();

            // Mostrar operarios
            clbOperarios.Items.Clear();
            foreach (var op in operarios)
            {
                clbOperarios.Items.Add(op.Nombre, op.Disponible);
            }

            // Mostrar vehículos
            cmbVehiculos.Items.Clear();
            foreach (var v in vehiculos)
            {
                cmbVehiculos.Items.Add($"{v.Matricula} - {v.Tipo}");
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int selectedOperarioIndex = clbOperarios.SelectedIndex;
            int selectedVehiculoIndex = cmbVehiculos.SelectedIndex;

            if (selectedOperarioIndex == -1 || selectedVehiculoIndex == -1)
            {
                MessageBox.Show("Selecciona un operario y un vehículo.");
                return;
            }

            Operario operario = operarios[selectedOperarioIndex];
            Vehiculo vehiculo = vehiculos[selectedVehiculoIndex];

            operario.VehiculoAsignado = vehiculo;
            vehiculo.Disponible = false;

            MessageBox.Show($"Vehículo asignado a {operario.Nombre}.");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbOperarios.Items.Count; i++)
            {
                operarios[i].Disponible = clbOperarios.GetItemChecked(i);
            }

            MessageBox.Show("Recursos disponibles guardados.");
            this.Close();
        }
    }
}