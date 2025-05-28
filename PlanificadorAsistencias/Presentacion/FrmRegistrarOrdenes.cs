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
using static Presentacion.CustomUI;

namespace Presentacion
{
    public partial class FrmRegistrarOrdenes : Form
    {
        private ControladorOrdenes controlador;

        public FrmRegistrarOrdenes(ControladorOrdenes controlador)
        {
            InitializeComponent();
            LoadDefaultStyle(this);
            this.controlador = controlador;
        }

        private void FrmRegistrarOrdenes_Load(object sender, EventArgs e)
        {
            cmbDispositivo.Items.AddRange(new string[]
            {
                "Imagen",
                "Impresión",
                "Instalaciones",
                "Informática"
            });

            cmbDispositivo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string numeroOrden = txtNumeroOrden.Text.Trim();
            string nombreCliente = txtCliente.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string codigoPostal = txtCodigoPostal.Text.Trim();
            string dispositivo = cmbDispositivo.SelectedItem?.ToString() ?? "";
            string observaciones = txtObservaciones.Text.Trim();
            bool enGarantia = chkGarantia.Checked;
            DateTime fecha = dtpFecha.Value;

            if (string.IsNullOrWhiteSpace(numeroOrden) ||
                string.IsNullOrWhiteSpace(nombreCliente) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(codigoPostal))
            {
                MessageBox.Show("Los campos Número de orden, nombre, dirección y código postal son obligatorios.");
                return;
            }

            if (controlador.NumeroOrdenExiste(numeroOrden))
            {
                MessageBox.Show("Ya existe una orden con ese número. Introduce uno diferente.");
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
                NumeroOrden = numeroOrden,
                Cliente = cliente,
                Estado = "Pendiente",
                FechaAsignacion = fecha,
                EnGarantia = enGarantia,
                Direccion = direccion,
                CodigoPostal = codigoPostal,
                TipoDispositivo = dispositivo,
                Observaciones = observaciones
            };

            controlador.CrearOrden(nuevaOrden);

            MessageBox.Show("Orden registrada correctamente.");
            this.Close();
        }

    }
}
