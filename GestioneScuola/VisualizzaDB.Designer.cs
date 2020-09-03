namespace GestioneScuola
{
    partial class VisualizzaDB
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sCUOLADataSet = new GestioneScuola.SCUOLADataSet();
            this.classiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classiTableAdapter = new GestioneScuola.SCUOLADataSetTableAdapters.ClassiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiTableAdapter = new GestioneScuola.SCUOLADataSetTableAdapters.StudentiTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paeseProvenienzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sCUOLADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classiBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(491, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdClasse";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // sCUOLADataSet
            // 
            this.sCUOLADataSet.DataSetName = "SCUOLADataSet";
            this.sCUOLADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classiBindingSource
            // 
            this.classiBindingSource.DataMember = "Classi";
            this.classiBindingSource.DataSource = this.sCUOLADataSet;
            // 
            // classiTableAdapter
            // 
            this.classiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.paeseProvenienzaDataGridViewTextBoxColumn,
            this.idClasseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 249);
            this.dataGridView1.TabIndex = 1;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.sCUOLADataSet;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // paeseProvenienzaDataGridViewTextBoxColumn
            // 
            this.paeseProvenienzaDataGridViewTextBoxColumn.DataPropertyName = "PaeseProvenienza";
            this.paeseProvenienzaDataGridViewTextBoxColumn.HeaderText = "PaeseProvenienza";
            this.paeseProvenienzaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paeseProvenienzaDataGridViewTextBoxColumn.Name = "paeseProvenienzaDataGridViewTextBoxColumn";
            this.paeseProvenienzaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idClasseDataGridViewTextBoxColumn
            // 
            this.idClasseDataGridViewTextBoxColumn.DataPropertyName = "IdClasse";
            this.idClasseDataGridViewTextBoxColumn.HeaderText = "IdClasse";
            this.idClasseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idClasseDataGridViewTextBoxColumn.Name = "idClasseDataGridViewTextBoxColumn";
            this.idClasseDataGridViewTextBoxColumn.Width = 150;
            // 
            // VisualizzaDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "VisualizzaDB";
            this.Text = "VisualizzaDB";
            this.Load += new System.EventHandler(this.VisualizzaDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sCUOLADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private SCUOLADataSet sCUOLADataSet;
        private System.Windows.Forms.BindingSource classiBindingSource;
        private SCUOLADataSetTableAdapters.ClassiTableAdapter classiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private SCUOLADataSetTableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paeseProvenienzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasseDataGridViewTextBoxColumn;
    }
}