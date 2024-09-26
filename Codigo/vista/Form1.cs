using negocio;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace vista
{
    public partial class Form1 : Form
    {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            datelbl.Text = DateTime.Now.ToString("dd/mm/yyyy");

            inicio uc = new inicio();
            AddUC(uc);

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddUC(UserControl uc)
        {
            screen.Controls.Clear();
            screen.Controls.Add(uc);
            uc.BringToFront();

        }
        private void homebtn_Click(object sender, EventArgs e)
        {
            inicio uc = new inicio();
            AddUC(uc);
        }

        private void comprimirbtn_Click(object sender, EventArgs e)
        {
            Comprimir uc = new Comprimir();
            AddUC(uc);
        }

        private void listabtn_Click(object sender, EventArgs e)
        {
            listado uc = new listado();
            AddUC(uc);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            inicio uc = new inicio();
            AddUC(uc);
        }
    }
}
