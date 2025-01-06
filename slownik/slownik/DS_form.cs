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
    public partial class DS_form_en : Form
    {
        private okno_glowne mainForm;
        public DS_form_en(okno_glowne form)
        {
            InitializeComponent();
            mainForm = form;
            this.FormClosed += new FormClosedEventHandler(DS_form_en_FormClosed);
        }

        const string FILE_NAME_BASE = "baza.xml";

        private void DS_form_en_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }

        private void btnDodajSlowo_Click(object sender, EventArgs e)
        {
            dodajSlowoForm f = new dodajSlowoForm(this);
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsLiczbaSlow.Text = System.Convert.ToString(dgvSlowa.Rows.Count);
            if (dgvSlowa.SelectedRows.Count > 0)
            {
                btnUsunSlowo.Enabled = true;
            }
            else
            {
                btnUsunSlowo.Enabled = false;
            }
        }

        public void Refresh()
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
                    if (MessageBox.Show(this, "Czy na pewno chcesz usunąć wybraną pozycję?", "Zarządzaj słowami angielskimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataRowView drv = (DataRowView)dgvSlowa.SelectedRows[0].DataBoundItem;
                        string t = drv.Row[0].ToString();

                        if (dsBaza1.TEn.Rows.Find(t) != null)
                        {
                            DataRow dr = dsBaza1.TEn.Rows.Find(t);
                            dsBaza1.TEn.Rows.Remove(dr);
                            dsBaza1.WriteXml(FILE_NAME_BASE);
                            MessageBox.Show(this, "Pomyśłnie usunięto wybraną pozycję!", "Zarządzaj słowami angielskimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DS_form_en_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Refresh();
        }
    }
}
