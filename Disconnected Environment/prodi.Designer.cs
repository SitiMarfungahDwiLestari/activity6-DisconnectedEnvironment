
namespace Disconnected_Environment
{
    partial class prodi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.activity6DataSet = new Disconnected_Environment.activity6DataSet();
            this.prodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTableAdapter = new Disconnected_Environment.activity6DataSetTableAdapters.prodiTableAdapter();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Prodi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(282, 377);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 36);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(371, 377);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(83, 36);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(499, 336);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(65, 31);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(664, 34);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 41);
            this.open.TabIndex = 8;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodiDataGridViewTextBoxColumn,
            this.namaprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 281);
            this.dataGridView1.TabIndex = 9;
            // 
            // activity6DataSet
            // 
            this.activity6DataSet.DataSetName = "activity6DataSet";
            this.activity6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodiBindingSource
            // 
            this.prodiBindingSource.DataMember = "prodi";
            this.prodiBindingSource.DataSource = this.activity6DataSet;
            // 
            // prodiTableAdapter
            // 
            this.prodiTableAdapter.ClearBeforeFill = true;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaprodiDataGridViewTextBoxColumn
            // 
            this.namaprodiDataGridViewTextBoxColumn.DataPropertyName = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.HeaderText = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaprodiDataGridViewTextBoxColumn.Name = "namaprodiDataGridViewTextBoxColumn";
            this.namaprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 397);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 41);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "prodi";
            this.Text = "Data Prodi";
            this.Load += new System.EventHandler(this.prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.DataGridView dataGridView1;
        private activity6DataSet activity6DataSet;
        private System.Windows.Forms.BindingSource prodiBindingSource;
        private activity6DataSetTableAdapters.prodiTableAdapter prodiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
    }
}