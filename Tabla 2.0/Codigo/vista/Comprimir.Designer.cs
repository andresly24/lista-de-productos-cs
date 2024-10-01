namespace vista
{
    partial class Comprimir
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprimir));
            comprimirtxt = new Label();
            comprimirbtn = new Button();
            ziptb = new TextBox();
            label4 = new Label();
            archivetb = new TextBox();
            label3 = new Label();
            comprimirlabel = new Label();
            registrotb = new RichTextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            carpeta2btn = new PictureBox();
            carpetabtn = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carpeta2btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carpetabtn).BeginInit();
            SuspendLayout();
            // 
            // comprimirtxt
            // 
            comprimirtxt.AutoSize = true;
            comprimirtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comprimirtxt.Location = new Point(10, 42);
            comprimirtxt.Name = "comprimirtxt";
            comprimirtxt.Size = new Size(151, 17);
            comprimirtxt.TabIndex = 22;
            comprimirtxt.Text = "Comprimir archivo en ZIP";
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
            comprimirbtn.Location = new Point(890, 154);
            comprimirbtn.Name = "comprimirbtn";
            comprimirbtn.Size = new Size(129, 33);
            comprimirbtn.TabIndex = 21;
            comprimirbtn.Text = "Comprimir";
            comprimirbtn.UseVisualStyleBackColor = false;
            comprimirbtn.Click += comprimirbtn_Click;
            // 
            // ziptb
            // 
            ziptb.Font = new Font("Segoe UI", 9.75F);
            ziptb.ForeColor = Color.Gray;
            ziptb.Location = new Point(175, 116);
            ziptb.Name = "ziptb";
            ziptb.Size = new Size(817, 25);
            ziptb.TabIndex = 19;
            ziptb.Text = "C:\\\\";
            ziptb.Enter += ziptb_Enter;
            ziptb.Leave += ziptb_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(10, 116);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 18;
            label4.Text = "Path Output .zip";
            // 
            // archivetb
            // 
            archivetb.BackColor = Color.White;
            archivetb.Font = new Font("Segoe UI", 9.75F);
            archivetb.ForeColor = Color.Gray;
            archivetb.Location = new Point(175, 74);
            archivetb.Name = "archivetb";
            archivetb.Size = new Size(817, 25);
            archivetb.TabIndex = 17;
            archivetb.Text = "C:\\\\";
            archivetb.Enter += archivetb_Enter;
            archivetb.Leave += archivetb_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(10, 74);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "Path Input";
            // 
            // comprimirlabel
            // 
            comprimirlabel.AutoSize = true;
            comprimirlabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comprimirlabel.Location = new Point(10, 12);
            comprimirlabel.Name = "comprimirlabel";
            comprimirlabel.Size = new Size(110, 30);
            comprimirlabel.TabIndex = 15;
            comprimirlabel.Text = "Comprimir";
            // 
            // registrotb
            // 
            registrotb.BackColor = SystemColors.ControlLightLight;
            registrotb.BorderStyle = BorderStyle.None;
            registrotb.Location = new Point(19, 45);
            registrotb.Name = "registrotb";
            registrotb.Size = new Size(623, 276);
            registrotb.TabIndex = 23;
            registrotb.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 7);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 24;
            label1.Text = "Registro";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(registrotb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 344);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(carpeta2btn);
            panel2.Controls.Add(carpetabtn);
            panel2.Controls.Add(comprimirlabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(archivetb);
            panel2.Controls.Add(comprimirtxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comprimirbtn);
            panel2.Controls.Add(ziptb);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 201);
            panel2.TabIndex = 26;
            // 
            // carpeta2btn
            // 
            carpeta2btn.Cursor = Cursors.Hand;
            carpeta2btn.Image = (Image)resources.GetObject("carpeta2btn.Image");
            carpeta2btn.Location = new Point(997, 118);
            carpeta2btn.Name = "carpeta2btn";
            carpeta2btn.Size = new Size(22, 22);
            carpeta2btn.SizeMode = PictureBoxSizeMode.StretchImage;
            carpeta2btn.TabIndex = 24;
            carpeta2btn.TabStop = false;
            carpeta2btn.Click += carpeta2btn_Click;
            // 
            // carpetabtn
            // 
            carpetabtn.Cursor = Cursors.Hand;
            carpetabtn.Image = (Image)resources.GetObject("carpetabtn.Image");
            carpetabtn.Location = new Point(997, 75);
            carpetabtn.Name = "carpetabtn";
            carpetabtn.Size = new Size(22, 22);
            carpetabtn.SizeMode = PictureBoxSizeMode.StretchImage;
            carpetabtn.TabIndex = 23;
            carpetabtn.TabStop = false;
            carpetabtn.Click += carpetabtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 92);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 25;
            label2.Text = "Carpeta de archivos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 134);
            label5.Name = "label5";
            label5.Size = new Size(112, 17);
            label5.TabIndex = 26;
            label5.Text = "Carpeta de destino";
            // 
            // Comprimir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Comprimir";
            Size = new Size(1053, 572);
            Load += Comprimir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carpeta2btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)carpetabtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label comprimirtxt;
        private Button comprimirbtn;
        private TextBox ziptb;
        private Label label4;
        private TextBox archivetb;
        private Label label3;
        private Label comprimirlabel;
        private RichTextBox registrotb;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox carpetabtn;
        private PictureBox carpeta2btn;
        private Label label5;
        private Label label2;
    }
}
