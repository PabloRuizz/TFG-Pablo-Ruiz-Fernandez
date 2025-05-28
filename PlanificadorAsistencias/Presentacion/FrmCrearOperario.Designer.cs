namespace Presentacion
{
    partial class FrmCrearOperario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInformatica = new System.Windows.Forms.CheckBox();
            this.chkIntalaciones = new System.Windows.Forms.CheckBox();
            this.chkImpresion = new System.Windows.Forms.CheckBox();
            this.chkImagen = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(290, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkInformatica);
            this.groupBox1.Controls.Add(this.chkIntalaciones);
            this.groupBox1.Controls.Add(this.chkImpresion);
            this.groupBox1.Controls.Add(this.chkImagen);
            this.groupBox1.Location = new System.Drawing.Point(290, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilidades";
            // 
            // chkInformatica
            // 
            this.chkInformatica.AutoSize = true;
            this.chkInformatica.Location = new System.Drawing.Point(6, 88);
            this.chkInformatica.Name = "chkInformatica";
            this.chkInformatica.Size = new System.Drawing.Size(78, 17);
            this.chkInformatica.TabIndex = 3;
            this.chkInformatica.Text = "Informática";
            this.chkInformatica.UseVisualStyleBackColor = true;
            // 
            // chkIntalaciones
            // 
            this.chkIntalaciones.AutoSize = true;
            this.chkIntalaciones.Location = new System.Drawing.Point(6, 65);
            this.chkIntalaciones.Name = "chkIntalaciones";
            this.chkIntalaciones.Size = new System.Drawing.Size(88, 17);
            this.chkIntalaciones.TabIndex = 2;
            this.chkIntalaciones.Text = "Instalaciones";
            this.chkIntalaciones.UseVisualStyleBackColor = true;
            // 
            // chkImpresion
            // 
            this.chkImpresion.AutoSize = true;
            this.chkImpresion.Location = new System.Drawing.Point(6, 42);
            this.chkImpresion.Name = "chkImpresion";
            this.chkImpresion.Size = new System.Drawing.Size(71, 17);
            this.chkImpresion.TabIndex = 1;
            this.chkImpresion.Text = "Impresión";
            this.chkImpresion.UseVisualStyleBackColor = true;
            // 
            // chkImagen
            // 
            this.chkImagen.AutoSize = true;
            this.chkImagen.Location = new System.Drawing.Point(6, 19);
            this.chkImagen.Name = "chkImagen";
            this.chkImagen.Size = new System.Drawing.Size(61, 17);
            this.chkImagen.TabIndex = 0;
            this.chkImagen.Text = "Imagen";
            this.chkImagen.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(337, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmCrearOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearOperario";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkImagen;
        private System.Windows.Forms.CheckBox chkInformatica;
        private System.Windows.Forms.CheckBox chkIntalaciones;
        private System.Windows.Forms.CheckBox chkImpresion;
        private System.Windows.Forms.Button btnGuardar;
    }
}