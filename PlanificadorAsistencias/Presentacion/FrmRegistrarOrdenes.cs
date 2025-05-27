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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Presentacion
{
    public partial class FrmRegistrarOrdenes : Form
    {
        private ControladorOrdenes controlador;

        public FrmRegistrarOrdenes(ControladorOrdenes controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void FrmRegistrarOrdenes_Load(object sender, EventArgs e)
        {
            cmbDispositivo.Items.AddRange(new string[]
            {
                "Imagen",
                "Informatica",
                "Impresion",
                "Instalacion"
            });
            cmbDispositivo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtCliente.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string dispositivo = cmbDispositivo.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text.Trim();
            int prioridad = (int)nudPrioridad.Value;
            bool enGarantia = chkGarantia.Checked;
            DateTime fecha = dtpFecha.Value;

            if (string.IsNullOrWhiteSpace(nombreCliente) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("El nombre y dirección del cliente son obligatorios.");
                return;
            }

            Cliente cliente = new Cliente
            {
                Nombre = nombreCliente,
                Direccion = direccion,
                TipoDispositivo = dispositivo
            };

            OrdenTrabajo nuevaOrden = new OrdenTrabajo
            {
                Cliente = cliente,
                Estado = "Pendiente",
                FechaAsignacion = fecha,
                Prioridad = prioridad,
                EnGarantia = enGarantia,
                Ubicacion = ubicacion
            };

            controlador.CrearOrden(nuevaOrden);

            MessageBox.Show("Orden registrada correctamente.");
            this.Close();
        }
    }
}
