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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnCrearOperario = new System.Windows.Forms.Button();
            this.btnCrearVehiculo = new System.Windows.Forms.Button();
            this.btnRegistrarOrden = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.btnVerOrdenes = new System.Windows.Forms.Button();
            this.btnPlanificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGestionOperarios = new System.Windows.Forms.Button();
            this.btnGestionVehiculos = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearOperario
            // 
            this.btnCrearOperario.Location = new System.Drawing.Point(85, 48);
            this.btnCrearOperario.Name = "btnCrearOperario";
            this.btnCrearOperario.Size = new System.Drawing.Size(165, 23);
            this.btnCrearOperario.TabIndex = 0;
            this.btnCrearOperario.Text = "Crear operario";
            this.btnCrearOperario.UseVisualStyleBackColor = true;
            this.btnCrearOperario.Click += new System.EventHandler(this.btnCrearOperario_Click);
            // 
            // btnCrearVehiculo
            // 
            this.btnCrearVehiculo.Location = new System.Drawing.Point(85, 132);
            this.btnCrearVehiculo.Name = "btnCrearVehiculo";
            this.btnCrearVehiculo.Size = new System.Drawing.Size(165, 23);
            this.btnCrearVehiculo.TabIndex = 1;
            this.btnCrearVehiculo.Text = "Crear vehículo\t";
            this.btnCrearVehiculo.UseVisualStyleBackColor = true;
            this.btnCrearVehiculo.Click += new System.EventHandler(this.btnCrearVehiculo_Click);
            // 
            // btnRegistrarOrden
            // 
            this.btnRegistrarOrden.Location = new System.Drawing.Point(315, 48);
            this.btnRegistrarOrden.Name = "btnRegistrarOrden";
            this.btnRegistrarOrden.Size = new System.Drawing.Size(165, 23);
            this.btnRegistrarOrden.TabIndex = 2;
            this.btnRegistrarOrden.Text = "Registrar orden de trabajo\t";
            this.btnRegistrarOrden.UseVisualStyleBackColor = true;
            this.btnRegistrarOrden.Click += new System.EventHandler(this.btnRegistrarOrden_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.Location = new System.Drawing.Point(315, 132);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(165, 23);
            this.btnRecursos.TabIndex = 3;
            this.btnRecursos.Text = "Asignar recursos disponibles\t";
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // btnVerOrdenes
            // 
            this.btnVerOrdenes.Location = new System.Drawing.Point(315, 77);
            this.btnVerOrdenes.Name = "btnVerOrdenes";
            this.btnVerOrdenes.Size = new System.Drawing.Size(165, 23);
            this.btnVerOrdenes.TabIndex = 4;
            this.btnVerOrdenes.Text = "\tVer / editar órdenes registradas";
            this.btnVerOrdenes.UseVisualStyleBackColor = true;
            this.btnVerOrdenes.Click += new System.EventHandler(this.btnVerOrdenes_Click);
            // 
            // btnPlanificar
            // 
            this.btnPlanificar.Location = new System.Drawing.Point(315, 161);
            this.btnPlanificar.Name = "btnPlanificar";
            this.btnPlanificar.Size = new System.Drawing.Size(165, 23);
            this.btnPlanificar.TabIndex = 5;
            this.btnPlanificar.Text = "Generar planificación automática";
            this.btnPlanificar.UseVisualStyleBackColor = true;
            this.btnPlanificar.Click += new System.EventHandler(this.btnPlanificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(245, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGestionOperarios
            // 
            this.btnGestionOperarios.Location = new System.Drawing.Point(85, 77);
            this.btnGestionOperarios.Name = "btnGestionOperarios";
            this.btnGestionOperarios.Size = new System.Drawing.Size(165, 23);
            this.btnGestionOperarios.TabIndex = 7;
            this.btnGestionOperarios.Text = "Gestionar Operarios\n";
            this.btnGestionOperarios.UseVisualStyleBackColor = true;
            this.btnGestionOperarios.Click += new System.EventHandler(this.btnGestionOperarios_Click);
            // 
            // btnGestionVehiculos
            // 
            this.btnGestionVehiculos.Location = new System.Drawing.Point(85, 161);
            this.btnGestionVehiculos.Name = "btnGestionVehiculos";
            this.btnGestionVehiculos.Size = new System.Drawing.Size(165, 23);
            this.btnGestionVehiculos.TabIndex = 8;
            this.btnGestionVehiculos.Text = "Gestionar Vehículos\n\n";
            this.btnGestionVehiculos.UseVisualStyleBackColor = true;
            this.btnGestionVehiculos.Click += new System.EventHandler(this.btnGestionVehiculos_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.Icono_planning;
            this.pictureBox4.Location = new System.Drawing.Point(281, 125);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.Icono_herramientas;
            this.pictureBox3.Location = new System.Drawing.Point(273, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Icono_operario;
            this.pictureBox1.Location = new System.Drawing.Point(43, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Icono_vehiculo;
            this.pictureBox2.Location = new System.Drawing.Point(47, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 339);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGestionVehiculos);
            this.Controls.Add(this.btnGestionOperarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPlanificar);
            this.Controls.Add(this.btnVerOrdenes);
            this.Controls.Add(this.btnRecursos);
            this.Controls.Add(this.btnRegistrarOrden);
            this.Controls.Add(this.btnCrearVehiculo);
            this.Controls.Add(this.btnCrearOperario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}