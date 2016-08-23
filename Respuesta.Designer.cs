namespace Examen
{
    partial class Respuesta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.examenDataSet = new Examen.Database1DataSet();
            this.rESPUESTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDRESPUESTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPREGUNTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESPUESTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORRECTADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPUESTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRESPUESTADataGridViewTextBoxColumn,
            this.iDPREGUNTADataGridViewTextBoxColumn,
            this.rESPUESTADataGridViewTextBoxColumn,
            this.cORRECTADataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.rESPUESTABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // examenDataSet
            // 
            this.examenDataSet.DataSetName = "ExamenDataSet";
            this.examenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESPUESTABindingSource
            // 
            this.rESPUESTABindingSource.DataMember = "RESPUESTA";
            this.rESPUESTABindingSource.DataSource = this.examenDataSet;
            // 
            // iDRESPUESTADataGridViewTextBoxColumn
            // 
            this.iDRESPUESTADataGridViewTextBoxColumn.DataPropertyName = "ID_RESPUESTA";
            this.iDRESPUESTADataGridViewTextBoxColumn.HeaderText = "ID_RESPUESTA";
            this.iDRESPUESTADataGridViewTextBoxColumn.Name = "iDRESPUESTADataGridViewTextBoxColumn";
            // 
            // iDPREGUNTADataGridViewTextBoxColumn
            // 
            this.iDPREGUNTADataGridViewTextBoxColumn.DataPropertyName = "ID_PREGUNTA";
            this.iDPREGUNTADataGridViewTextBoxColumn.HeaderText = "ID_PREGUNTA";
            this.iDPREGUNTADataGridViewTextBoxColumn.Name = "iDPREGUNTADataGridViewTextBoxColumn";
            // 
            // rESPUESTADataGridViewTextBoxColumn
            // 
            this.rESPUESTADataGridViewTextBoxColumn.DataPropertyName = "RESPUESTA";
            this.rESPUESTADataGridViewTextBoxColumn.HeaderText = "RESPUESTA";
            this.rESPUESTADataGridViewTextBoxColumn.Name = "rESPUESTADataGridViewTextBoxColumn";
            // 
            // cORRECTADataGridViewCheckBoxColumn
            // 
            this.cORRECTADataGridViewCheckBoxColumn.DataPropertyName = "CORRECTA";
            this.cORRECTADataGridViewCheckBoxColumn.HeaderText = "CORRECTA";
            this.cORRECTADataGridViewCheckBoxColumn.Name = "cORRECTADataGridViewCheckBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta";
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Respuesta";
            this.Text = "Respuesta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPUESTABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRESPUESTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPREGUNTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPUESTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cORRECTADataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource rESPUESTABindingSource;
        private Database1DataSet examenDataSet;
        private System.Windows.Forms.Label label1;
    }
}