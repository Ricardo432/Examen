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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Examen.ExamenDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.respuestaTableAdapter = new Examen.ExamenDBDataSetTableAdapters.RespuestaTableAdapter();
            this.cerrarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.correctaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.respuestaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Respuesta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Respuesta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Respuesta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Respuesta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // correctaDataGridViewTextBoxColumn
            // 
            this.correctaDataGridViewTextBoxColumn.DataPropertyName = "Correcta";
            this.correctaDataGridViewTextBoxColumn.HeaderText = "Correcta";
            this.correctaDataGridViewTextBoxColumn.Name = "correctaDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Pregunta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Pregunta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // respuestaBindingSource
            // 
            this.respuestaBindingSource.DataMember = "Respuesta";
            this.respuestaBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // respuestaTableAdapter
            // 
            this.respuestaTableAdapter.ClearBeforeFill = true;
            // 
            // cerrarbtn
            // 
            this.cerrarbtn.Location = new System.Drawing.Point(468, 227);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(75, 32);
            this.cerrarbtn.TabIndex = 2;
            this.cerrarbtn.Text = "Cerrar";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.cerrarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Respuesta";
            this.Text = "Respuesta";
            this.Load += new System.EventHandler(this.Respuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRESPUESTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPREGUNTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPUESTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cORRECTADataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private ExamenDBDataSet database1DataSet;
        private System.Windows.Forms.BindingSource respuestaBindingSource;
        private ExamenDBDataSetTableAdapters.RespuestaTableAdapter respuestaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button cerrarbtn;
    }
}