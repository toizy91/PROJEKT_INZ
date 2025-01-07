using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slownik
{
    public partial class nakaForm : Form
    {
        public nakaForm()
        {
            InitializeComponent();
        }
        const string FILE_NAME_BASE = "baza.xml";
        int typ_zrodla = 0;

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbJezyk_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbJezyk.SelectedIndex)
            {
                case 0:
                    {
                        lbSlowaWY.DataSource = dsBaza1.TEn;
                        lbSlowaWY.DisplayMember = "wyraz";
                        lbSlowaWY.SelectedIndex = -1;
                        typ_zrodla = 0;
                        break;
                    }
                case 1:
                    {
                        lbSlowaWY.DataSource = dsBaza1.TDe;
                        lbSlowaWY.DisplayMember = "wyraz";
                        lbSlowaWY.SelectedIndex = -1;
                        typ_zrodla = 1;
                        break;
                    }
            }
            cbJezyk.Enabled = false;
        }

        private void nakaForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
                dsBaza1.ReadXml(FILE_NAME_BASE);
        }

        private void btnDodajDoNauka_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSlowaWY.SelectedIndex >= -1)
                {
                    DataRowView drV = (DataRowView)lbSlowaWY.SelectedItem;

                    if (typ_zrodla == 0)
                    {
                        if (dsBazaEn1.TEn.Rows.Find(drV.Row[0]) == null)
                        {

                            DataRow dr = dsBazaEn1.TEn.NewRow();
                            dr["wyraz"] = drV.Row[0].ToString();
                            dr["znaczenie"] = drV.Row[1].ToString();
                            dsBazaEn1.TEn.Rows.Add(dr);
                            lbSlowaDoNauk.DataSource = dsBazaEn1.TEn;
                            lbSlowaDoNauk.DisplayMember = "wyraz";
                        }
                        else
                        {
                            MessageBox.Show(this, "Podany element istnieje już na liście!", "Nauka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    if (typ_zrodla == 1)
                    {
                        if (dsBazaDe1.TDe.Rows.Find(drV.Row[0]) == null)
                        {
                            DataRow dr = dsBazaDe1.TDe.NewRow();
                            dr["wyraz"] = drV.Row[0].ToString();
                            dr["znaczenie"] = drV.Row[1].ToString();
                            dr["rodzajnik"] = drV.Row[4].ToString();
                            dr["zaimek"] = drV.Row[5].ToString();
                            dr["przypadek"] = drV.Row[6].ToString();
                            dsBazaDe1.TDe.Rows.Add(dr);
                            lbSlowaDoNauk.DataSource = dsBazaDe1.TDe;
                            lbSlowaDoNauk.DisplayMember = "wyraz";
                        }
                        else
                        {
                            MessageBox.Show(this, "Podany element istnieje już na liście!", "Nauka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Nieoczekiwany błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerujPlik_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSlowaDoNauk.Items.Count > 0)
                {
                    {
                        if (typ_zrodla == 0) //plik angielski
                        {
                            zapiszPlikDial.FilterIndex = 1;
                            if (zapiszPlikDial.ShowDialog() == DialogResult.OK)
                            {
                                dsBazaEn1.WriteXml(zapiszPlikDial.FileName);
                                this.Close();
                            }
                        }
                        else if (typ_zrodla == 1) //plik niemiecki
                        {
                            zapiszPlikDial.FilterIndex = 2;
                            if (zapiszPlikDial.ShowDialog() == DialogResult.OK)
                            {
                                dsBazaDe1.WriteXml(zapiszPlikDial.FileName);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Nieoczekiwany błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsunZNauka_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSlowaDoNauk.SelectedIndex >= 0)
                {
                    DataRowView drv = (DataRowView)lbSlowaDoNauk.SelectedItem;
                    string t = drv.Row[0].ToString();

                    if (typ_zrodla == 0)
                    {
                        if (dsBazaEn1.TEn.Rows.Find(t) != null)
                        {
                            dsBazaEn1.TEn.Rows.Remove(drv.Row);
                        }
                    }
                    else if (typ_zrodla == 1)
                    {
                        if (dsBazaDe1.TDe.Rows.Find(t) != null)
                        {
                            dsBazaDe1.TDe.Rows.Remove(drv.Row);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Nieoczekiwany błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbSlowaWY.SelectedIndex >= 0)
                btnDodajDoNauka.Enabled = true;
            else btnDodajDoNauka.Enabled = false;

            if (lbSlowaDoNauk.SelectedIndex >= 0)
                btnUsunZNauka.Enabled = true;
            else btnUsunZNauka.Enabled = false;

            if (lbSlowaDoNauk.Items.Count > 0)
                btnGenerujPlik.Enabled = true;
            else btnGenerujPlik.Enabled = false;
        }
    }
}
