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
        public DS_form_en()
        {
            InitializeComponent();
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
            dodajSlowoForm f = new dodajSlowoForm();
            f.ShowDialog(); 
        }
    }
}
