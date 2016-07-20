namespace Examen
{
    partial class Tema
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
            this.examenDataSet = new Examen.ExamenDataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mATERIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenDataSet1 = new Examen.ExamenDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.act = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEMABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // examenDataSet
            // 
            this.examenDataSet.DataSetName = "ExamenDataSet";
            this.examenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.act);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(529, 347);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mATERIABindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // mATERIABindingSource
            // 
            this.mATERIABindingSource.DataMember = "MATERIA";
            this.mATERIABindingSource.DataSource = this.examenDataSet1;
            // 
            // examenDataSet1
            // 
            this.examenDataSet1.DataSetName = "ExamenDataSet";
            this.examenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignatura";
            // 
            // act
            // 
            this.act.Location = new System.Drawing.Point(172, 205);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(75, 23);
            this.act.TabIndex = 1;
            this.act.Text = "Actualizar";
            this.act.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTEMADataGridViewTextBoxColumn,
            this.iDMATDataGridViewTextBoxColumn,
            this.uNIDADDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tEMABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDTEMADataGridViewTextBoxColumn
            // 
            this.iDTEMADataGridViewTextBoxColumn.DataPropertyName = "ID_TEMA";
            this.iDTEMADataGridViewTextBoxColumn.HeaderText = "ID_TEMA";
            this.iDTEMADataGridViewTextBoxColumn.Name = "iDTEMADataGridViewTextBoxColumn";
            // 
            // iDMATDataGridViewTextBoxColumn
            // 
            this.iDMATDataGridViewTextBoxColumn.DataPropertyName = "ID_MAT";
            this.iDMATDataGridViewTextBoxColumn.HeaderText = "ID_MAT";
            this.iDMATDataGridViewTextBoxColumn.Name = "iDMATDataGridViewTextBoxColumn";
            // 
            // uNIDADDataGridViewTextBoxColumn
            // 
            this.uNIDADDataGridViewTextBoxColumn.DataPropertyName = "UNIDAD";
            this.uNIDADDataGridViewTextBoxColumn.HeaderText = "UNIDAD";
            this.uNIDADDataGridViewTextBoxColumn.Name = "uNIDADDataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // tEMABindingSource
            // 
            this.tEMABindingSource.DataMember = "TEMA";
            this.tEMABindingSource.DataSource = this.examenDataSet;
            // 
            // Tema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 347);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Tema";
            this.Text = "Temas";
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mATERIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEMABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExamenDataSet examenDataSet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mATERIABindingSource;
        private ExamenDataSet examenDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button act;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tEMABindingSource;

    }
}