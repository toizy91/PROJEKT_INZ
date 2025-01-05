namespace slownik
{
    partial class okno_glowne
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
            dsBaza1 = new dsBaza();
            panel1 = new Panel();
            txtWyszukaj = new TextBox();
            panel2 = new Panel();
            lbSlowa = new ListBox();
            panel3 = new Panel();
            btnZarzKat = new Button();
            btnZarzSlow = new Button();
            panel4 = new Panel();
            rbPlDe = new RadioButton();
            rbDePl = new RadioButton();
            rbPlEn = new RadioButton();
            rbEnPl = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtWyszukaj);
            panel1.Location = new Point(15, 199);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 71);
            panel1.TabIndex = 1;
            // 
            // txtWyszukaj
            // 
            txtWyszukaj.Location = new Point(20, 15);
            txtWyszukaj.Margin = new Padding(4);
            txtWyszukaj.Name = "txtWyszukaj";
            txtWyszukaj.Size = new Size(399, 31);
            txtWyszukaj.TabIndex = 0;
            txtWyszukaj.Text = "Wyszukaj słowo";
            txtWyszukaj.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbSlowa);
            panel2.Location = new Point(15, 278);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 437);
            panel2.TabIndex = 2;
            // 
            // lbSlowa
            // 
            lbSlowa.DataSource = dsBaza1;
            lbSlowa.DisplayMember = "TEn.wyraz";
            lbSlowa.FormattingEnabled = true;
            lbSlowa.ItemHeight = 25;
            lbSlowa.Location = new Point(20, 20);
            lbSlowa.Name = "lbSlowa";
            lbSlowa.Size = new Size(399, 379);
            lbSlowa.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnZarzKat);
            panel3.Controls.Add(btnZarzSlow);
            panel3.Location = new Point(15, 15);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 87);
            panel3.TabIndex = 3;
            // 
            // btnZarzKat
            // 
            btnZarzKat.ForeColor = Color.Blue;
            btnZarzKat.Location = new Point(218, 24);
            btnZarzKat.Margin = new Padding(4);
            btnZarzKat.Name = "btnZarzKat";
            btnZarzKat.Size = new Size(202, 36);
            btnZarzKat.TabIndex = 1;
            btnZarzKat.Text = "Kategorie..";
            btnZarzKat.UseVisualStyleBackColor = true;
            btnZarzKat.Click += btnZarzKat_Click;
            // 
            // btnZarzSlow
            // 
            btnZarzSlow.ForeColor = Color.Green;
            btnZarzSlow.Location = new Point(20, 24);
            btnZarzSlow.Margin = new Padding(4);
            btnZarzSlow.Name = "btnZarzSlow";
            btnZarzSlow.Size = new Size(171, 36);
            btnZarzSlow.TabIndex = 0;
            btnZarzSlow.Text = "Słowa..";
            btnZarzSlow.UseVisualStyleBackColor = true;
            btnZarzSlow.Click += btnZarzSlow_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(rbPlDe);
            panel4.Controls.Add(rbDePl);
            panel4.Controls.Add(rbPlEn);
            panel4.Controls.Add(rbEnPl);
            panel4.Location = new Point(15, 110);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(442, 81);
            panel4.TabIndex = 4;
            // 
            // rbPlDe
            // 
            rbPlDe.AutoSize = true;
            rbPlDe.Location = new Point(335, 25);
            rbPlDe.Margin = new Padding(4);
            rbPlDe.Name = "rbPlDe";
            rbPlDe.Size = new Size(94, 29);
            rbPlDe.TabIndex = 3;
            rbPlDe.Text = "PL - DE";
            rbPlDe.UseVisualStyleBackColor = true;
            rbPlDe.CheckedChanged += rbPlDe_CheckedChanged;
            // 
            // rbDePl
            // 
            rbDePl.AutoSize = true;
            rbDePl.Location = new Point(230, 25);
            rbDePl.Margin = new Padding(4);
            rbDePl.Name = "rbDePl";
            rbDePl.Size = new Size(94, 29);
            rbDePl.TabIndex = 2;
            rbDePl.Text = "DE - PL";
            rbDePl.UseVisualStyleBackColor = true;
            rbDePl.CheckedChanged += rbDePl_CheckedChanged;
            // 
            // rbPlEn
            // 
            rbPlEn.AutoSize = true;
            rbPlEn.Location = new Point(125, 25);
            rbPlEn.Margin = new Padding(4);
            rbPlEn.Name = "rbPlEn";
            rbPlEn.Size = new Size(94, 29);
            rbPlEn.TabIndex = 1;
            rbPlEn.Text = "PL - EN";
            rbPlEn.UseVisualStyleBackColor = true;
            rbPlEn.CheckedChanged += rbPlEn_CheckedChanged;
            // 
            // rbEnPl
            // 
            rbEnPl.AutoSize = true;
            rbEnPl.Checked = true;
            rbEnPl.Location = new Point(20, 25);
            rbEnPl.Margin = new Padding(4);
            rbEnPl.Name = "rbEnPl";
            rbEnPl.Size = new Size(94, 29);
            rbEnPl.TabIndex = 0;
            rbEnPl.TabStop = true;
            rbEnPl.Text = "EN - PL";
            rbEnPl.UseVisualStyleBackColor = true;
            rbEnPl.CheckedChanged += rbEnPl_CheckedChanged;
            // 
            // okno_glowne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 796);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "okno_glowne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "okno_gl_form";
            Load += okno_glowne_Load;
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtWyszukaj;
        private Panel panel2;
        private dsBaza dsBaza1;
        private Panel panel3;
        private Button btnZarzSlow;
        private Button btnZarzKat;
        private Panel panel4;
        private RadioButton rbPlEn;
        private RadioButton rbEnPl;
        private RadioButton rbPlDe;
        private RadioButton rbDePl;
        private ListBox lbSlowa;
    }
}
