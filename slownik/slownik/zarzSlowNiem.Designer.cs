namespace slownik
{
    partial class zarzSlowNiem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnZamknij = new Button();
            dgvSlowa = new DataGridView();
            wyrazDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            znaczenieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rodzajnikDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            zaimekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            przypadekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dsBaza1 = new dsBaza();
            btnDodajSlowo = new Button();
            btnUsunSlowo = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tsLab = new ToolStripStatusLabel();
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
            panel1.Controls.Add(dgvSlowa);
            panel1.Controls.Add(btnDodajSlowo);
            panel1.Controls.Add(btnUsunSlowo);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 384);
            panel1.TabIndex = 1;
            // 
            // btnZamknij
            // 
            btnZamknij.ForeColor = Color.Blue;
            btnZamknij.Location = new Point(1046, 331);
            btnZamknij.Margin = new Padding(2);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(112, 34);
            btnZamknij.TabIndex = 15;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // dgvSlowa
            // 
            dgvSlowa.AllowUserToAddRows = false;
            dgvSlowa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dgvSlowa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSlowa.AutoGenerateColumns = false;
            dgvSlowa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlowa.Columns.AddRange(new DataGridViewColumn[] { wyrazDataGridViewTextBoxColumn, znaczenieDataGridViewTextBoxColumn, typDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn, rodzajnikDataGridViewTextBoxColumn, zaimekDataGridViewTextBoxColumn, przypadekDataGridViewTextBoxColumn });
            dgvSlowa.DataMember = "TDe";
            dgvSlowa.DataSource = dsBaza1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSlowa.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSlowa.Location = new Point(40, 30);
            dgvSlowa.Margin = new Padding(2);
            dgvSlowa.MultiSelect = false;
            dgvSlowa.Name = "dgvSlowa";
            dgvSlowa.ReadOnly = true;
            dgvSlowa.RowHeadersWidth = 62;
            dgvSlowa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlowa.Size = new Size(1118, 225);
            dgvSlowa.TabIndex = 14;
            // 
            // wyrazDataGridViewTextBoxColumn
            // 
            wyrazDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wyrazDataGridViewTextBoxColumn.DataPropertyName = "wyraz";
            wyrazDataGridViewTextBoxColumn.HeaderText = "wyraz";
            wyrazDataGridViewTextBoxColumn.MinimumWidth = 8;
            wyrazDataGridViewTextBoxColumn.Name = "wyrazDataGridViewTextBoxColumn";
            wyrazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // znaczenieDataGridViewTextBoxColumn
            // 
            znaczenieDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            znaczenieDataGridViewTextBoxColumn.DataPropertyName = "znaczenie";
            znaczenieDataGridViewTextBoxColumn.HeaderText = "znaczenie";
            znaczenieDataGridViewTextBoxColumn.MinimumWidth = 8;
            znaczenieDataGridViewTextBoxColumn.Name = "znaczenieDataGridViewTextBoxColumn";
            znaczenieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typDataGridViewTextBoxColumn
            // 
            typDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            typDataGridViewTextBoxColumn.HeaderText = "typ";
            typDataGridViewTextBoxColumn.MinimumWidth = 8;
            typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            typDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodzajnikDataGridViewTextBoxColumn
            // 
            rodzajnikDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rodzajnikDataGridViewTextBoxColumn.DataPropertyName = "rodzajnik";
            rodzajnikDataGridViewTextBoxColumn.HeaderText = "rodzajnik";
            rodzajnikDataGridViewTextBoxColumn.MinimumWidth = 8;
            rodzajnikDataGridViewTextBoxColumn.Name = "rodzajnikDataGridViewTextBoxColumn";
            rodzajnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaimekDataGridViewTextBoxColumn
            // 
            zaimekDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            zaimekDataGridViewTextBoxColumn.DataPropertyName = "zaimek";
            zaimekDataGridViewTextBoxColumn.HeaderText = "zaimek";
            zaimekDataGridViewTextBoxColumn.MinimumWidth = 8;
            zaimekDataGridViewTextBoxColumn.Name = "zaimekDataGridViewTextBoxColumn";
            zaimekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // przypadekDataGridViewTextBoxColumn
            // 
            przypadekDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            przypadekDataGridViewTextBoxColumn.DataPropertyName = "przypadek";
            przypadekDataGridViewTextBoxColumn.HeaderText = "przypadek";
            przypadekDataGridViewTextBoxColumn.MinimumWidth = 8;
            przypadekDataGridViewTextBoxColumn.Name = "przypadekDataGridViewTextBoxColumn";
            przypadekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsBaza1
            // 
            dsBaza1.DataSetName = "dsBaza";
            dsBaza1.Namespace = "http://tempuri.org/dsBaza.xsd";
            dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajSlowo
            // 
            btnDodajSlowo.ForeColor = Color.Green;
            btnDodajSlowo.Location = new Point(800, 288);
            btnDodajSlowo.Margin = new Padding(4);
            btnDodajSlowo.Name = "btnDodajSlowo";
            btnDodajSlowo.Size = new Size(198, 36);
            btnDodajSlowo.TabIndex = 13;
            btnDodajSlowo.Text = "Dodaj nowe słowo";
            btnDodajSlowo.UseVisualStyleBackColor = true;
            btnDodajSlowo.Click += btnDodajSlowo_Click;
            // 
            // btnUsunSlowo
            // 
            btnUsunSlowo.ForeColor = Color.Red;
            btnUsunSlowo.Location = new Point(1006, 288);
            btnUsunSlowo.Margin = new Padding(4);
            btnUsunSlowo.Name = "btnUsunSlowo";
            btnUsunSlowo.Size = new Size(152, 36);
            btnUsunSlowo.TabIndex = 12;
            btnUsunSlowo.Text = "Usuń wybrane";
            btnUsunSlowo.UseVisualStyleBackColor = true;
            btnUsunSlowo.Click += btnUsunSlowo_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tsLab });
            statusStrip1.Location = new Point(0, 403);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1230, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(121, 25);
            toolStripStatusLabel1.Text = "Słów na liście:";
            // 
            // tsLab
            // 
            tsLab.Name = "tsLab";
            tsLab.Size = new Size(22, 25);
            tsLab.Text = "0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // zarzSlowNiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1230, 435);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(1252, 491);
            MinimizeBox = false;
            MinimumSize = new Size(1252, 491);
            Name = "zarzSlowNiem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zarządzaj słowami niemieckimi";
            FormClosed += zarzSlowNiem_FormClosed;
            Load += zarzSlowNiem_Load;
            Enter += zarzSlowNiem_Load;
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
        private Button btnDodajSlowo;
        private Button btnUsunSlowo;
        private dsBaza dsBaza1;
        private DataGridView dgvSlowa;
        private DataGridViewTextBoxColumn wyrazDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn znaczenieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rodzajnikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zaimekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn przypadekDataGridViewTextBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsLab;
        private Button btnZamknij;
        private System.Windows.Forms.Timer timer1;
    }
}