namespace Examen
{
    partial class Principal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.estadistica = new System.Windows.Forms.Button();
            this.asignatura = new System.Windows.Forms.Button();
            this.tema = new System.Windows.Forms.Button();
            this.reactivo = new System.Windows.Forms.Button();
            this.curso = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.estadistica, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.asignatura, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tema, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reactivo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.curso, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 225);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // estadistica
            // 
            this.estadistica.Location = new System.Drawing.Point(3, 138);
            this.estadistica.Name = "estadistica";
            this.estadistica.Size = new System.Drawing.Size(194, 39);
            this.estadistica.TabIndex = 0;
            this.estadistica.Text = "Estadísticas";
            this.estadistica.UseVisualStyleBackColor = true;
            this.estadistica.Click += new System.EventHandler(this.estadistica_Click);
            // 
            // asignatura
            // 
            this.asignatura.Location = new System.Drawing.Point(3, 3);
            this.asignatura.Name = "asignatura";
            this.asignatura.Size = new System.Drawing.Size(194, 39);
            this.asignatura.TabIndex = 0;
            this.asignatura.Text = "Asignaturas";
            this.asignatura.UseVisualStyleBackColor = true;
            this.asignatura.Click += new System.EventHandler(this.materia_Click);
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(3, 48);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(194, 39);
            this.tema.TabIndex = 0;
            this.tema.Text = "Temas";
            this.tema.UseVisualStyleBackColor = true;
            this.tema.Click += new System.EventHandler(this.tema_Click);
            // 
            // reactivo
            // 
            this.reactivo.Location = new System.Drawing.Point(3, 93);
            this.reactivo.Name = "reactivo";
            this.reactivo.Size = new System.Drawing.Size(194, 39);
            this.reactivo.TabIndex = 0;
            this.reactivo.Text = "Reactivos";
            this.reactivo.UseVisualStyleBackColor = true;
            this.reactivo.Click += new System.EventHandler(this.reactivo_Click);
            // 
            // curso
            // 
            this.curso.Location = new System.Drawing.Point(3, 183);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(194, 39);
            this.curso.TabIndex = 0;
            this.curso.Text = "Cursos";
            this.curso.UseVisualStyleBackColor = true;
            this.curso.Click += new System.EventHandler(this.curso_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(213, 268);
            this.MinimumSize = new System.Drawing.Size(213, 268);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button estadistica;
        private System.Windows.Forms.Button reactivo;
        private System.Windows.Forms.Button asignatura;
        private System.Windows.Forms.Button tema;
        private System.Windows.Forms.Button curso;


    }
}