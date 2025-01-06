namespace slownik
{
    partial class DS_form_en
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
            btnDodajSlowo = new Button();
            btnUsunSlowo = new Button();
            dgvSlowa = new DataGridView();
            wyrazDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            znaczenieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dsBaza1 = new dsBaza();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tsLiczbaSlow = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSlowa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnZamknij);
            panel1.Controls.Add(btnDodajSlowo);
            panel1.Controls.Add(btnUsunSlowo);
            panel1.Controls.Add(dgvSlowa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 308);
            panel1.TabIndex = 0;
            // 
            // btnZamknij
            // 
            btnZamknij.ForeColor = Color.Blue;
            btnZamknij.Location = new Point(484, 265);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(94, 29);
            btnZamknij.TabIndex = 14;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // btnDodajSlowo
            // 
            btnDodajSlowo.ForeColor = Color.Green;
            btnDodajSlowo.Location = new Point(292, 230);
            btnDodajSlowo.Name = "btnDodajSlowo";
            btnDodajSlowo.Size = new Size(158, 29);
            btnDodajSlowo.TabIndex = 13;
            btnDodajSlowo.Text = "Dodaj nowe słowo";
            btnDodajSlowo.UseVisualStyleBackColor = true;
            btnDodajSlowo.Click += btnDodajSlowo_Click;
            // 
            // btnUsunSlowo
            // 
            btnUsunSlowo.ForeColor = Color.Red;
            btnUsunSlowo.Location = new Point(456, 230);
            btnUsunSlowo.Name = "btnUsunSlowo";
            btnUsunSlowo.Size = new Size(122, 29);
            btnUsunSlowo.TabIndex = 12;
            btnUsunSlowo.Text = "Usuń wybrane";
            btnUsunSlowo.UseVisualStyleBackColor = true;
            btnUsunSlowo.Click += btnUsunSlowo_Click;
            // 
            // dgvSlowa
            // 
            dgvSlowa.AllowUserToAddRows = false;
            dgvSlowa.AllowUserToDeleteRows = false;
            dgvSlowa.AutoGenerateColumns = false;
            dgvSlowa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlowa.Columns.AddRange(new DataGridViewColumn[] { wyrazDataGridViewTextBoxColumn, znaczenieDataGridViewTextBoxColumn, typDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dgvSlowa.DataMember = "TEn";
            dgvSlowa.DataSource = dsBaza1;
            dgvSlowa.Location = new Point(25, 24);
            dgvSlowa.MultiSelect = false;
            dgvSlowa.Name = "dgvSlowa";
            dgvSlowa.ReadOnly = true;
            dgvSlowa.RowHeadersWidth = 51;
            dgvSlowa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlowa.Size = new Size(553, 188);
            dgvSlowa.TabIndex = 11;
            // 
            // wyrazDataGridViewTextBoxColumn
            // 
            wyrazDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wyrazDataGridViewTextBoxColumn.DataPropertyName = "wyraz";
            wyrazDataGridViewTextBoxColumn.HeaderText = "wyraz";
            wyrazDataGridViewTextBoxColumn.MinimumWidth = 6;
            wyrazDataGridViewTextBoxColumn.Name = "wyrazDataGridViewTextBoxColumn";
            wyrazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // znaczenieDataGridViewTextBoxColumn
            // 
            znaczenieDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            znaczenieDataGridViewTextBoxColumn.DataPropertyName = "znaczenie";
            znaczenieDataGridViewTextBoxColumn.HeaderText = "znaczenie";
            znaczenieDataGridViewTextBoxColumn.MinimumWidth = 6;
            znaczenieDataGridViewTextBoxColumn.Name = "znaczenieDataGridViewTextBoxColumn";
            znaczenieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typDataGridViewTextBoxColumn
            // 
            typDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            typDataGridViewTextBoxColumn.HeaderText = "typ";
            typDataGridViewTextBoxColumn.MinimumWidth = 6;
            typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            typDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tsLiczbaSlow });
            statusStrip1.Location = new Point(0, 337);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(628, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(101, 20);
            toolStripStatusLabel1.Text = "Słów na liście:";
            // 
            // tsLiczbaSlow
            // 
            tsLiczbaSlow.Name = "tsLiczbaSlow";
            tsLiczbaSlow.Size = new Size(17, 20);
            tsLiczbaSlow.Text = "0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // DS_form_en
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(628, 363);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(646, 410);
            MinimizeBox = false;
            MinimumSize = new Size(646, 410);
            Name = "DS_form_en";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zarządzaj słowami angielskimi";
            FormClosed += DS_form_en_FormClosed;
            Load += DS_form_en_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSlowa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private dsBaza dsBaza1;
        private DataGridView dgvSlowa;
        private Button btnUsunSlowo;
        private Button btnDodajSlowo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsLiczbaSlow;
        private DataGridViewTextBoxColumn wyrazDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn znaczenieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private Button btnZamknij;
    }
}