using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public static class CustomUI
    {
        public static void LoadDefaultStyle(Form actualForm)
        {
            actualForm.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro
            actualForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            foreach (Control control in actualForm.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(40, 40, 40); // Gris oscuro
                    lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }

                else if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(50, 90, 130); // Azul oscuro elegante
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0;
                }

                else if (control is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Font = new Font("Segoe UI", 9F);
                }

                else if (control is ComboBox cmb)
                {
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb.Font = new Font("Segoe UI", 9F);
                }

                else if (control is CheckBox chk)
                {
                    chk.Font = new Font("Segoe UI", 9F);
                }

                else if (control is ListBox lb)
                {
                    lb.Font = new Font("Segoe UI", 9F);
                }

                else if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
                    dgv.EnableHeadersVisualStyles = false;
                }
            }
        }
    }
}
