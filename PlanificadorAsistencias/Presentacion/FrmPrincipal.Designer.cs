namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearOperario = new System.Windows.Forms.Button();
            this.btnCrearVehiculo = new System.Windows.Forms.Button();
            this.btnRegistrarOrden = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.btnVerOrdenes = new System.Windows.Forms.Button();
            this.btnPlanificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGestionOperarios = new System.Windows.Forms.Button();
            this.btnGestionVehiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearOperario
            // 
            this.btnCrearOperario.Location = new System.Drawing.Point(156, 55);
            this.btnCrearOperario.Name = "btnCrearOperario";
            this.btnCrearOperario.Size = new System.Drawing.Size(92, 23);
            this.btnCrearOperario.TabIndex = 0;
            this.btnCrearOperario.Text = "Crear operario";
            this.btnCrearOperario.UseVisualStyleBackColor = true;
            this.btnCrearOperario.Click += new System.EventHandler(this.btnCrearOperario_Click);
            // 
            // btnCrearVehiculo
            // 
            this.btnCrearVehiculo.Location = new System.Drawing.Point(156, 133);
            this.btnCrearVehiculo.Name = "btnCrearVehiculo";
            this.btnCrearVehiculo.Size = new System.Drawing.Size(92, 23);
            this.btnCrearVehiculo.TabIndex = 1;
            this.btnCrearVehiculo.Text = "Crear vehículo\t";
            this.btnCrearVehiculo.UseVisualStyleBackColor = true;
            this.btnCrearVehiculo.Click += new System.EventHandler(this.btnCrearVehiculo_Click);
            // 
            // btnRegistrarOrden
            // 
            this.btnRegistrarOrden.Location = new System.Drawing.Point(156, 218);
            this.btnRegistrarOrden.Name = "btnRegistrarOrden";
            this.btnRegistrarOrden.Size = new System.Drawing.Size(146, 23);
            this.btnRegistrarOrden.TabIndex = 2;
            this.btnRegistrarOrden.Text = "Registrar orden de trabajo\t";
            this.btnRegistrarOrden.UseVisualStyleBackColor = true;
            this.btnRegistrarOrden.Click += new System.EventHandler(this.btnRegistrarOrden_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.Location = new System.Drawing.Point(369, 55);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(165, 23);
            this.btnRecursos.TabIndex = 3;
            this.btnRecursos.Text = "Asignar recursos disponibles\t";
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // btnVerOrdenes
            // 
            this.btnVerOrdenes.Location = new System.Drawing.Point(369, 105);
            this.btnVerOrdenes.Name = "btnVerOrdenes";
            this.btnVerOrdenes.Size = new System.Drawing.Size(165, 23);
            this.btnVerOrdenes.TabIndex = 4;
            this.btnVerOrdenes.Text = "\tVer / editar órdenes registradas";
            this.btnVerOrdenes.UseVisualStyleBackColor = true;
            this.btnVerOrdenes.Click += new System.EventHandler(this.btnVerOrdenes_Click);
            // 
            // btnPlanificar
            // 
            this.btnPlanificar.Location = new System.Drawing.Point(369, 152);
            this.btnPlanificar.Name = "btnPlanificar";
            this.btnPlanificar.Size = new System.Drawing.Size(165, 23);
            this.btnPlanificar.TabIndex = 5;
            this.btnPlanificar.Text = "Generar planificación automática";
            this.btnPlanificar.UseVisualStyleBackColor = true;
            this.btnPlanificar.Click += new System.EventHandler(this.btnPlanificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(291, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGestionOperarios
            // 
            this.btnGestionOperarios.Location = new System.Drawing.Point(191, 84);
            this.btnGestionOperarios.Name = "btnGestionOperarios";
            this.btnGestionOperarios.Size = new System.Drawing.Size(111, 23);
            this.btnGestionOperarios.TabIndex = 7;
            this.btnGestionOperarios.Text = "Gestionar Operarios\n";
            this.btnGestionOperarios.UseVisualStyleBackColor = true;
            this.btnGestionOperarios.Click += new System.EventHandler(this.btnGestionOperarios_Click);
            // 
            // btnGestionVehiculos
            // 
            this.btnGestionVehiculos.Location = new System.Drawing.Point(191, 162);
            this.btnGestionVehiculos.Name = "btnGestionVehiculos";
            this.btnGestionVehiculos.Size = new System.Drawing.Size(111, 23);
            this.btnGestionVehiculos.TabIndex = 8;
            this.btnGestionVehiculos.Text = "Gestionar Vehículos\n\n";
            this.btnGestionVehiculos.UseVisualStyleBackColor = true;
            this.btnGestionVehiculos.Click += new System.EventHandler(this.btnGestionVehiculos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionVehiculos);
            this.Controls.Add(this.btnGestionOperarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPlanificar);
            this.Controls.Add(this.btnVerOrdenes);
            this.Controls.Add(this.btnRecursos);
            this.Controls.Add(this.btnRegistrarOrden);
            this.Controls.Add(this.btnCrearVehiculo);
            this.Controls.Add(this.btnCrearOperario);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearOperario;
        private System.Windows.Forms.Button btnCrearVehiculo;
        private System.Windows.Forms.Button btnRegistrarOrden;
        private System.Windows.Forms.Button btnRecursos;
        private System.Windows.Forms.Button btnVerOrdenes;
        private System.Windows.Forms.Button btnPlanificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGestionOperarios;
        private System.Windows.Forms.Button btnGestionVehiculos;
    }
}