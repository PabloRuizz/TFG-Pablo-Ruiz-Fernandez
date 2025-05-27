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
    public partial class FrmEditarAsignaciones : Form
    {
        private ControladorAsignaciones controladorAsignaciones;
        private ControladorOperario controladorOperario;
        private ControladorVehiculo controladorVehiculo;

        private List<Operario> operarios;
        private List<Vehiculo> vehiculos;

        public FrmEditarAsignaciones(ControladorAsignaciones ca, ControladorOperario co, ControladorVehiculo cv)
        {
            InitializeComponent();
            controladorAsignaciones = ca;
            controladorOperario = co;
            controladorVehiculo = cv;
        }

        private void FrmEditarAsignaciones_Load(object sender, EventArgs e)
        {
            operarios = controladorOperario.ObtenerOperarios();
            vehiculos = controladorVehiculo.ObtenerVehiculos();

            cmbOperarios.Items.Clear();
            cmbVehiculos.Items.Clear();

            foreach (var op in operarios)
                cmbOperarios.Items.Add($"{op.Id} - {op.Nombre}");

            foreach (var v in vehiculos)
                cmbVehiculos.Items.Add($"{v.Id} - {v.Matricula} ({v.Tipo})");

            if (cmbOperarios.Items.Count > 0)
                cmbOperarios.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbOperarios.SelectedIndex == -1 || cmbVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona operario y vehículo.");
                return;
            }

            int idOperario = operarios[cmbOperarios.SelectedIndex].Id;
            int idVehiculo = vehiculos[cmbVehiculos.SelectedIndex].Id;

            controladorAsignaciones.AsignarVehiculo(idOperario, idVehiculo);
            MessageBox.Show("Asignación actualizada correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbOperarios.SelectedIndex == -1)
                return;

            int idOperario = operarios[cmbOperarios.SelectedIndex].Id;

            controladorAsignaciones.EliminarAsignacion(idOperario);
            MessageBox.Show("Asignación eliminada.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}