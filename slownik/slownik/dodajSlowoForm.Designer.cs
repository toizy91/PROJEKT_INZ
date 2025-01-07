namespace slownik
{
    partial class dodajSlowoForm
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
            button1 = new Button();
            btnCzyscPola = new Button();
            btnDodajSlowo = new Button();
            cbKategoria = new ComboBox();
            dsBaza1 = new dsBaza();
            cbTypSlowa = new ComboBox();
            txtZnaczenie = new TextBox();
            txtWyraz = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCzyscPola);
            panel1.Controls.Add(btnDodajSlowo);
            panel1.Controls.Add(cbKategoria);
            panel1.Controls.Add(cbTypSlowa);
            panel1.Controls.Add(txtZnaczenie);
            panel1.Controls.Add(txtWyraz);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 15);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 304);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(470, 250);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 10;
            button1.Text = "Zamknij";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCzyscPola
            // 
            btnCzyscPola.ForeColor = Color.Red;
            btnCzyscPola.Location = new Point(314, 206);
            btnCzyscPola.Margin = new Padding(4, 4, 4, 4);
            btnCzyscPola.Name = "btnCzyscPola";
            btnCzyscPola.Size = new Size(118, 36);
            btnCzyscPola.TabIndex = 9;
            btnCzyscPola.Text = "Czyść pola";
            btnCzyscPola.UseVisualStyleBackColor = true;
            // 
            // btnDodajSlowo
            // 
            btnDodajSlowo.ForeColor = Color.FromArgb(0, 192, 0);
            btnDodajSlowo.Location = new Point(439, 206);
            btnDodajSlowo.Margin = new Padding(4, 4, 4, 4);
            btnDodajSlowo.Name = "btnDodajSlowo";
            btnDodajSlowo.Size = new Size(149, 36);
            btnDodajSlowo.TabIndex = 8;
            btnDodajSlowo.Text = "Dodaj słowo";
            btnDodajSlowo.UseVisualStyleBackColor = true;
            btnDodajSlowo.Click += btnDodajSlowo_Click;
            // 
            // cbKategoria
            // 
            cbKategoria.DataSource = dsBaza1;
            cbKategoria.DisplayMember = "TKategorie.kategoria";
            cbKategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategoria.FormattingEnabled = true;
            cbKategoria.Location = new Point(230, 148);
            cbKategoria.Margin = new Padding(4, 4, 4, 4);
            cbKategoria.Name = "cbKategoria";
            cbKategoria.Size = new Size(356, 33);
            cbKategoria.TabIndex = 7;
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTypSlowa
            // 
            cbTypSlowa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypSlowa.FormattingEnabled = true;
            cbTypSlowa.Items.AddRange(new object[] { "czasownik", "czasownik frazowy", "idiom", "inne", "przymiotnik", "rzeczownik", "zwrot" });
            cbTypSlowa.Location = new Point(230, 105);
            cbTypSlowa.Margin = new Padding(4, 4, 4, 4);
            cbTypSlowa.Name = "cbTypSlowa";
            cbTypSlowa.Size = new Size(356, 33);
            cbTypSlowa.Sorted = true;
            cbTypSlowa.TabIndex = 6;
            // 
            // txtZnaczenie
            // 
            txtZnaczenie.Location = new Point(230, 64);
            txtZnaczenie.Margin = new Padding(4, 4, 4, 4);
            txtZnaczenie.Name = "txtZnaczenie";
            txtZnaczenie.Size = new Size(356, 31);
            txtZnaczenie.TabIndex = 5;
            txtZnaczenie.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWyraz
            // 
            txtWyraz.Location = new Point(230, 21);
            txtWyraz.Margin = new Padding(4, 4, 4, 4);
            txtWyraz.Name = "txtWyraz";
            txtWyraz.Size = new Size(356, 31);
            txtWyraz.TabIndex = 4;
            txtWyraz.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Kategoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Typ słowa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 1;
            label2.Text = "Tłumaczenie polskie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Słowo angielskie:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // dodajSlowoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(642, 334);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MaximumSize = new Size(664, 390);
            MinimizeBox = false;
            MinimumSize = new Size(664, 390);
            Name = "dodajSlowoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj słowo angielskie";
            FormClosed += dodajSlowoForm_FormClosed;
            Load += dodajSlowoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbKategoria;
        private ComboBox cbTypSlowa;
        private TextBox txtZnaczenie;
        private TextBox txtWyraz;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btnCzyscPola;
        private Button btnDodajSlowo;
        private dsBaza dsBaza1;
        private System.Windows.Forms.Timer timer1;
    }
}