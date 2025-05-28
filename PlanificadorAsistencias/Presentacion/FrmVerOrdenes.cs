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
using static Presentacion.CustomUI;

namespace Presentacion
{
    public partial class FrmVerOrdenes : Form
    {
        private ControladorOrdenes controlador;
        private List<OrdenTrabajo> ordenesOriginal;

        public FrmVerOrdenes(ControladorOrdenes controlador)
        {
            InitializeComponent();
            LoadDefaultStyle(this);
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
                o.NumeroOrden, 
                Cliente = o.Cliente.Nombre,
                Dirección = o.Direccion,
                o.CodigoPostal,
                o.TipoDispositivo,
                o.Estado,
                Garantía = o.EnGarantia ? "Sí" : "No",
                o.FechaAsignacion
            }).ToList();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            var filtradas = ordenesOriginal.Where(o =>
                o.Cliente.Nombre.ToLower().Contains(filtro) ||
                o.Cliente.Direccion.ToLower().Contains(filtro) ||
                o.Cliente.TipoDispositivo.ToLower().Contains(filtro) ||
                o.CodigoPostal.ToLower().Contains(filtro)).ToList();

            dgvOrdenes.DataSource = filtradas.Select(o => new
            {
                o.Id,
                Cliente = o.Cliente.Nombre,
                Dirección = o.Cliente.Direccion,
                Dispositivo = o.Cliente.TipoDispositivo,
                o.FechaAsignacion,
                Garantía = o.EnGarantia ? "Sí" : "No",
                o.Estado,
                o.CodigoPostal
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
                FrmEditarOrden frm = new FrmEditarOrden(orden);
                frm.ShowDialog();

                controlador.EditarOrden(orden); 
                CargarOrdenes(); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}