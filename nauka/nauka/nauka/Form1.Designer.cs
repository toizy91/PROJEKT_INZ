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
            components = new System.ComponentModel.Container();
            otworzPlikDial = new OpenFileDialog();
            dsBaza1 = new dsBaza();
            lbSlowa = new ListBox();
            dsBazaEn1 = new dsBazaEn();
            dsBazaDe1 = new dsBazaDe();
            label1 = new Label();
            label2 = new Label();
            txtOdp = new TextBox();
            panel1 = new Panel();
            labPyttz = new Label();
            label6 = new Label();
            panel2 = new Panel();
            labPoprOdp = new Label();
            label7 = new Label();
            panel3 = new Panel();
            labProcUkon = new Label();
            label3 = new Label();
            txtPytTres = new TextBox();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStartDe = new Button();
            cbRodzajnik = new ComboBox();
            cbZaimek = new ComboBox();
            cbPrzypadek = new ComboBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            toolStripStatusLabel7 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaEn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaDe1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // otworzPlikDial
            // 
            otworzPlikDial.AddExtension = false;
            otworzPlikDial.DefaultExt = "xml";
            otworzPlikDial.Filter = "Język angieslki (*.xmla) |*.xmla| Język niemiecki (*.xmln) |*xmln";
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSlowa
            // 
            lbSlowa.DataSource = dsBaza1;
            lbSlowa.DisplayMember = "TEn.wyraz";
            lbSlowa.FormattingEnabled = true;
            lbSlowa.ItemHeight = 32;
            lbSlowa.Location = new Point(105, 623);
            lbSlowa.Margin = new Padding(5);
            lbSlowa.Name = "lbSlowa";
            lbSlowa.Size = new Size(512, 356);
            lbSlowa.TabIndex = 0;
            // 
            // dsBazaEn1
            // 
            dsBazaEn1.DataSetName = "dsBazaEn";
            dsBazaEn1.Namespace = "http://tempuri.org/dsBazaEn.xsd";
            dsBazaEn1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBazaDe1
            // 
            dsBazaDe1.DataSetName = "dsBazaDe";
            dsBazaDe1.Namespace = "http://tempuri.org/dsBazaDe.xsd";
            dsBazaDe1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(505, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 48);
            label1.TabIndex = 1;
            label1.Text = "Przetłumacz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(464, 165);
            label2.Name = "label2";
            label2.Size = new Size(304, 48);
            label2.TabIndex = 3;
            label2.Text = "Twoja odpowiedź:";
            // 
            // txtOdp
            // 
            txtOdp.BackColor = SystemColors.Control;
            txtOdp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtOdp.ForeColor = Color.FromArgb(64, 0, 64);
            txtOdp.Location = new Point(236, 239);
            txtOdp.Name = "txtOdp";
            txtOdp.Size = new Size(629, 55);
            txtOdp.TabIndex = 4;
            txtOdp.TextAlign = HorizontalAlignment.Center;
            txtOdp.KeyDown += txtOdp_KeyDown;
            txtOdp.KeyUp += txtOdp_KeyUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labPyttz);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(75, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 117);
            panel1.TabIndex = 5;
            // 
            // labPyttz
            // 
            labPyttz.AutoSize = true;
            labPyttz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labPyttz.ForeColor = Color.Red;
            labPyttz.Location = new Point(160, 33);
            labPyttz.Name = "labPyttz";
            labPyttz.Size = new Size(113, 48);
            labPyttz.TabIndex = 1;
            labPyttz.Text = "1 z 50";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(29, 33);
            label6.Name = "label6";
            label6.Size = new Size(143, 48);
            label6.TabIndex = 0;
            label6.Text = "Pytanie:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labPoprOdp);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(391, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 117);
            panel2.TabIndex = 6;
            // 
            // labPoprOdp
            // 
            labPoprOdp.AutoSize = true;
            labPoprOdp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labPoprOdp.ForeColor = Color.Yellow;
            labPoprOdp.Location = new Point(383, 33);
            labPoprOdp.Name = "labPoprOdp";
            labPoprOdp.Size = new Size(58, 48);
            labPoprOdp.TabIndex = 1;
            labPoprOdp.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(17, 33);
            label7.Name = "label7";
            label7.Size = new Size(379, 48);
            label7.TabIndex = 0;
            label7.Text = "Poprawne odpowiedzi:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labProcUkon);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(884, 313);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 117);
            panel3.TabIndex = 7;
            // 
            // labProcUkon
            // 
            labProcUkon.AutoSize = true;
            labProcUkon.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labProcUkon.ForeColor = Color.Red;
            labProcUkon.Location = new Point(210, 33);
            labProcUkon.Name = "labProcUkon";
            labProcUkon.Size = new Size(106, 48);
            labProcUkon.TabIndex = 1;
            labProcUkon.Text = "100%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(207, 48);
            label3.TabIndex = 0;
            label3.Text = "Ukończono:";
            // 
            // txtPytTres
            // 
            txtPytTres.BackColor = SystemColors.Control;
            txtPytTres.BorderStyle = BorderStyle.None;
            txtPytTres.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPytTres.ForeColor = Color.FromArgb(64, 0, 64);
            txtPytTres.Location = new Point(150, 114);
            txtPytTres.Name = "txtPytTres";
            txtPytTres.ReadOnly = true;
            txtPytTres.Size = new Size(946, 48);
            txtPytTres.TabIndex = 8;
            txtPytTres.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(721, 623);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 46);
            btnStart.TabIndex = 9;
            btnStart.Text = "start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnStartDe
            // 
            btnStartDe.Location = new Point(798, 766);
            btnStartDe.Name = "btnStartDe";
            btnStartDe.Size = new Size(112, 43);
            btnStartDe.TabIndex = 10;
            btnStartDe.Text = "startDe";
            btnStartDe.UseVisualStyleBackColor = true;
            btnStartDe.Click += btnStartDe_Click;
            // 
            // cbRodzajnik
            // 
            cbRodzajnik.BackColor = SystemColors.Control;
            cbRodzajnik.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbRodzajnik.FormattingEnabled = true;
            cbRodzajnik.Items.AddRange(new object[] { "", "der", "die", "das" });
            cbRodzajnik.Location = new Point(105, 239);
            cbRodzajnik.Name = "cbRodzajnik";
            cbRodzajnik.Size = new Size(125, 56);
            cbRodzajnik.TabIndex = 11;
            // 
            // cbZaimek
            // 
            cbZaimek.BackColor = SystemColors.Control;
            cbZaimek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbZaimek.FormattingEnabled = true;
            cbZaimek.Items.AddRange(new object[] { "", "an", "auf", "aus", "bei", "für", "gegen", "in", "mit", "nach", "von", "unter", "über", "um", "vor", "zu" });
            cbZaimek.Location = new Point(871, 239);
            cbZaimek.Name = "cbZaimek";
            cbZaimek.Size = new Size(157, 56);
            cbZaimek.TabIndex = 12;
            // 
            // cbPrzypadek
            // 
            cbPrzypadek.BackColor = SystemColors.Control;
            cbPrzypadek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbPrzypadek.FormattingEnabled = true;
            cbPrzypadek.Items.AddRange(new object[] { "", "Nom.", "Gen.", "Dat.", "Akk." });
            cbPrzypadek.Location = new Point(1059, 239);
            cbPrzypadek.Name = "cbPrzypadek";
            cbPrzypadek.Size = new Size(150, 56);
            cbPrzypadek.TabIndex = 13;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5, toolStripStatusLabel6, toolStripStatusLabel7 });
            statusStrip1.Location = new Point(0, 486);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1290, 32);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(62, 25);
            toolStripStatusLabel1.Text = "F1 = ä";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(65, 25);
            toolStripStatusLabel2.Text = "F2 = Ä";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(63, 25);
            toolStripStatusLabel3.Text = "F3 = ß";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(64, 25);
            toolStripStatusLabel4.Text = "F4 = ö";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(67, 25);
            toolStripStatusLabel5.Text = "F5 = Ö";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(63, 25);
            toolStripStatusLabel6.Text = "F6 = ü";
            // 
            // toolStripStatusLabel7
            // 
            toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            toolStripStatusLabel7.Size = new Size(65, 25);
            toolStripStatusLabel7.Text = "F7 = Ü";
            // 
            // oknoGlowne
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1290, 518);
            Controls.Add(statusStrip1);
            Controls.Add(cbPrzypadek);
            Controls.Add(cbZaimek);
            Controls.Add(cbRodzajnik);
            Controls.Add(btnStartDe);
            Controls.Add(btnStart);
            Controls.Add(txtPytTres);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtOdp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbSlowa);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "oknoGlowne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ucz się słówek";
            Load += oknoGlowne_Load;
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaEn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaDe1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog otworzPlikDial;
        private dsBaza dsBaza1;
        private ListBox lbSlowa;
        private dsBazaEn dsBazaEn1;
        private dsBazaDe dsBazaDe1;
        private Label label1;
        private Label label2;
        private TextBox txtOdp;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Label labPyttz;
        private Panel panel3;
        private Label labProcUkon;
        private Label label3;
        private TextBox txtPytTres;
        private Label labPoprOdp;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Button btnStartDe;
        private ComboBox cbRodzajnik;
        private ComboBox cbZaimek;
        private ComboBox cbPrzypadek;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
    }
}
