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
            comprimirtxt = new Label();
            comprimirbtn = new Button();
            ziptb = new TextBox();
            label4 = new Label();
            archivetb = new TextBox();
            label3 = new Label();
            comprimirlabel = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            comprimirbtn.Location = new Point(890, 150);
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
            ziptb.Location = new Point(175, 109);
            ziptb.Name = "ziptb";
            ziptb.Size = new Size(844, 25);
            ziptb.TabIndex = 19;
            ziptb.Text = "C:\\\\";
            ziptb.Enter += ziptb_Enter;
            ziptb.Leave += ziptb_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(10, 109);
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
            archivetb.Location = new Point(175, 67);
            archivetb.Name = "archivetb";
            archivetb.Size = new Size(844, 25);
            archivetb.TabIndex = 17;
            archivetb.Text = "C:\\\\";
            archivetb.Enter += archivetb_Enter;
            archivetb.Leave += archivetb_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(10, 67);
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
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLightLight;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(19, 45);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(623, 276);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
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
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 344);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
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
        private RichTextBox richTextBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
