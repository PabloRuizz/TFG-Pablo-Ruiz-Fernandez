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
    public partial class FrmVerOrdenes : Form
    {
        private ControladorOrdenes controlador;

        public FrmVerOrdenes(ControladorOrdenes controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void FrmVerOrdenes_Load(object sender, EventArgs e)
        {
            var ordenes = controlador.ObtenerOrdenes();

            dgvOrdenes.DataSource = ordenes.Select(o => new
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}