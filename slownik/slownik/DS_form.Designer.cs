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
            panel1 = new Panel();
            dsBaza1 = new dsBaza();
            dgvSlowa = new DataGridView();
            wyrazDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            znaczenieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnUsunSlowo = new Button();
            btnDodajSlowo = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tsLiczbaSlow = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsBaza1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSlowa).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDodajSlowo);
            panel1.Controls.Add(btnUsunSlowo);
            panel1.Controls.Add(dgvSlowa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 275);
            panel1.TabIndex = 0;
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            wyrazDataGridViewTextBoxColumn.DataPropertyName = "wyraz";
            wyrazDataGridViewTextBoxColumn.HeaderText = "wyraz";
            wyrazDataGridViewTextBoxColumn.MinimumWidth = 6;
            wyrazDataGridViewTextBoxColumn.Name = "wyrazDataGridViewTextBoxColumn";
            wyrazDataGridViewTextBoxColumn.ReadOnly = true;
            wyrazDataGridViewTextBoxColumn.Width = 125;
            // 
            // znaczenieDataGridViewTextBoxColumn
            // 
            znaczenieDataGridViewTextBoxColumn.DataPropertyName = "znaczenie";
            znaczenieDataGridViewTextBoxColumn.HeaderText = "znaczenie";
            znaczenieDataGridViewTextBoxColumn.MinimumWidth = 6;
            znaczenieDataGridViewTextBoxColumn.Name = "znaczenieDataGridViewTextBoxColumn";
            znaczenieDataGridViewTextBoxColumn.ReadOnly = true;
            znaczenieDataGridViewTextBoxColumn.Width = 125;
            // 
            // typDataGridViewTextBoxColumn
            // 
            typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            typDataGridViewTextBoxColumn.HeaderText = "typ";
            typDataGridViewTextBoxColumn.MinimumWidth = 6;
            typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            typDataGridViewTextBoxColumn.ReadOnly = true;
            typDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            kategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnUsunSlowo
            // 
            btnUsunSlowo.Location = new Point(456, 230);
            btnUsunSlowo.Name = "btnUsunSlowo";
            btnUsunSlowo.Size = new Size(122, 29);
            btnUsunSlowo.TabIndex = 12;
            btnUsunSlowo.Text = "Usuń wybrane";
            btnUsunSlowo.UseVisualStyleBackColor = true;
            // 
            // btnDodajSlowo
            // 
            btnDodajSlowo.Location = new Point(292, 230);
            btnDodajSlowo.Name = "btnDodajSlowo";
            btnDodajSlowo.Size = new Size(158, 29);
            btnDodajSlowo.TabIndex = 13;
            btnDodajSlowo.Text = "Dodaj nowe słowo";
            btnDodajSlowo.UseVisualStyleBackColor = true;
            btnDodajSlowo.Click += btnDodajSlowo_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tsLiczbaSlow });
            statusStrip1.Location = new Point(0, 306);
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
            // DS_form_en
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 332);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DS_form_en";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zarządzaj słowami";
            Load += DS_form_en_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dsBaza1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSlowa).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private dsBaza dsBaza1;
        private DataGridView dgvSlowa;
        private DataGridViewTextBoxColumn wyrazDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn znaczenieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private Button btnUsunSlowo;
        private Button btnDodajSlowo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsLiczbaSlow;
    }
}