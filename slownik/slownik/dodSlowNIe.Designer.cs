namespace slownik
{
    partial class dodSlowNIe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cbTypSlowa = new ComboBox();
            label1 = new Label();
            panOgoln = new Panel();
            btnZamknij = new Button();
            btnCzysc = new Button();
            btnDodajSlowo = new Button();
            cbKategoria = new ComboBox();
            dsBaza1 = new dsBaza();
            label6 = new Label();
            cbPrzypadek = new ComboBox();
            cbZaimek = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtZnaczenie = new TextBox();
            txtWyraz = new TextBox();
            cbRodzajnik = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panOgoln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbTypSlowa);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 56);
            panel1.TabIndex = 0;
            // 
            // cbTypSlowa
            // 
            cbTypSlowa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypSlowa.FormattingEnabled = true;
            cbTypSlowa.Items.AddRange(new object[] { "czasownik", "rekcja czasownika", "przymiotnik", "rekcja przymiotnika", "rzeczownik", "rekcja rzeczownika", "zwrot", "inne" });
            cbTypSlowa.Location = new Point(185, 14);
            cbTypSlowa.Margin = new Padding(2);
            cbTypSlowa.Name = "cbTypSlowa";
            cbTypSlowa.Size = new Size(332, 28);
            cbTypSlowa.TabIndex = 1;
            cbTypSlowa.SelectedIndexChanged += cbTypSlowa_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Wybierz rodzaj  słowa:";
            // 
            // panOgoln
            // 
            panOgoln.BackColor = Color.White;
            panOgoln.BorderStyle = BorderStyle.FixedSingle;
            panOgoln.Controls.Add(btnZamknij);
            panOgoln.Controls.Add(btnCzysc);
            panOgoln.Controls.Add(btnDodajSlowo);
            panOgoln.Controls.Add(cbKategoria);
            panOgoln.Controls.Add(label6);
            panOgoln.Controls.Add(cbPrzypadek);
            panOgoln.Controls.Add(cbZaimek);
            panOgoln.Controls.Add(label5);
            panOgoln.Controls.Add(label4);
            panOgoln.Controls.Add(txtZnaczenie);
            panOgoln.Controls.Add(txtWyraz);
            panOgoln.Controls.Add(cbRodzajnik);
            panOgoln.Controls.Add(label3);
            panOgoln.Controls.Add(label2);
            panOgoln.ForeColor = Color.Black;
            panOgoln.Location = new Point(10, 80);
            panOgoln.Margin = new Padding(2);
            panOgoln.Name = "panOgoln";
            panOgoln.Size = new Size(540, 244);
            panOgoln.TabIndex = 1;
            panOgoln.Visible = false;
            // 
            // btnZamknij
            // 
            btnZamknij.ForeColor = Color.Blue;
            btnZamknij.Location = new Point(426, 206);
            btnZamknij.Margin = new Padding(2);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(90, 27);
            btnZamknij.TabIndex = 13;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // btnCzysc
            // 
            btnCzysc.ForeColor = Color.Red;
            btnCzysc.Location = new Point(293, 174);
            btnCzysc.Margin = new Padding(2);
            btnCzysc.Name = "btnCzysc";
            btnCzysc.Size = new Size(94, 27);
            btnCzysc.TabIndex = 12;
            btnCzysc.Text = "Czyść pola";
            btnCzysc.UseVisualStyleBackColor = true;
            btnCzysc.Click += btnCzysc_Click;
            // 
            // btnDodajSlowo
            // 
            btnDodajSlowo.ForeColor = Color.FromArgb(0, 192, 0);
            btnDodajSlowo.Location = new Point(392, 174);
            btnDodajSlowo.Margin = new Padding(2);
            btnDodajSlowo.Name = "btnDodajSlowo";
            btnDodajSlowo.Size = new Size(124, 27);
            btnDodajSlowo.TabIndex = 11;
            btnDodajSlowo.Text = "Dodaj słowo";
            btnDodajSlowo.UseVisualStyleBackColor = true;
            btnDodajSlowo.Click += btnDodajSlowo_Click;
            // 
            // cbKategoria
            // 
            cbKategoria.DataSource = dsBaza1;
            cbKategoria.DisplayMember = "TKategorie.kategoria";
            cbKategoria.FormattingEnabled = true;
            cbKategoria.Location = new Point(177, 126);
            cbKategoria.Margin = new Padding(2);
            cbKategoria.Name = "cbKategoria";
            cbKategoria.Size = new Size(340, 28);
            cbKategoria.TabIndex = 10;
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 128);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 9;
            label6.Text = "Kategoria:";
            // 
            // cbPrzypadek
            // 
            cbPrzypadek.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrzypadek.FormattingEnabled = true;
            cbPrzypadek.Items.AddRange(new object[] { "Nom.", "Gen.", "Dat.", "Akk." });
            cbPrzypadek.Location = new Point(260, 52);
            cbPrzypadek.Margin = new Padding(2);
            cbPrzypadek.Name = "cbPrzypadek";
            cbPrzypadek.Size = new Size(82, 28);
            cbPrzypadek.TabIndex = 8;
            // 
            // cbZaimek
            // 
            cbZaimek.DropDownStyle = ComboBoxStyle.DropDownList;
            cbZaimek.FormattingEnabled = true;
            cbZaimek.Items.AddRange(new object[] { "an", "auf", "aus", "bei", "für", "gegen", "in", "mit", "nach", "von", "unter", "über", "um", "vor", "zu" });
            cbZaimek.Location = new Point(79, 52);
            cbZaimek.Margin = new Padding(2);
            cbZaimek.Name = "cbZaimek";
            cbZaimek.Size = new Size(82, 28);
            cbZaimek.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 54);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 6;
            label5.Text = "Przypadek:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 54);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 5;
            label4.Text = "Zaimek:";
            // 
            // txtZnaczenie
            // 
            txtZnaczenie.Location = new Point(177, 89);
            txtZnaczenie.Margin = new Padding(2);
            txtZnaczenie.Name = "txtZnaczenie";
            txtZnaczenie.Size = new Size(340, 27);
            txtZnaczenie.TabIndex = 4;
            txtZnaczenie.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWyraz
            // 
            txtWyraz.Location = new Point(236, 15);
            txtWyraz.Margin = new Padding(2);
            txtWyraz.Name = "txtWyraz";
            txtWyraz.Size = new Size(281, 27);
            txtWyraz.TabIndex = 3;
            txtWyraz.TextAlign = HorizontalAlignment.Center;
            txtWyraz.KeyDown += txtWyraz_KeyDown;
            // 
            // cbRodzajnik
            // 
            cbRodzajnik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajnik.FormattingEnabled = true;
            cbRodzajnik.Items.AddRange(new object[] { "der", "die", "das" });
            cbRodzajnik.Location = new Point(177, 13);
            cbRodzajnik.Margin = new Padding(2);
            cbRodzajnik.Name = "cbRodzajnik";
            cbRodzajnik.Size = new Size(55, 28);
            cbRodzajnik.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 1;
            label3.Text = "Tłumaczenie polskie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Słowo niemieckie:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 337);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(562, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 20);
            toolStripStatusLabel1.Text = "F1 = ä";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BackColor = Color.White;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(50, 20);
            toolStripStatusLabel2.Text = "F2 = ß";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BackColor = Color.White;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(51, 20);
            toolStripStatusLabel3.Text = "F3 = ö";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BackColor = Color.White;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(50, 20);
            toolStripStatusLabel4.Text = "F4 = ü";
            // 
            // dodSlowNIe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(562, 363);
            Controls.Add(statusStrip1);
            Controls.Add(panOgoln);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(580, 410);
            MinimizeBox = false;
            MinimumSize = new Size(580, 410);
            Name = "dodSlowNIe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj słowo niemieckie";
            FormClosed += dodSlowNIe_FormClosed;
            Load += dodSlowNIe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panOgoln.ResumeLayout(false);
            panOgoln.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cbTypSlowa;
        private Label label1;
        private Panel panOgoln;
        private Label label2;
        private ComboBox cbZaimek;
        private Label label5;
        private Label label4;
        private TextBox txtZnaczenie;
        private TextBox txtWyraz;
        private ComboBox cbRodzajnik;
        private Label label3;
        private ComboBox cbPrzypadek;
        private ComboBox cbKategoria;
        private Label label6;
        private Button btnZamknij;
        private Button btnCzysc;
        private Button btnDodajSlowo;
        private dsBaza dsBaza1;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
    }
}