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
    public partial class DK_form : Form
    {
        public DK_form()
        {
            InitializeComponent();
        }

        const string FILE_NAME_BASE = "baza.xml";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajKategorie_Click(object sender, EventArgs e)
        {
            if (txtNowaKategoria.Text.Length == 0)
            {
                MessageBox.Show(this, "Wpisz kategorię!", "Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dsBaza1.TKategorie.Rows.Find(txtNowaKategoria.Text.Trim()) == null)
            {
                DataRow dr = dsBaza1.TKategorie.NewRow();
                dr["kategoria"] = txtNowaKategoria.Text.Trim();
                dsBaza1.TKategorie.Rows.Add(dr);
                dsBaza1.WriteXml(FILE_NAME_BASE);

                MessageBox.Show(this, "Pomyślnie dodano kategorię!", "Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNowaKategoria.Clear();
            }
            else
            {
                MessageBox.Show(this, "Podana kategoria istnieje już w bazie!", "Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DK_form_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }

        private void btnUsunKategorie_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cbKategorie.SelectedItem;
            if (drv != null)
            {
                if (MessageBox.Show(this, "Czy na pewno chcesz usunąć wybraną kategorię?", "Kategorie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    drv.Delete();
                    dsBaza1.WriteXml("kategorie.xml");
                    MessageBox.Show(this, "Pomyślnie usunięto kategorię!", "Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtNowaKategoria.Text.Length > 0)
            {
                btnDodajKategorie.Enabled = true;
            }else
            {
                btnDodajKategorie.Enabled=false;
            }

            if (cbKategorie.SelectedIndex >= 0)
            {
                btnUsunKategorie.Enabled = true;
            }else
            {
                btnUsunKategorie.Enabled=!false;
            }
        }

    }
}
