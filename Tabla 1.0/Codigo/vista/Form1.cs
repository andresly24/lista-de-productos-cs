using negocio;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace vista
{
    public partial class Form1 : Form
    {
        N_consultar objetos = new N_consultar();
        private string id = null;
        private string itemText = null;

        // Winform Movimiento

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = objetos.mostrarp();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            datelbl.Text = DateTime.Now.ToString("dd/mm/yyyy");

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[2].Width = 100;

            itemtbE.Enabled = false;
            preciotbE.Enabled = false;

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(itemtb.Text) || string.IsNullOrEmpty(preciotb.Text))
                {
                    MessageBox.Show("Rellene los campos vacios");
                }
                else
                {
                    objetos.insertarp(itemtb.Text, preciotb.Text);
                    MessageBox.Show("Se agrego correctamente");
                    itemtb.Text = null;
                    preciotb.Text = null;
                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar por: \n\r" + ex.Message);
            }
        }

        private void preciotb_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemtb_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                itemtbE.Text = dataGridView1.CurrentRow.Cells["item"].Value.ToString();
                preciotbE.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                itemtbE.Enabled = true;
                preciotbE.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione los datos que quiera Editar");
            }
        }

        private void agregarbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(itemtbE.Text) || string.IsNullOrEmpty(preciotbE.Text))
                {
                    MessageBox.Show("Rellene los campos vacios");
                }
                else
                {
                    objetos.editarp(id, itemtbE.Text, preciotbE.Text);
                    MessageBox.Show("Se actualizo correctamente");
                    itemtbE.Text = null;
                    preciotbE.Text = null;
                    itemtbE.Enabled = false;
                    preciotbE.Enabled = false;
                    Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar por: \n\r" + ex.Message);
                throw;
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    itemText = dataGridView1.CurrentRow.Cells["item"].Value.ToString();
                    id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

                    MessageBox.Show("Se elimino '" + itemText + "' correctamente");
                    objetos.eliminarp(id);
                    Mostrar();
                }
                else
                {
                    MessageBox.Show("Seleccione los datos que quiera Eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar por: \n\r" + ex.Message);
                throw;
            }

        }

        private void eliminartodobtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "�Est� seguro que desea continuar?",
            "Advertencia",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se elimino toda la Tabla");
                objetos.resetp();
                Mostrar();
            }
            else
            {
                Mostrar();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            objetos.descargarp();
            MessageBox.Show("Se ha descargado la Lista en 'Descargas' \n\rcomo 'lista_de_productos'");
        }

        private void itemtb_Enter(object sender, EventArgs e)
        {
            if (itemtb.Text == "Ingrese el Item" || itemtb.ForeColor == Color.Gray)
            {
                itemtb.Text = "";
                itemtb.ForeColor = Color.Black;
            }
        }

        private void itemtb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(itemtb.Text))
            {
                itemtb.Text = "Ingrese el Item";
                itemtb.ForeColor = Color.Gray;
            }
        }

        private void preciotb_Enter(object sender, EventArgs e)
        {
            if (preciotb.Text == "Ingrese el Precio" || preciotb.ForeColor == Color.Gray)
            {
                preciotb.Text = "";
                preciotb.ForeColor = Color.Black;
            }
        }

        private void preciotb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(preciotb.Text))
            {
                preciotb.Text = "Ingrese el Precio";
                preciotb.ForeColor = Color.Gray;
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
