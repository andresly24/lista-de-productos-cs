using negocio;
using System.Data;
using System.Linq.Expressions;

namespace vista
{
    public partial class Form1 : Form
    {
        N_consultar objetos = new N_consultar();
        private string id = null;
        private string itemText = null;
        public Form1()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            objetos.descargarp();
            MessageBox.Show("Se ha descargado la Lista en 'Descargas' \n\rcomo 'lista_de_productos'");
        }
    }
}
