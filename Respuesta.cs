using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Respuesta : Form
    {
        public Respuesta()
        {
            InitializeComponent();
        }

        private void Respuesta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Respuesta' Puede moverla o quitarla según sea necesario.
            this.respuestaTableAdapter.Fill(this.database1DataSet.Respuesta);

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
