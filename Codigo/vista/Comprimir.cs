using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class Comprimir : UserControl
    {
        public Comprimir()
        {
            InitializeComponent();
        }

        private void Comprimir_Load(object sender, EventArgs e)
        {

        }
        private void archivetb_Enter(object sender, EventArgs e)
        {
            if (archivetb.Text == "C:\\" || archivetb.ForeColor == Color.Gray)
            {
                archivetb.Text = "";
                archivetb.ForeColor = Color.Black;
            }
        }


        private void archivetb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(archivetb.Text))
            {
                archivetb.Text = "C:\\";
                archivetb.ForeColor = Color.Gray;
            }
        }

        private void ziptb_Enter(object sender, EventArgs e)
        {
            if (ziptb.Text == "C:\\" || ziptb.ForeColor == Color.Gray)
            {
                ziptb.Text = "";
                ziptb.ForeColor = Color.Black;
            }
        }

        private void ziptb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ziptb.Text))
            {
                ziptb.Text = "C:\\";
                ziptb.ForeColor = Color.Gray;
            }
        }

        private void comprimirbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Archivos de todos los formatos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar un archivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoSeleccionado = openFileDialog.FileName;
                    archivetb.Text = "";
                    archivetb.ForeColor = Color.Black;
                    archivetb.Text = archivoSeleccionado;

                }
            }
        }
    }
}
