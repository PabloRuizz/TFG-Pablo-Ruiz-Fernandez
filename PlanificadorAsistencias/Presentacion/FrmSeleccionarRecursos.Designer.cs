﻿namespace Presentacion
{
    partial class FrmSeleccionarRecursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarRecursos));
            this.label1 = new System.Windows.Forms.Label();
            this.clbOperarios = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstAsignaciones = new System.Windows.Forms.ListBox();
            this.btnEditarAsignaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operarios disponibles";
            // 
            // clbOperarios
            // 
            this.clbOperarios.FormattingEnabled = true;
            this.clbOperarios.Location = new System.Drawing.Point(160, 77);
            this.clbOperarios.Name = "clbOperarios";
            this.clbOperarios.Size = new System.Drawing.Size(120, 64);
            this.clbOperarios.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asignar Vehículos";
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(160, 190);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculos.TabIndex = 3;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(113, 236);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(221, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar vehículo al operario seleccionado";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(148, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar selección y cerrar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstAsignaciones
            // 
            this.lstAsignaciones.FormattingEnabled = true;
            this.lstAsignaciones.Location = new System.Drawing.Point(410, 99);
            this.lstAsignaciones.Name = "lstAsignaciones";
            this.lstAsignaciones.Size = new System.Drawing.Size(328, 160);
            this.lstAsignaciones.TabIndex = 6;
            // 
            // btnEditarAsignaciones
            // 
            this.btnEditarAsignaciones.Location = new System.Drawing.Point(148, 327);
            this.btnEditarAsignaciones.Name = "btnEditarAsignaciones";
            this.btnEditarAsignaciones.Size = new System.Drawing.Size(150, 23);
            this.btnEditarAsignaciones.TabIndex = 7;
            this.btnEditarAsignaciones.Text = "Editar asignaciones";
            this.btnEditarAsignaciones.UseVisualStyleBackColor = true;
            this.btnEditarAsignaciones.Click += new System.EventHandler(this.btnEditarAsignaciones_Click);
            // 
            // FrmSeleccionarRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarAsignaciones);
            this.Controls.Add(this.lstAsignaciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbOperarios);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionarRecursos";
            this.Text = "Seleccionar recursos";
            this.Load += new System.EventHandler(this.FrmSeleccionarRecursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbOperarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstAsignaciones;
        private System.Windows.Forms.Button btnEditarAsignaciones;
    }
}