namespace Examen
{
    partial class Reactivo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.busc = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDPREGUNTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREGUNTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pADREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREGUNTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenDataSet = new Examen.ExamenDataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGUNTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.busc);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(707, 315);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // busc
            // 
            this.busc.Location = new System.Drawing.Point(504, 21);
            this.busc.Name = "busc";
            this.busc.Size = new System.Drawing.Size(75, 23);
            this.busc.TabIndex = 3;
            this.busc.Text = "Aceptar";
            this.busc.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignaruta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.iDPREGUNTADataGridViewTextBoxColumn,
            this.pREGUNTADataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.pADREDataGridViewTextBoxColumn,
            this.iDTEMADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pREGUNTABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // select
            // 
            this.select.HeaderText = "Ver Respuestas";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.Text = "";
            // 
            // iDPREGUNTADataGridViewTextBoxColumn
            // 
            this.iDPREGUNTADataGridViewTextBoxColumn.DataPropertyName = "ID_PREGUNTA";
            this.iDPREGUNTADataGridViewTextBoxColumn.HeaderText = "ID_PREGUNTA";
            this.iDPREGUNTADataGridViewTextBoxColumn.Name = "iDPREGUNTADataGridViewTextBoxColumn";
            // 
            // pREGUNTADataGridViewTextBoxColumn
            // 
            this.pREGUNTADataGridViewTextBoxColumn.DataPropertyName = "PREGUNTA";
            this.pREGUNTADataGridViewTextBoxColumn.HeaderText = "PREGUNTA";
            this.pREGUNTADataGridViewTextBoxColumn.Name = "pREGUNTADataGridViewTextBoxColumn";
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            // 
            // pADREDataGridViewTextBoxColumn
            // 
            this.pADREDataGridViewTextBoxColumn.DataPropertyName = "PADRE";
            this.pADREDataGridViewTextBoxColumn.HeaderText = "PADRE";
            this.pADREDataGridViewTextBoxColumn.Name = "pADREDataGridViewTextBoxColumn";
            // 
            // iDTEMADataGridViewTextBoxColumn
            // 
            this.iDTEMADataGridViewTextBoxColumn.DataPropertyName = "ID_TEMA";
            this.iDTEMADataGridViewTextBoxColumn.HeaderText = "ID_TEMA";
            this.iDTEMADataGridViewTextBoxColumn.Name = "iDTEMADataGridViewTextBoxColumn";
            // 
            // pREGUNTABindingSource
            // 
            this.pREGUNTABindingSource.DataMember = "PREGUNTA";
            this.pREGUNTABindingSource.DataSource = this.examenDataSet;
            // 
            // examenDataSet
            // 
            this.examenDataSet.DataSetName = "ExamenDataSet";
            this.examenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Reactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 315);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Reactivo";
            this.Text = "Reactivo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGUNTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button busc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPREGUNTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREGUNTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pADREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pREGUNTABindingSource;
        private ExamenDataSet examenDataSet;
        private System.Windows.Forms.Button button1;
    }
}