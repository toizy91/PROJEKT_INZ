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
                DS_form_en f = new DS_form_en();
                f.ShowDialog();
            }
            else if (TYP_SLOWNIKA == 2 || TYP_SLOWNIKA == 3)
            {
                zarzSlowNiem f = new zarzSlowNiem();
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
        }

        private void rbPlEn_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 1;
        }

        private void rbDePl_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 2;
        }

        private void rbPlDe_CheckedChanged(object sender, EventArgs e)
        {
            TYP_SLOWNIKA = 3;
        }

        private void okno_glowne_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME_BASE))
            {
                dsBaza1.ReadXml(FILE_NAME_BASE);
            }
        }
    }
}
