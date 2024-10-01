namespace vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cerrarbtn = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            datelbl = new Label();
            logo = new PictureBox();
            comprimirbtn = new Button();
            homebtn = new Button();
            listabtn = new Button();
            panel6 = new Panel();
            screen = new Panel();
            ((System.ComponentModel.ISupportInitialize)cerrarbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // cerrarbtn
            // 
            cerrarbtn.Cursor = Cursors.Hand;
            cerrarbtn.Image = (Image)resources.GetObject("cerrarbtn.Image");
            cerrarbtn.Location = new Point(1287, 14);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(19, 19);
            cerrarbtn.SizeMode = PictureBoxSizeMode.StretchImage;
            cerrarbtn.TabIndex = 0;
            cerrarbtn.TabStop = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1256, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(cerrarbtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 47);
            panel1.TabIndex = 2;
            panel1.MouseDown += Form1_MouseDown;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datelbl.Location = new Point(12, 648);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(80, 17);
            datelbl.TabIndex = 12;
            datelbl.Text = "dd/mm/yyyy";
            // 
            // logo
            // 
            logo.Cursor = Cursors.Hand;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(11, 7);
            logo.Name = "logo";
            logo.Size = new Size(200, 200);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // comprimirbtn
            // 
            comprimirbtn.BackColor = SystemColors.MenuHighlight;
            comprimirbtn.Cursor = Cursors.Hand;
            comprimirbtn.FlatAppearance.BorderColor = Color.White;
            comprimirbtn.FlatAppearance.BorderSize = 0;
            comprimirbtn.FlatStyle = FlatStyle.Flat;
            comprimirbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comprimirbtn.ForeColor = SystemColors.ControlLightLight;
            comprimirbtn.Location = new Point(-1, 303);
            comprimirbtn.Name = "comprimirbtn";
            comprimirbtn.Size = new Size(219, 39);
            comprimirbtn.TabIndex = 14;
            comprimirbtn.Text = "Comprimir";
            comprimirbtn.UseVisualStyleBackColor = false;
            comprimirbtn.Click += comprimirbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = SystemColors.MenuHighlight;
            homebtn.Cursor = Cursors.Hand;
            homebtn.FlatAppearance.BorderColor = Color.White;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homebtn.ForeColor = SystemColors.ControlLightLight;
            homebtn.Location = new Point(0, 223);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(219, 39);
            homebtn.TabIndex = 13;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // listabtn
            // 
            listabtn.BackColor = SystemColors.MenuHighlight;
            listabtn.Cursor = Cursors.Hand;
            listabtn.FlatAppearance.BorderColor = Color.White;
            listabtn.FlatAppearance.BorderSize = 0;
            listabtn.FlatStyle = FlatStyle.Flat;
            listabtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listabtn.ForeColor = SystemColors.ControlLightLight;
            listabtn.Location = new Point(-1, 263);
            listabtn.Name = "listabtn";
            listabtn.Size = new Size(220, 39);
            listabtn.TabIndex = 15;
            listabtn.Text = "Listas de Items";
            listabtn.UseVisualStyleBackColor = false;
            listabtn.Click += listabtn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveBorder;
            panel6.Controls.Add(listabtn);
            panel6.Controls.Add(homebtn);
            panel6.Controls.Add(comprimirbtn);
            panel6.Controls.Add(logo);
            panel6.Location = new Point(13, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(218, 572);
            panel6.TabIndex = 14;
            // 
            // screen
            // 
            screen.BackColor = SystemColors.Control;
            screen.Location = new Point(249, 73);
            screen.Name = "screen";
            screen.Size = new Size(1053, 572);
            screen.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 675);
            Controls.Add(screen);
            Controls.Add(datelbl);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)cerrarbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox cerrarbtn;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Label datelbl;
        private PictureBox logo;
        private Button comprimirbtn;
        private Button homebtn;
        private Button listabtn;
        private Panel panel6;
        private Panel screen;
    }
}
