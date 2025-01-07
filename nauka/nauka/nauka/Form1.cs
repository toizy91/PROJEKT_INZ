namespace nauka
{
    public partial class oknoGlowne : Form
    {
        public oknoGlowne()
        {
            InitializeComponent();
        }

        private void oknoGlowne_Load(object sender, EventArgs e)
        {
            if(otworzPlikDial.ShowDialog() == DialogResult.OK)
            {
                string filename = otworzPlikDial.FileName;
                MessageBox.Show(filename);
                dsBaza1.ReadXml(filename);

            }
        }
    }
}
