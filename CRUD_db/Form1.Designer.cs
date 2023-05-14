namespace CRUD_db
{
    partial class Form1
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
            this.txt_numeClasa = new System.Windows.Forms.TextBox();
            this.stergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adaugare = new System.Windows.Forms.Button();
            this.txt_nrElevi = new System.Windows.Forms.TextBox();
            this.cNSHDataSet = new CRUD_db.CNSHDataSet();
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseTableAdapter = new CRUD_db.CNSHDataSetTableAdapters.ClaseTableAdapter();
            this.numeclasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nreleviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNSHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numeClasa
            // 
            this.txt_numeClasa.Location = new System.Drawing.Point(46, 12);
            this.txt_numeClasa.Name = "txt_numeClasa";
            this.txt_numeClasa.Size = new System.Drawing.Size(238, 20);
            this.txt_numeClasa.TabIndex = 0;
            // 
            // stergere
            // 
            this.stergere.Location = new System.Drawing.Point(209, 115);
            this.stergere.Name = "stergere";
            this.stergere.Size = new System.Drawing.Size(75, 23);
            this.stergere.TabIndex = 1;
            this.stergere.Text = "Stergere";
            this.stergere.UseVisualStyleBackColor = true;
            this.stergere.Click += new System.EventHandler(this.stergere_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeclasaDataGridViewTextBoxColumn,
            this.nreleviDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.claseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(327, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(211, 126);
            this.dataGridView1.TabIndex = 2;
            // 
            // adaugare
            // 
            this.adaugare.Location = new System.Drawing.Point(46, 115);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(75, 23);
            this.adaugare.TabIndex = 3;
            this.adaugare.Text = "Adaugare";
            this.adaugare.UseVisualStyleBackColor = true;
            this.adaugare.Click += new System.EventHandler(this.adaugare_Click);
            // 
            // txt_nrElevi
            // 
            this.txt_nrElevi.Location = new System.Drawing.Point(46, 59);
            this.txt_nrElevi.Name = "txt_nrElevi";
            this.txt_nrElevi.Size = new System.Drawing.Size(238, 20);
            this.txt_nrElevi.TabIndex = 4;
            // 
            // cNSHDataSet
            // 
            this.cNSHDataSet.DataSetName = "CNSHDataSet";
            this.cNSHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataMember = "Clase";
            this.claseBindingSource.DataSource = this.cNSHDataSet;
            // 
            // claseTableAdapter
            // 
            this.claseTableAdapter.ClearBeforeFill = true;
            // 
            // numeclasaDataGridViewTextBoxColumn
            // 
            this.numeclasaDataGridViewTextBoxColumn.DataPropertyName = "nume_clasa";
            this.numeclasaDataGridViewTextBoxColumn.HeaderText = "nume_clasa";
            this.numeclasaDataGridViewTextBoxColumn.Name = "numeclasaDataGridViewTextBoxColumn";
            // 
            // nreleviDataGridViewTextBoxColumn
            // 
            this.nreleviDataGridViewTextBoxColumn.DataPropertyName = "nr_elevi";
            this.nreleviDataGridViewTextBoxColumn.HeaderText = "nr_elevi";
            this.nreleviDataGridViewTextBoxColumn.Name = "nreleviDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 179);
            this.Controls.Add(this.txt_nrElevi);
            this.Controls.Add(this.adaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stergere);
            this.Controls.Add(this.txt_numeClasa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNSHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numeClasa;
        private System.Windows.Forms.Button stergere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.TextBox txt_nrElevi;
        private CNSHDataSet cNSHDataSet;
        private System.Windows.Forms.BindingSource claseBindingSource;
        private CNSHDataSetTableAdapters.ClaseTableAdapter claseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nreleviDataGridViewTextBoxColumn;
    }
}

