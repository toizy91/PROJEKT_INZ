namespace nauka
{
    partial class oknoGlowne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            otworzPlikDial = new OpenFileDialog();
            dsBaza1 = new dsBaza();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            SuspendLayout();
            // 
            // otworzPlikDial
            // 
            otworzPlikDial.DefaultExt = "xml";
            otworzPlikDial.FileName = "slowa.xml";
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            listBox1.DataSource = dsBaza1;
            listBox1.DisplayMember = "TEn.wyraz";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(61, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 224);
            listBox1.TabIndex = 0;
            // 
            // oknoGlowne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Name = "oknoGlowne";
            Text = "Ucz się słówek";
            Load += oknoGlowne_Load;
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog otworzPlikDial;
        private dsBaza dsBaza1;
        private ListBox listBox1;
    }
}
