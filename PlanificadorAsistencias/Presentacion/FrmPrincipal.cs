﻿using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private ControladorOperario controladorOperario = new ControladorOperario();
        private ControladorVehiculo controladorVehiculo = new ControladorVehiculo();
        private ControladorOrdenes controladorOrdenes = new ControladorOrdenes();

        public FrmPrincipal()
        {
            InitializeComponent();

            controladorOperario = new ControladorOperario();
            controladorVehiculo = new ControladorVehiculo();
        }

        private void btnCrearOperario_Click(object sender, EventArgs e)
        {
            FrmCrearOperario form = new FrmCrearOperario(controladorOperario);
            form.ShowDialog();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            FrmCrearVehiculo form = new FrmCrearVehiculo(controladorVehiculo);
            form.ShowDialog();
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrdenes form = new FrmRegistrarOrdenes(controladorOrdenes);
            form.ShowDialog();
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            FrmSeleccionarRecursos form = new FrmSeleccionarRecursos(controladorOperario, controladorVehiculo);
            form.ShowDialog();
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            FrmVerOrdenes form = new FrmVerOrdenes(controladorOrdenes);
            form.ShowDialog();
        }

        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            FrmGenerarPlanificacion form = new FrmGenerarPlanificacion(controladorOperario, controladorOrdenes);
            form.ShowDialog();
        }

        private void btnGestionOperarios_Click(object sender, EventArgs e)
        {
            FrmGestionOperarios frm = new FrmGestionOperarios(controladorOperario);
            frm.ShowDialog();
        }

        private void btnGestionVehiculos_Click(object sender, EventArgs e)
        {
            FrmGestionVehiculos frm = new FrmGestionVehiculos(controladorVehiculo);
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
