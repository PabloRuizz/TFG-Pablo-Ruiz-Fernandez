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
using static Presentacion.CustomUI;


namespace Presentacion
{
    public partial class FrmSeleccionarRecursos : Form
    {
        private ControladorOperario controladorOperario;
        private ControladorVehiculo controladorVehiculo;
        private ControladorAsignaciones controladorAsignaciones;


        private List<Operario> operarios;
        private List<Vehiculo> vehiculos;

        public FrmSeleccionarRecursos(ControladorOperario cop, ControladorVehiculo cv)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            controladorOperario = cop;
            controladorVehiculo = cv;
            controladorAsignaciones = new ControladorAsignaciones();
        }

        private void ActualizarLstAsignaciones()
        {
            lstAsignaciones.Items.Clear();

            var todas = controladorAsignaciones.ObtenerTodas();
            foreach (var asignacion in todas)
            {
                var op = operarios.FirstOrDefault(o => o.Id == asignacion.OperarioId);
                var veh = vehiculos.FirstOrDefault(v => v.Id == asignacion.VehiculoId);

                if (op != null && veh != null)
                    lstAsignaciones.Items.Add($"{veh.Matricula} ({veh.Tipo}) → {op.Nombre}");
            }
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

            lstAsignaciones.Items.Clear();

            lstAsignaciones.Items.Clear();

            foreach (var asignacion in controladorAsignaciones.ObtenerTodas())
            {
                var op = operarios.FirstOrDefault(o => o.Id == asignacion.OperarioId);
                var veh = vehiculos.FirstOrDefault(v => v.Id == asignacion.VehiculoId);

                if (op != null && veh != null)
                {
                    lstAsignaciones.Items.Add($"{veh.Matricula} ({veh.Tipo}) → {op.Nombre}");
                }
            }

            ActualizarLstAsignaciones();
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

            // NUEVO: guardar la asignación en XML
            controladorAsignaciones.AsignarVehiculo(operario.Id, vehiculo.Id);

            MessageBox.Show($"Vehículo asignado a {operario.Nombre}.");

            // NUEVO: actualizar lista de asignaciones visibles
            ActualizarLstAsignaciones();
        }

        private void btnEditarAsignaciones_Click(object sender, EventArgs e)
        {
            FrmEditarAsignaciones frm = new FrmEditarAsignaciones(controladorAsignaciones, controladorOperario, controladorVehiculo);
            frm.ShowDialog();
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