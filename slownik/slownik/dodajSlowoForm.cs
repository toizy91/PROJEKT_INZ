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
    public partial class dodajSlowoForm : Form
    {
        public dodajSlowoForm()
        {
            InitializeComponent();
        }
        const string FILE_NAME_BASE = "baza.xml";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajSlowo_Click(object sender, EventArgs e)
        {
            if (dsBaza1.TEn.Rows.Find(txtWyraz.Text.Trim()) == null)
            {
                DataRow dr = dsBaza1.TEn.NewRow();
                dr["wyraz"] = txtWyraz.Text;
                dr["znaczenie"] = txtZnaczenie.Text;
                dr["typ"] = cbTypSlowa.Text;
                dr["kategoria"] = cbKategoria.Text;

                dsBaza1.TEn.Rows.Add(dr);
                dsBaza1.WriteXml(FILE_NAME_BASE);

                MessageBox.Show(this, "Pomyślnie dodano słowo do bazy!", "Dodaj słowo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWyraz.Clear();
                txtZnaczenie.Clear();
            }else
            {
                MessageBox.Show(this,"Podane słowo już istnieje w bazie!","Dodaj słowo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dodajSlowoForm_Load(object sender, EventArgs e)
        {
            dsBaza1.ReadXml(FILE_NAME_BASE);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbTypSlowa.SelectedIndex == -1 || cbKategoria.SelectedIndex == -1 || txtWyraz.Text.Length == 0 || txtZnaczenie.Text.Length == 0)
            {
                btnDodajSlowo.Enabled = false;
            }else
            {
                btnDodajSlowo.Enabled=true;
            }
        }
    }
}
