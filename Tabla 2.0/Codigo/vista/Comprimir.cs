using DocumentFormat.OpenXml.Wordprocessing;
using System.IO.Compression;
using Color = System.Drawing.Color;
using System.Diagnostics;



namespace vista
{
    public partial class Comprimir : UserControl
    {
        string nombre = "";
        string folderPath = "";
        public Comprimir()
        {
            InitializeComponent();
        }

        private void Comprimir_Load(object sender, EventArgs e)
        {
            registrotb.Enabled = false;
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
            string a = @"C:\\";
            try
            {
                if (archivetb.Text == a || ziptb.Text == a)
                {
                    registrotb.Text = registrotb.Text + "~ Los campos se encuentran vacios\r";
                }
                else
                {
                    ZipFile.CreateFromDirectory(archivetb.Text, ziptb.Text);
                    registrotb.Text = registrotb.Text + "~ Se comprimio el archivo\r";
                    Process.Start("explorer.exe", folderPath);
                }
            }
            catch (Exception ex)
            {
                registrotb.Text = registrotb.Text + "~ " + ex.Message + "\r";
            }
        }

        private void carpetabtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog FileDialog = new OpenFileDialog())
            {
                FolderBrowserDialog FolderDiag = new FolderBrowserDialog();
                if (FolderDiag.ShowDialog() == DialogResult.OK)
                {
                    string carpetafd = FolderDiag.SelectedPath;
                    archivetb.Text = carpetafd;
                    archivetb.ForeColor = Color.Black;
                    registrotb.Text = registrotb.Text + "~ Se selecciono la carpeta de los archivos de la ruta: '" + carpetafd + "'\r";
                }
            }
        }

        private void carpeta2btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDiag = new FolderBrowserDialog();
            if (FolderDiag.ShowDialog() == DialogResult.OK)
            {
                string carpetafd = FolderDiag.SelectedPath;
                ziptb.Text = carpetafd + @"\archivos.zip";
                folderPath = carpetafd;
                ziptb.ForeColor = Color.Black;
                registrotb.Text = registrotb.Text + "~ Se selecciono la carpeta de la ruta: '" + carpetafd + "'\r";
            }
        }
    }
}
