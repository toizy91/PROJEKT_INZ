namespace slownik
{
    partial class DK_form
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
            btnDodajKategorie = new Button();
            btnUsunKategorie = new Button();
            cbKategorie = new ComboBox();
            dsBaza1 = new dsBaza();
            label2 = new Label();
            txtNowaKategoria = new TextBox();
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
            panel1.Controls.Add(btnDodajKategorie);
            panel1.Controls.Add(btnUsunKategorie);
            panel1.Controls.Add(cbKategorie);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNowaKategoria);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 180);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(548, 121);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 6;
            button1.Text = "Zamknij";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDodajKategorie
            // 
            btnDodajKategorie.BackColor = Color.White;
            btnDodajKategorie.ForeColor = Color.FromArgb(0, 192, 0);
            btnDodajKategorie.Location = new Point(472, 19);
            btnDodajKategorie.Margin = new Padding(4);
            btnDodajKategorie.Name = "btnDodajKategorie";
            btnDodajKategorie.Size = new Size(192, 36);
            btnDodajKategorie.TabIndex = 5;
            btnDodajKategorie.Text = "Dodaj kategorię";
            btnDodajKategorie.UseVisualStyleBackColor = false;
            btnDodajKategorie.Click += btnDodajKategorie_Click;
            // 
            // btnUsunKategorie
            // 
            btnUsunKategorie.ForeColor = Color.Red;
            btnUsunKategorie.Location = new Point(472, 62);
            btnUsunKategorie.Margin = new Padding(4);
            btnUsunKategorie.Name = "btnUsunKategorie";
            btnUsunKategorie.Size = new Size(192, 36);
            btnUsunKategorie.TabIndex = 4;
            btnUsunKategorie.Text = "Usuń kategorię";
            btnUsunKategorie.UseVisualStyleBackColor = true;
            btnUsunKategorie.Click += btnUsunKategorie_Click;
            // 
            // cbKategorie
            // 
            cbKategorie.DataSource = dsBaza1;
            cbKategorie.DisplayMember = "TKategorie.kategoria";
            cbKategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategorie.FormattingEnabled = true;
            cbKategorie.Location = new Point(208, 62);
            cbKategorie.Margin = new Padding(4);
            cbKategorie.Name = "cbKategorie";
            cbKategorie.Size = new Size(256, 33);
            cbKategorie.TabIndex = 3;
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 2;
            label2.Text = "Dostępne kategorie:";
            // 
            // txtNowaKategoria
            // 
            txtNowaKategoria.Location = new Point(176, 16);
            txtNowaKategoria.Margin = new Padding(4);
            txtNowaKategoria.Name = "txtNowaKategoria";
            txtNowaKategoria.Size = new Size(288, 31);
            txtNowaKategoria.TabIndex = 1;
            txtNowaKategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Nowa kategoria:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // DK_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(715, 209);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(737, 265);
            MinimizeBox = false;
            MinimumSize = new Size(737, 265);
            Name = "DK_form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zarządzaj kategoriami";
            Load += DK_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDodajKategorie;
        private Button btnUsunKategorie;
        private ComboBox cbKategorie;
        private Label label2;
        private TextBox txtNowaKategoria;
        private Label label1;
        private Button button1;
        private dsBaza dsBaza1;
        private System.Windows.Forms.Timer timer1;
    }
}