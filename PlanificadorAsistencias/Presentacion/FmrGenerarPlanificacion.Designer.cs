namespace Presentacion
{
    partial class FrmGenerarPlanificador
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lstNoAsignadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Location = new System.Drawing.Point(0, 0);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(690, 450);
            this.txtResultado.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(106, 65);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(184, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Botón para ejecutar planificación";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(0, 134);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(339, 316);
            this.lstResultados.TabIndex = 2;
            // 
            // lstNoAsignadas
            // 
            this.lstNoAsignadas.FormattingEnabled = true;
            this.lstNoAsignadas.Location = new System.Drawing.Point(331, 134);
            this.lstNoAsignadas.Name = "lstNoAsignadas";
            this.lstNoAsignadas.Size = new System.Drawing.Size(342, 316);
            this.lstNoAsignadas.TabIndex = 3;
            // 
            // FrmGenerarPlanificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.lstNoAsignadas);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtResultado);
            this.Name = "FrmGenerarPlanificador";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.FrmGenerarPlanificador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.ListBox lstNoAsignadas;
    }
}