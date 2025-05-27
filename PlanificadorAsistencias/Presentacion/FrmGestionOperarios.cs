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

namespace Presentacion
{
    public partial class FrmGestionOperarios : Form
    {
        private ControladorOperario controlador;
        private List<Operario> lista;

        public FrmGestionOperarios(ControladorOperario ctrl)
        {
            InitializeComponent();
            controlador = ctrl;
        }

        private void FrmGestionOperarios_Load(object sender, EventArgs e)
        {
            CargarOperarios();
        }

        private void CargarOperarios()
        {
            lista = controlador.ObtenerOperarios();

            dgvOperarios.DataSource = null;
            dgvOperarios.DataSource = lista.Select(o => new
            {
                o.Id,
                o.Nombre,
                Disponible = o.Disponible ? "Sí" : "No",
                Habilidades = string.Join(", ", o.Habilidades)
            }).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOperarios.SelectedRows.Count == 0) return;

            int id = (int)dgvOperarios.SelectedRows[0].Cells["Id"].Value;

            controlador.EliminarOperario(id);
            CargarOperarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvOperarios.SelectedRows.Count == 0) return;

            int id = (int)dgvOperarios.SelectedRows[0].Cells["Id"].Value;
            Operario seleccionado = controlador.ObtenerOperarioPorId(id);

            FrmEditarOperario frm = new FrmEditarOperario(seleccionado);
            frm.ShowDialog();

            controlador.GuardarCambios(); // vuelve a guardar el archivo
            CargarOperarios();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}