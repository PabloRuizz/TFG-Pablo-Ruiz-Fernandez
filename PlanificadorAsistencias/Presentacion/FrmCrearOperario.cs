using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.CustomUI;


namespace Presentacion
{
    public partial class FrmCrearOperario : Form
    {
        private ControladorOperario controlador;

        private void FrmCrearOperario_Load(object sender, EventArgs e)
        {
            clbZonas.Items.AddRange(new string[]
            {
        "Centro",
        "Sur",
        "Este",
        "Oeste"
            });
        }

        public FrmCrearOperario(ControladorOperario controlador)
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            this.controlador = controlador;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            List<string> habilidades = new List<string>();


            if (chkImagen.Checked) habilidades.Add("Imagen");
            if (chkImpresion.Checked) habilidades.Add("Impresión");
            if (chkIntalaciones.Checked) habilidades.Add("Instalaciones");
            if (chkInformatica.Checked) habilidades.Add("Informática");

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            List<Zona> zonas = new List<Zona>();

            foreach (var item in clbZonas.CheckedItems)
            {
                if (Enum.TryParse(item.ToString(), out Zona zona))
                {
                    zonas.Add(zona);
                }
            }

            Operario nuevo = new Operario
            {
                Nombre = nombre,
                Disponible = true,
                Habilidades = habilidades,
                ZonasAsignadas = zonas
            };


            controlador.CrearOperario(nuevo);

            MessageBox.Show("Operario creado correctamente.");
            this.Close(); // O limpia los campos si prefieres dejar el form abierto
        }


    }
}