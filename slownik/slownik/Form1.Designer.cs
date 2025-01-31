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
            components = new System.ComponentModel.Container();
            dsBaza1 = new dsBaza();
            panel1 = new Panel();
            txtWyszukaj = new TextBox();
            panel2 = new Panel();
            btnNauka = new Button();
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
            tsElemeNaList = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            panel5 = new Panel();
            rtxOpis = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
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
            txtWyszukaj.TextAlign = HorizontalAlignment.Center;
            txtWyszukaj.KeyDown += txtWyszukaj_KeyDown;
            txtWyszukaj.KeyPress += txtWyszukaj_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnNauka);
            panel2.Controls.Add(lbSlowa);
            panel2.Location = new Point(15, 278);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 437);
            panel2.TabIndex = 2;
            // 
            // btnNauka
            // 
            btnNauka.ForeColor = Color.Purple;
            btnNauka.Location = new Point(20, 383);
            btnNauka.Name = "btnNauka";
            btnNauka.Size = new Size(399, 34);
            btnNauka.TabIndex = 1;
            btnNauka.Text = "Nauka słów..";
            btnNauka.UseVisualStyleBackColor = true;
            btnNauka.Click += btnNauka_Click;
            // 
            // lbSlowa
            // 
            lbSlowa.BackColor = SystemColors.Info;
            lbSlowa.DataSource = dsBaza1;
            lbSlowa.DisplayMember = "TEn.wyraz";
            lbSlowa.FormattingEnabled = true;
            lbSlowa.ItemHeight = 25;
            lbSlowa.Location = new Point(20, 20);
            lbSlowa.Margin = new Padding(2);
            lbSlowa.Name = "lbSlowa";
            lbSlowa.Size = new Size(399, 329);
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
            panel4.BackColor = Color.White;
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsElemeNaList, toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 1002);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(469, 36);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsElemeNaList
            // 
            tsElemeNaList.BackColor = Color.White;
            tsElemeNaList.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsElemeNaList.Name = "tsElemeNaList";
            tsElemeNaList.Size = new Size(188, 29);
            tsElemeNaList.Text = "Elementów na liście: 0";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(62, 29);
            toolStripStatusLabel1.Text = "F1 = ä";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BackColor = Color.White;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(63, 29);
            toolStripStatusLabel2.Text = "F2 = ß";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BackColor = Color.White;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(64, 29);
            toolStripStatusLabel3.Text = "F3 = ö";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BackColor = Color.White;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(67, 29);
            toolStripStatusLabel4.Text = "F4 = ü";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(rtxOpis);
            panel5.Location = new Point(15, 722);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(442, 271);
            panel5.TabIndex = 7;
            // 
            // rtxOpis
            // 
            rtxOpis.BackColor = Color.White;
            rtxOpis.BorderStyle = BorderStyle.None;
            rtxOpis.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rtxOpis.ForeColor = Color.FromArgb(192, 0, 192);
            rtxOpis.Location = new Point(20, 22);
            rtxOpis.Margin = new Padding(4);
            rtxOpis.Name = "rtxOpis";
            rtxOpis.ReadOnly = true;
            rtxOpis.Size = new Size(400, 225);
            rtxOpis.TabIndex = 7;
            rtxOpis.Text = "";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // okno_glowne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(469, 1038);
            Controls.Add(panel5);
            Controls.Add(statusStrip1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(491, 1094);
            MinimumSize = new Size(491, 1094);
            Name = "okno_glowne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Słownik języka angielskiego i niemieckiego";
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
        private ToolStripStatusLabel tsElemeNaList;
        private Panel panel5;
        private RichTextBox rtxOpis;
        private Button btnNauka;
        private System.Windows.Forms.Timer timer1;
    }
}
