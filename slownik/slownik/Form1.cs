using System.Data;

namespace slownik
{
    public partial class okno_glowne : Form
    {
        public okno_glowne()
        {
            InitializeComponent();
        }

        int TYP_SLOWNIKA = 0;
        const string FILE_NAME_BASE = "baza.xml";
        private void btnZarzSlow_Click(object sender, EventArgs e)
        {
            if (TYP_SLOWNIKA == 0 || TYP_SLOWNIKA == 1) //en
            {
                DS_form_en f = new DS_form_en(this);
                f.ShowDialog();
            }
            else if (TYP_SLOWNIKA == 2 || TYP_SLOWNIKA == 3)
            {
                zarzSlowNiem f = new zarzSlowNiem(this);
                f.ShowDialog();
            }
        }

        private void btnZarzKat_Click(object sender, EventArgs e)
        {
            DK_form f = new DK_form();
            f.ShowDialog();
        }

        private void rbEnPl_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 0;
            dsBaza1.Clear();
            if (File.Exists(FILE_NAME_BASE))
                dsBaza1.ReadXml(FILE_NAME_BASE);

            lbSlowa.DataSource = dsBaza1.TEn;
            lbSlowa.DisplayMember = "wyraz";
            lbSlowa.SelectedIndex = -1;
        }

        private void rbPlEn_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 1;
            dsBaza1.Clear();
            if (File.Exists(FILE_NAME_BASE))
                dsBaza1.ReadXml(FILE_NAME_BASE);

            lbSlowa.DataSource = dsBaza1.TEn;
            lbSlowa.DisplayMember = "znaczenie";
            lbSlowa.SelectedIndex = -1;
        }

        private void rbDePl_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 2;
            dsBaza1.Clear();
            if (File.Exists(FILE_NAME_BASE))
                dsBaza1.ReadXml(FILE_NAME_BASE);

            lbSlowa.DataSource = dsBaza1.TDe;
            lbSlowa.DisplayMember = "wyraz";
            lbSlowa.SelectedIndex = -1;
        }

        private void rbPlDe_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 3;
            dsBaza1.Clear();
            if (File.Exists(FILE_NAME_BASE))
                dsBaza1.ReadXml(FILE_NAME_BASE);

            lbSlowa.DataSource = dsBaza1.TDe;
            lbSlowa.DisplayMember = "znaczenie";
            lbSlowa.SelectedIndex = -1;
        }

        private void okno_glowne_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }

        private void txtWyszukaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtWyszukaj.Text += "�";
                txtWyszukaj.Focus();
                txtWyszukaj.SelectionStart = txtWyszukaj.Text.Length;
                txtWyszukaj.SelectionLength = 0;
            }
            else
            if (e.KeyCode == Keys.F2)
            {
                txtWyszukaj.Text += "�";
                txtWyszukaj.Focus();
                txtWyszukaj.SelectionStart = txtWyszukaj.Text.Length;
                txtWyszukaj.SelectionLength = 0;
            }
            else
            if (e.KeyCode == Keys.F3)
            {
                txtWyszukaj.Text += "�";
                txtWyszukaj.Focus();
                txtWyszukaj.SelectionStart = txtWyszukaj.Text.Length;
                txtWyszukaj.SelectionLength = 0;
            }
            else
            if (e.KeyCode == Keys.F4)
            {
                txtWyszukaj.Text += "�";
                txtWyszukaj.Focus();
                txtWyszukaj.SelectionStart = txtWyszukaj.Text.Length;
                txtWyszukaj.SelectionLength = 0;
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

        private void lbSlowa_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxOpis.Clear();
            if (lbSlowa.SelectedIndex > -1)
            {
                if (TYP_SLOWNIKA == 0) //en - pl
                {
                    DataRowView drV = (DataRowView)lbSlowa.SelectedItem;
                    rtxOpis.Lines = new string[]
                    {
                        "S�owo: "+ drV.Row[0].ToString()+"\n"+
                        "T�umaczenie: "+drV.Row[1].ToString()+"\n"+
                        "Typ s�owa: "+drV.Row[2].ToString()+"\n"+
                        "Kategoria: "+drV.Row[3].ToString()
                };
                }
                else
                if (TYP_SLOWNIKA == 1) //pl - en
                {
                    DataRowView drV = (DataRowView)lbSlowa.SelectedItem;
                    rtxOpis.Lines = new string[]
                    {
                        "S�owo: "+ drV.Row[1].ToString()+"\n"+
                        "T�umaczenie: "+drV.Row[0].ToString()+"\n"+
                        "Typ s�owa: "+drV.Row[2].ToString()+"\n"+
                        "Kategoria: "+drV.Row[3].ToString()
                };
                }
                else
            if (TYP_SLOWNIKA == 2) //de - pl
                {
                    DataRowView drV = (DataRowView)lbSlowa.SelectedItem;
                    rtxOpis.Lines = new string[]
                    {
                        "S�owo: "+drV.Row[4].ToString() +" "+ drV.Row[0].ToString()+"\n"+
                        "Zaimek: "+drV.Row[5].ToString()+" "+
                         drV.Row[6].ToString()+"\n"+
                        "T�umaczenie: "+drV.Row[1].ToString()+"\n"+
                        "Typ s�owa: "+drV.Row[2].ToString()+"\n"+
                        "Kategoria: "+drV.Row[3].ToString()
                };
                }
                else
            if (TYP_SLOWNIKA == 3) //pl - de
                {
                    DataRowView drV = (DataRowView)lbSlowa.SelectedItem;
                    rtxOpis.Lines = new string[]
                    {
                        "S�owo: "+ drV.Row[1].ToString()+"\n"+
                        "Zaimek: "+drV.Row[5].ToString()+"\n"+
                         "Przypadek: "+drV.Row[6].ToString()+"\n"+
                        "T�umaczenie: "+drV.Row[4].ToString()+" "+drV.Row[0].ToString()+"\n"+
                        "Typ s�owa: "+drV.Row[2].ToString()+"\n"+
                        "Kategoria: "+drV.Row[3].ToString()
                };
                }
            }
        }

        private void txtWyszukaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = lbSlowa.FindString(txtWyszukaj.Text);
            if (i >= 0)
            {
                lbSlowa.SelectedIndex = i;
            }
            else
            {
                lbSlowa.SelectedIndex = -1;
            }
        }

        private void btnNauka_Click(object sender, EventArgs e)
        {
            nakaForm f = new nakaForm();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsElemeNaList.Text = "Element�w: " + lbSlowa.Items.Count.ToString();
        }
    }
}
