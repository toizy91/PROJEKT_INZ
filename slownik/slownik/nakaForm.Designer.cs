namespace slownik
{
    partial class nakaForm
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
            btnZamknij = new Button();
            btnGenerujPlik = new Button();
            btnUsunZNauka = new Button();
            btnDodajDoNauka = new Button();
            lbSlowaDoNauk = new ListBox();
            lbSlowaWY = new ListBox();
            cbJezyk = new ComboBox();
            label1 = new Label();
            dsBaza1 = new dsBaza();
            dsBazaDe1 = new dsBazaDe();
            dsBazaEn1 = new dsBazaEn();
            zapiszPlikDial = new SaveFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaDe1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaEn1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnZamknij);
            panel1.Controls.Add(btnGenerujPlik);
            panel1.Controls.Add(btnUsunZNauka);
            panel1.Controls.Add(btnDodajDoNauka);
            panel1.Controls.Add(lbSlowaDoNauk);
            panel1.Controls.Add(lbSlowaWY);
            panel1.Controls.Add(cbJezyk);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 510);
            panel1.TabIndex = 0;
            // 
            // btnZamknij
            // 
            btnZamknij.Location = new Point(601, 453);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(112, 34);
            btnZamknij.TabIndex = 7;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // btnGenerujPlik
            // 
            btnGenerujPlik.Location = new Point(443, 413);
            btnGenerujPlik.Name = "btnGenerujPlik";
            btnGenerujPlik.Size = new Size(270, 34);
            btnGenerujPlik.TabIndex = 6;
            btnGenerujPlik.Text = "Generuj plik nauki";
            btnGenerujPlik.UseVisualStyleBackColor = true;
            btnGenerujPlik.Click += btnGenerujPlik_Click;
            // 
            // btnUsunZNauka
            // 
            btnUsunZNauka.ForeColor = Color.Red;
            btnUsunZNauka.Location = new Point(314, 144);
            btnUsunZNauka.Name = "btnUsunZNauka";
            btnUsunZNauka.Size = new Size(112, 34);
            btnUsunZNauka.TabIndex = 5;
            btnUsunZNauka.Text = "Usuń";
            btnUsunZNauka.UseVisualStyleBackColor = true;
            btnUsunZNauka.Click += btnUsunZNauka_Click;
            // 
            // btnDodajDoNauka
            // 
            btnDodajDoNauka.ForeColor = Color.FromArgb(0, 192, 0);
            btnDodajDoNauka.Location = new Point(314, 104);
            btnDodajDoNauka.Name = "btnDodajDoNauka";
            btnDodajDoNauka.Size = new Size(112, 34);
            btnDodajDoNauka.TabIndex = 4;
            btnDodajDoNauka.Text = ">>>";
            btnDodajDoNauka.UseVisualStyleBackColor = true;
            btnDodajDoNauka.Click += btnDodajDoNauka_Click;
            // 
            // lbSlowaDoNauk
            // 
            lbSlowaDoNauk.FormattingEnabled = true;
            lbSlowaDoNauk.ItemHeight = 25;
            lbSlowaDoNauk.Location = new Point(430, 91);
            lbSlowaDoNauk.Name = "lbSlowaDoNauk";
            lbSlowaDoNauk.Size = new Size(283, 279);
            lbSlowaDoNauk.TabIndex = 3;
            // 
            // lbSlowaWY
            // 
            lbSlowaWY.FormattingEnabled = true;
            lbSlowaWY.ItemHeight = 25;
            lbSlowaWY.Location = new Point(25, 91);
            lbSlowaWY.Name = "lbSlowaWY";
            lbSlowaWY.Size = new Size(283, 279);
            lbSlowaWY.TabIndex = 2;
            // 
            // cbJezyk
            // 
            cbJezyk.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJezyk.FormattingEnabled = true;
            cbJezyk.Items.AddRange(new object[] { "Język angielski", "Język niemiecki" });
            cbJezyk.Location = new Point(357, 24);
            cbJezyk.Name = "cbJezyk";
            cbJezyk.Size = new Size(356, 33);
            cbJezyk.TabIndex = 1;
            cbJezyk.SelectedIndexChanged += cbJezyk_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(326, 25);
            label1.TabIndex = 0;
            label1.Text = "Wybierz język, którego chcesz się uczyć:";
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBazaDe1
            // 
            dsBazaDe1.DataSetName = "dsBazaDe";
            dsBazaDe1.Namespace = "http://tempuri.org/dsBazaDe.xsd";
            dsBazaDe1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBazaEn1
            // 
            dsBazaEn1.DataSetName = "dsBazaEn";
            dsBazaEn1.Namespace = "http://tempuri.org/dsBazaEn.xsd";
            dsBazaEn1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapiszPlikDial
            // 
            zapiszPlikDial.AddExtension = false;
            zapiszPlikDial.Filter = "Język angielski (*.xmla) |*.xmla| Język niemiecki (*.xmln) |*.xmln";
            zapiszPlikDial.Title = "Zapisz plik nauki";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // nakaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 567);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(822, 623);
            MinimizeBox = false;
            MinimumSize = new Size(822, 623);
            Name = "nakaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nauka słówek";
            Load += nakaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaDe1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsBazaEn1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUsunZNauka;
        private Button btnDodajDoNauka;
        private ListBox lbSlowaDoNauk;
        private ListBox lbSlowaWY;
        private ComboBox cbJezyk;
        private Label label1;
        private dsBaza dsBaza1;
        private Button btnZamknij;
        private Button btnGenerujPlik;
        private dsBazaDe dsBazaDe1;
        private dsBazaEn dsBazaEn1;
        private SaveFileDialog zapiszPlikDial;
        private System.Windows.Forms.Timer timer1;
    }
}