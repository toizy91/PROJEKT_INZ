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
    public partial class dodSlowNIe : Form
    {
        private zarzSlowNiem mainForm;
        public dodSlowNIe(zarzSlowNiem form)
        {
            InitializeComponent();
            mainForm = form;
            this.FormClosed += new FormClosedEventHandler(dodSlowNIe_FormClosed);
        }

        const string FILE_NAME_BASE = "baza.xml";
        private void cbTypSlowa_SelectedIndexChanged(object sender, EventArgs e)
        {
            panOgoln.Visible = true;
            switch (cbTypSlowa.SelectedIndex)
            {
                case 0: //czasownik
                    {
                        cbPrzypadek.Enabled = false;
                        cbRodzajnik.Enabled = false;
                        cbZaimek.Enabled = false;
                        break;
                    }
                case 1: //rekcja czasownika
                    {
                        cbPrzypadek.Enabled = true;
                        cbRodzajnik.Enabled = false;
                        cbZaimek.Enabled = true;
                        break;
                    }
                case 2: //przymiotnik
                    {
                        cbPrzypadek.Enabled = false;
                        cbRodzajnik.Enabled = false;
                        cbZaimek.Enabled = false;
                        break;
                    }
                case 3: //rekcja przymiotnika
                    {
                        cbPrzypadek.Enabled = true;
                        cbRodzajnik.Enabled = true;
                        cbZaimek.Enabled = true;
                        break;
                    }
                case 4: //rzeczownik
                    {
                        cbPrzypadek.Enabled = false;
                        cbRodzajnik.Enabled = true;
                        cbZaimek.Enabled = false;
                        break;
                    }
                case 5: //rekcja rzeczownika
                    {
                        cbPrzypadek.Enabled = true;
                        cbRodzajnik.Enabled = true;
                        cbZaimek.Enabled = true;
                        break;
                    }
                case 6: //zwrot
                    {
                        cbPrzypadek.Enabled = false;
                        cbRodzajnik.Enabled = false;
                        cbZaimek.Enabled = false;
                        break;
                    }
                case 7://inne
                    {
                        cbPrzypadek.Enabled = false;
                        cbRodzajnik.Enabled = false;
                        cbZaimek.Enabled = false;
                        break;
                    }
            }
        }

        private void dodSlowNIe_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajSlowo_Click(object sender, EventArgs e)
        {
            if (cbRodzajnik.Enabled == true)
            {
                string t = txtWyraz.Text.Trim();
                t = char.ToUpper(t[0]) + t.Substring(1);
                txtWyraz.Text = t;
            }

            try
            {
                if (dsBaza1.TDe.Rows.Find(txtWyraz.Text.Trim()) == null)
                {
                    DataRow dr = dsBaza1.TDe.NewRow();
                    dr["wyraz"] = txtWyraz.Text.Trim();
                    dr["znaczenie"] = txtZnaczenie.Text.Trim();
                    dr["typ"] = cbTypSlowa.Text;
                    dr["kategoria"] = cbKategoria.Text;
                    dr["rodzajnik"] = cbRodzajnik.Text;
                    dr["zaimek"] = cbZaimek.Text;
                    dr["przypadek"] = cbPrzypadek.Text;

                    dsBaza1.TDe.Rows.Add(dr);
                    dsBaza1.WriteXml(FILE_NAME_BASE);

                    MessageBox.Show(this, "Pomyślnie dodano słowo do bazy!", "Dodaj słowo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtWyraz.Clear();
                    txtZnaczenie.Clear();
                }
                else
                {
                    MessageBox.Show(this, "Podane słowo już istnieje w bazie!", "Dodaj słowo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtWyraz.Clear();
                    txtZnaczenie.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Wystąpił nieoczekiwany błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtWyraz.Text.Length > 0 && txtZnaczenie.Text.Length > 0)
            {
                btnDodajSlowo.Enabled = true;
            }
            else
            {
                btnDodajSlowo.Enabled = false;
            }
        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            txtWyraz.Clear();
            txtZnaczenie.Clear();
        }

        private void dodSlowNIe_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Refresh();
        }

        private void txtWyraz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtWyraz.Text += "ä";
                txtWyraz.Focus();
                txtWyraz.SelectionStart = txtWyraz.Text.Length;
                txtWyraz.SelectionLength = 0;
            }
            else
            if (e.KeyCode == Keys.F2)
            {
                txtWyraz.Text += "ß";
                txtWyraz.Focus();
                txtWyraz.SelectionStart = txtWyraz.Text.Length;
                txtWyraz.SelectionLength = 0;
            }
            else
            if (e.KeyCode == Keys.F3)
            {
                txtWyraz.Text += "ö";
                txtWyraz.Focus();
                txtWyraz.SelectionStart = txtWyraz.Text.Length;
                txtWyraz.SelectionLength = 0;
            }
            else
            if (e.KeyCode == Keys.F4)
            {
                txtWyraz.Text += "ü";
                txtWyraz.Focus();
                txtWyraz.SelectionStart = txtWyraz.Text.Length;
                txtWyraz.SelectionLength = 0;
            }
        }
    }
}
