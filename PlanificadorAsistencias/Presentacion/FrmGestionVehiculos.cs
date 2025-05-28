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
    public partial class FrmGestionVehiculos : Form
    {
        private ControladorVehiculo controlador;
        private List<Vehiculo> lista;

        public FrmGestionVehiculos(ControladorVehiculo ctrl)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            controlador = ctrl;
        }

        private void FrmGestionVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void CargarVehiculos()
        {
            lista = controlador.ObtenerVehiculos();

            dgvVehiculos.DataSource = lista.Select(v => new
            {
                v.Id,
                v.Matricula,
                v.Tipo,
                v.Capacidad,
                Disponible = v.Disponible ? "Sí" : "No"
            }).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0) return;

            int id = (int)dgvVehiculos.SelectedRows[0].Cells["Id"].Value;
            controlador.EliminarVehiculo(id);
            CargarVehiculos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0) return;

            int id = (int)dgvVehiculos.SelectedRows[0].Cells["Id"].Value;
            Vehiculo seleccionado = controlador.ObtenerVehiculoPorId(id);

            FrmEditarVehiculo frm = new FrmEditarVehiculo(seleccionado);
            frm.ShowDialog();

            controlador.GuardarCambios(); // Reescribe vehiculos.xml
            CargarVehiculos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
