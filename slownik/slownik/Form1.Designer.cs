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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            panel5 = new Panel();
            rtxOpis = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtWyszukaj);
            panel1.Location = new Point(12, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 57);
            panel1.TabIndex = 1;
            // 
            // txtWyszukaj
            // 
            txtWyszukaj.Location = new Point(16, 12);
            txtWyszukaj.Name = "txtWyszukaj";
            txtWyszukaj.Size = new Size(320, 27);
            txtWyszukaj.TabIndex = 0;
            txtWyszukaj.Text = "Wyszukaj słowo";
            txtWyszukaj.TextAlign = HorizontalAlignment.Center;
            txtWyszukaj.KeyDown += txtWyszukaj_KeyDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbSlowa);
            panel2.Location = new Point(12, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 350);
            panel2.TabIndex = 2;
            // 
            // lbSlowa
            // 
            lbSlowa.BackColor = SystemColors.Info;
            lbSlowa.DataSource = dsBaza1;
            lbSlowa.DisplayMember = "TEn.wyraz";
            lbSlowa.FormattingEnabled = true;
            lbSlowa.Location = new Point(16, 16);
            lbSlowa.Margin = new Padding(2);
            lbSlowa.Name = "lbSlowa";
            lbSlowa.Size = new Size(320, 304);
            lbSlowa.Sorted = true;
            lbSlowa.TabIndex = 0;
            lbSlowa.SelectedIndexChanged += lbSlowa_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnZarzKat);
            panel3.Controls.Add(btnZarzSlow);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 70);
            panel3.TabIndex = 3;
            // 
            // btnZarzKat
            // 
            btnZarzKat.ForeColor = Color.Blue;
            btnZarzKat.Location = new Point(174, 19);
            btnZarzKat.Name = "btnZarzKat";
            btnZarzKat.Size = new Size(162, 29);
            btnZarzKat.TabIndex = 1;
            btnZarzKat.Text = "Kategorie..";
            btnZarzKat.UseVisualStyleBackColor = true;
            btnZarzKat.Click += btnZarzKat_Click;
            // 
            // btnZarzSlow
            // 
            btnZarzSlow.ForeColor = Color.Green;
            btnZarzSlow.Location = new Point(16, 19);
            btnZarzSlow.Name = "btnZarzSlow";
            btnZarzSlow.Size = new Size(137, 29);
            btnZarzSlow.TabIndex = 0;
            btnZarzSlow.Text = "Słowa..";
            btnZarzSlow.UseVisualStyleBackColor = true;
            btnZarzSlow.Click += btnZarzSlow_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(rbPlDe);
            panel4.Controls.Add(rbDePl);
            panel4.Controls.Add(rbPlEn);
            panel4.Controls.Add(rbEnPl);
            panel4.Location = new Point(12, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 65);
            panel4.TabIndex = 4;
            // 
            // rbPlDe
            // 
            rbPlDe.AutoSize = true;
            rbPlDe.Location = new Point(268, 20);
            rbPlDe.Name = "rbPlDe";
            rbPlDe.Size = new Size(78, 24);
            rbPlDe.TabIndex = 3;
            rbPlDe.Text = "PL - DE";
            rbPlDe.UseVisualStyleBackColor = true;
            rbPlDe.CheckedChanged += rbPlDe_CheckedChanged;
            // 
            // rbDePl
            // 
            rbDePl.AutoSize = true;
            rbDePl.Location = new Point(184, 20);
            rbDePl.Name = "rbDePl";
            rbDePl.Size = new Size(78, 24);
            rbDePl.TabIndex = 2;
            rbDePl.Text = "DE - PL";
            rbDePl.UseVisualStyleBackColor = true;
            rbDePl.CheckedChanged += rbDePl_CheckedChanged;
            // 
            // rbPlEn
            // 
            rbPlEn.AutoSize = true;
            rbPlEn.Location = new Point(100, 20);
            rbPlEn.Name = "rbPlEn";
            rbPlEn.Size = new Size(78, 24);
            rbPlEn.TabIndex = 1;
            rbPlEn.Text = "PL - EN";
            rbPlEn.UseVisualStyleBackColor = true;
            rbPlEn.CheckedChanged += rbPlEn_CheckedChanged;
            // 
            // rbEnPl
            // 
            rbEnPl.AutoSize = true;
            rbEnPl.Checked = true;
            rbEnPl.Location = new Point(16, 20);
            rbEnPl.Name = "rbEnPl";
            rbEnPl.Size = new Size(78, 24);
            rbEnPl.TabIndex = 0;
            rbEnPl.TabStop = true;
            rbEnPl.Text = "EN - PL";
            rbEnPl.UseVisualStyleBackColor = true;
            rbEnPl.CheckedChanged += rbEnPl_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel5, toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 767);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(379, 30);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.BackColor = Color.White;
            toolStripStatusLabel5.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(159, 24);
            toolStripStatusLabel5.Text = "Elementów na liście: 0";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 24);
            toolStripStatusLabel1.Text = "F1 = ä";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BackColor = Color.White;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(50, 24);
            toolStripStatusLabel2.Text = "F2 = ß";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BackColor = Color.White;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(51, 24);
            toolStripStatusLabel3.Text = "F3 = ö";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BackColor = Color.White;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(54, 24);
            toolStripStatusLabel4.Text = "F4 = ü";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(rtxOpis);
            panel5.Location = new Point(12, 578);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 170);
            panel5.TabIndex = 7;
            // 
            // rtxOpis
            // 
            rtxOpis.BackColor = Color.FromArgb(192, 192, 255);
            rtxOpis.BorderStyle = BorderStyle.None;
            rtxOpis.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rtxOpis.ForeColor = Color.Red;
            rtxOpis.Location = new Point(16, 18);
            rtxOpis.Name = "rtxOpis";
            rtxOpis.ReadOnly = true;
            rtxOpis.Size = new Size(320, 131);
            rtxOpis.TabIndex = 7;
            rtxOpis.Text = "";
            // 
            // okno_glowne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(379, 797);
            Controls.Add(panel5);
            Controls.Add(statusStrip1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private Panel panel5;
        private RichTextBox rtxOpis;
    }
}
