using System.Data;

namespace nauka
{
    public partial class oknoGlowne : Form
    {
        public oknoGlowne()
        {
            InitializeComponent();
        }

        int pytanieZ = 0;
        double wszystkiePytania = 0;
        string poprOdp = "";
        string wyraz = "";
        string rodzajnik = "";
        string zaimek = "";
        string przypadek = "";
        double procUkon = 0.0f;
        double krok = 0.0f;
        int poprOdpLicz = 0;

        int typ_pliku = 0; //xmla

        private void oknoGlowne_Load(object sender, EventArgs e)
        {
            if (otworzPlikDial.ShowDialog() == DialogResult.OK)
            {
                string filename = otworzPlikDial.FileName;
                if (filename.Contains("xmla"))
                {
                    dsBazaEn1.ReadXml(filename);
                    lbSlowa.DataSource = dsBazaEn1.TEn;
                    lbSlowa.DisplayMember = "znaczenie";
                    typ_pliku = 0;
                    cbRodzajnik.Enabled = false;
                    cbPrzypadek.Enabled = false;
                    cbZaimek.Enabled = false;
                    btnStart_Click(this, e);
                }
                else if (filename.Contains("xmln"))
                {
                    dsBazaDe1.ReadXml(filename);
                    lbSlowa.DataSource = dsBazaDe1.TDe;
                    lbSlowa.DisplayMember = "wyraz";
                    typ_pliku = 1;
                    cbRodzajnik.Enabled = true;
                    cbPrzypadek.Enabled = true;
                    cbZaimek.Enabled = true;
                    btnStartDe_Click(this, e);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lbSlowa.Items.Count > 0)
            {
                DataRowView drV = (DataRowView)lbSlowa.Items[pytanieZ];
                txtPytTres.Text = (drV.Row[1].ToString());
                wyraz = drV.Row[1].ToString();
                poprOdp = drV.Row[0].ToString();
                poprOdpLicz = 0;
                wszystkiePytania = System.Convert.ToInt32(lbSlowa.Items.Count);
                krok = Math.Round(100 / wszystkiePytania, 2);
                nastPyt();
            }
        }

        private void nastPytDe()
        {
            if (pytanieZ < lbSlowa.Items.Count)
            {
                DataRowView drV = (DataRowView)lbSlowa.Items[pytanieZ];
                wyraz = drV.Row[1].ToString();
                rodzajnik = drV.Row[2].ToString();
                zaimek = drV.Row[3].ToString();
                przypadek = drV.Row[4].ToString();
                poprOdp = drV.Row[0].ToString();
                poprOdp.Trim();
                MessageBox.Show(poprOdp);
                txtPytTres.Text = wyraz;
                txtOdp.Clear();
                pytanieZ++;
                txtOdp.Focus();
            }
            else
            {
                procUkon = 100;
                MessageBox.Show(this, "Ukoñczono naukê!", "Ucz siê s³ówek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wyraz = "";
                poprOdp = "";
                rodzajnik = "";
                zaimek = "";
                przypadek = "";
                txtOdp.Clear();
                txtPytTres.Clear();
                txtPytTres.Enabled = false;
                txtOdp.Enabled = false;
                timer1.Enabled = false;
                Application.Exit();
            }
        }
        private void nastPyt()
        {
            if (pytanieZ < lbSlowa.Items.Count)
            {
                DataRowView drV = (DataRowView)lbSlowa.Items[pytanieZ];
                wyraz = drV.Row[1].ToString();
                poprOdp = drV.Row[0].ToString();
                txtPytTres.Text = wyraz;
                txtOdp.Clear();
                pytanieZ++;
                txtOdp.Focus();
            }
            else
            {
                procUkon = 100;
                MessageBox.Show(this, "Ukoñczono naukê!", "Ucz siê s³ówek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wyraz = "";
                poprOdp = "";
                txtOdp.Clear();
                txtPytTres.Clear(); 
                txtPytTres.Enabled = false;
                txtOdp.Enabled = false;
                timer1.Enabled = false;
                Application.Exit();
            }
        }
        private void txtOdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOdp.Text.Trim() == poprOdp && typ_pliku == 0)
                {
                    panel2.BackColor = Color.LightGreen;
                    poprOdpLicz++;
                    procUkon += krok;
                    txtOdp.Clear();
                    nastPyt();
                }
                else if (typ_pliku == 0 && txtOdp.Text.Trim() != poprOdp)
                {
                    panel2.BackColor = Color.Red;
                    procUkon += krok;
                    txtOdp.Clear();
                    nastPyt();
                }
                else if (typ_pliku == 1 && txtOdp.Text.Trim() == poprOdp && cbRodzajnik.Text == rodzajnik && cbPrzypadek.Text == przypadek && cbZaimek.Text == zaimek)
                {
                    panel2.BackColor = Color.LightGreen;
                    poprOdpLicz++;
                    procUkon += krok;
                    txtOdp.Clear();
                    nastPytDe();
                }
                else if (typ_pliku == 1 && txtOdp.Text.Trim() != poprOdp || cbRodzajnik.Text != rodzajnik || cbZaimek.Text != zaimek || cbPrzypadek.Text != przypadek)
                {
                    panel2.BackColor = Color.Red;
                    procUkon += krok;
                    txtOdp.Clear();
                    nastPytDe();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labPyttz.Text = pytanieZ.ToString() + " z " + wszystkiePytania.ToString();
            labPoprOdp.Text = poprOdpLicz.ToString();
            labProcUkon.Text = procUkon.ToString() + "%";
        }

        private void btnStartDe_Click(object sender, EventArgs e)
        {
            if (lbSlowa.Items.Count > 0)
            {
                DataRowView drV = (DataRowView)lbSlowa.Items[pytanieZ];
                txtPytTres.Text = (drV.Row[1].ToString());
                wyraz = drV.Row[1].ToString();
                rodzajnik = drV.Row[2].ToString();
                zaimek = drV.Row[3].ToString();
                przypadek = drV.Row[4].ToString();
                poprOdp = drV.Row[0].ToString();
                poprOdp.Trim();
                MessageBox.Show(poprOdp);
                poprOdpLicz = 0;
                wszystkiePytania = System.Convert.ToInt32(lbSlowa.Items.Count);
                krok = Math.Round(100 / wszystkiePytania, 2);
                nastPyt();
            }
        }

        private void txtOdp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtOdp.Text += "ä";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
            if (e.KeyCode == Keys.F2)
            {
                txtOdp.Text += "Ä";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
            if(e.KeyCode == Keys.F3)
            {
                txtOdp.Text += "ß";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
            if(e.KeyCode == Keys.F4)
            {
                txtOdp.Text += "ö";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
            if(e.KeyCode== Keys.F5)
            {
                txtOdp.Text += "Ö";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
            if(e.KeyCode == Keys.F6)
            {
                txtOdp.Text += "ü";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
            if (e.KeyCode == Keys.F7)
            {
                txtOdp.Text += "Ü";
                txtOdp.SelectionStart = txtOdp.Text.Length;
                txtOdp.SelectionLength = 0;
            }
        }
    }
}
