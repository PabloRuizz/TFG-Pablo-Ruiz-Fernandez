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
using Microsoft.VisualBasic;


namespace Presentacion
{
    public partial class FrmVerOrdenes : Form
    {
        private ControladorOrdenes controlador;
        private List<OrdenTrabajo> ordenesOriginal;

        public FrmVerOrdenes(ControladorOrdenes controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void FrmVerOrdenes_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            ordenesOriginal = controlador.ObtenerOrdenes();

            dgvOrdenes.DataSource = ordenesOriginal.Select(o => new
            {
                o.Id,
                Cliente = o.Cliente.Nombre,
                Dirección = o.Cliente.Direccion,
                Dispositivo = o.Cliente.TipoDispositivo,
                o.FechaAsignacion,
                o.Prioridad,
                Garantía = o.EnGarantia ? "Sí" : "No",
                o.Estado,
                o.Ubicacion
            }).ToList();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            var filtradas = ordenesOriginal.Where(o =>
                o.Cliente.Nombre.ToLower().Contains(filtro) ||
                o.Cliente.Direccion.ToLower().Contains(filtro) ||
                o.Cliente.TipoDispositivo.ToLower().Contains(filtro) ||
                o.Ubicacion.ToLower().Contains(filtro)).ToList();

            dgvOrdenes.DataSource = filtradas.Select(o => new
            {
                o.Id,
                Cliente = o.Cliente.Nombre,
                Dirección = o.Cliente.Direccion,
                Dispositivo = o.Cliente.TipoDispositivo,
                o.FechaAsignacion,
                o.Prioridad,
                Garantía = o.EnGarantia ? "Sí" : "No",
                o.Estado,
                o.Ubicacion
            }).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una orden para eliminar.");
                return;
            }

            int id = (int)dgvOrdenes.SelectedRows[0].Cells["Id"].Value;

            controlador.EliminarOrden(id);
            CargarOrdenes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una orden para modificar.");
                return;
            }

            int id = (int)dgvOrdenes.SelectedRows[0].Cells["Id"].Value;
            var orden = controlador.ObtenerOrdenPorId(id);

            if (orden != null)
            {
                string nuevoEstado = Microsoft.VisualBasic.Interaction.InputBox("Nuevo estado:", "Modificar orden", orden.Estado);
                if (!string.IsNullOrWhiteSpace(nuevoEstado))
                {
                    orden.Estado = nuevoEstado;
                    CargarOrdenes();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}