using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slownik
{
    public partial class zarzSlowNiem : Form
    {
        private okno_glowne mainForm;
        public zarzSlowNiem(okno_glowne form)
        {
            InitializeComponent();
            mainForm = form;
            this.FormClosed += new FormClosedEventHandler(zarzSlowNiem_FormClosed); 
        }
        const string FILE_NAME_BASE = "baza.xml";

        private void zarzSlowNiem_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }

        private void btnDodajSlowo_Click(object sender, EventArgs e)
        {
            dodSlowNIe f = new dodSlowNIe(this);
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsLab.Text = System.Convert.ToString(dgvSlowa.RowCount);
            if (dgvSlowa.SelectedRows.Count > 0)
            {
                btnUsunSlowo.Enabled = true;
            }
            else
            {
                btnUsunSlowo.Enabled = false;
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Refresh()
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.Clear();
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.Clear();
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }

        private void btnUsunSlowo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSlowa.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(this, "Czy na pewno chcesz usunąć wybraną pozycję?", "Zarządzaj słowami niemieckiemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataRowView drv = (DataRowView)dgvSlowa.SelectedRows[0].DataBoundItem;
                        string t = drv.Row[0].ToString();

                        if (dsBaza1.TDe.Rows.Find(t) != null)
                        {
                            DataRow dr = dsBaza1.TDe.Rows.Find(t);
                            dsBaza1.TDe.Rows.Remove(dr);
                            dsBaza1.WriteXml(FILE_NAME_BASE);
                            MessageBox.Show(this, "Pomyśłnie usunięto wybraną pozycję!", "Zarządzaj słowami niemieckimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Wystąpił nieoczekiwany błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mainForm.Refresh();
            }
        }

        private void zarzSlowNiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Refresh();
        }
    }
}
