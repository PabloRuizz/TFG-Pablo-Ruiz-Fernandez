﻿namespace Presentacion
{
    partial class FrmEditarOperario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarOperario));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkImagen = new System.Windows.Forms.CheckBox();
            this.chkImpresion = new System.Windows.Forms.CheckBox();
            this.chkInstalaciones = new System.Windows.Forms.CheckBox();
            this.chkInformatica = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.clbZonas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // chkImagen
            // 
            this.chkImagen.AutoSize = true;
            this.chkImagen.Location = new System.Drawing.Point(122, 84);
            this.chkImagen.Name = "chkImagen";
            this.chkImagen.Size = new System.Drawing.Size(61, 17);
            this.chkImagen.TabIndex = 1;
            this.chkImagen.Text = "Imagen";
            this.chkImagen.UseVisualStyleBackColor = true;
            // 
            // chkImpresion
            // 
            this.chkImpresion.AutoSize = true;
            this.chkImpresion.Location = new System.Drawing.Point(122, 107);
            this.chkImpresion.Name = "chkImpresion";
            this.chkImpresion.Size = new System.Drawing.Size(71, 17);
            this.chkImpresion.TabIndex = 2;
            this.chkImpresion.Text = "Impresión";
            this.chkImpresion.UseVisualStyleBackColor = true;
            // 
            // chkInstalaciones
            // 
            this.chkInstalaciones.AutoSize = true;
            this.chkInstalaciones.Location = new System.Drawing.Point(122, 130);
            this.chkInstalaciones.Name = "chkInstalaciones";
            this.chkInstalaciones.Size = new System.Drawing.Size(88, 17);
            this.chkInstalaciones.TabIndex = 3;
            this.chkInstalaciones.Text = "Instalaciones";
            this.chkInstalaciones.UseVisualStyleBackColor = true;
            // 
            // chkInformatica
            // 
            this.chkInformatica.AutoSize = true;
            this.chkInformatica.Location = new System.Drawing.Point(122, 153);
            this.chkInformatica.Name = "chkInformatica";
            this.chkInformatica.Size = new System.Drawing.Size(78, 17);
            this.chkInformatica.TabIndex = 4;
            this.chkInformatica.Text = "Informática";
            this.chkInformatica.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.Location = new System.Drawing.Point(122, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // clbZonas
            // 
            this.clbZonas.FormattingEnabled = true;
            this.clbZonas.Location = new System.Drawing.Point(113, 191);
            this.clbZonas.Name = "clbZonas";
            this.clbZonas.Size = new System.Drawing.Size(120, 94);
            this.clbZonas.TabIndex = 6;
            // 
            // FrmEditarOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.clbZonas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkInformatica);
            this.Controls.Add(this.chkInstalaciones);
            this.Controls.Add(this.chkImpresion);
            this.Controls.Add(this.chkImagen);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarOperario";
            this.Text = "Editar operario";
            this.Load += new System.EventHandler(this.FrmEditarOperario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkImagen;
        private System.Windows.Forms.CheckBox chkImpresion;
        private System.Windows.Forms.CheckBox chkInstalaciones;
        private System.Windows.Forms.CheckBox chkInformatica;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckedListBox clbZonas;
    }
}