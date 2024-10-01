namespace vista
{
    partial class listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listado));
            panel2 = new Panel();
            dlbtn = new PictureBox();
            dataGridView1 = new DataGridView();
            listatxt = new Label();
            panel5 = new Panel();
            eliminartodobtn = new Button();
            label12 = new Label();
            eliminarbtn = new Button();
            label11 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            agregarbtn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            preciotb = new TextBox();
            label4 = new Label();
            itemtb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            editarbtn = new Button();
            agregarbtn2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            preciotbE = new TextBox();
            label5 = new Label();
            itemtbE = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dlbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(dlbtn);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(listatxt);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 566);
            panel2.TabIndex = 12;
            // 
            // dlbtn
            // 
            dlbtn.Cursor = Cursors.Hand;
            dlbtn.ErrorImage = null;
            dlbtn.Image = (Image)resources.GetObject("dlbtn.Image");
            dlbtn.InitialImage = null;
            dlbtn.Location = new Point(644, 17);
            dlbtn.Name = "dlbtn";
            dlbtn.Size = new Size(19, 19);
            dlbtn.SizeMode = PictureBoxSizeMode.StretchImage;
            dlbtn.TabIndex = 5;
            dlbtn.TabStop = false;
            dlbtn.Click += dlbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(21, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(642, 505);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // listatxt
            // 
            listatxt.AutoSize = true;
            listatxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listatxt.Location = new Point(21, 9);
            listatxt.Name = "listatxt";
            listatxt.Size = new Size(183, 30);
            listatxt.TabIndex = 3;
            listatxt.Text = "Lista de Productos";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.InactiveBorder;
            panel5.Controls.Add(eliminartodobtn);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(eliminarbtn);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(699, 446);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 121);
            panel5.TabIndex = 14;
            // 
            // eliminartodobtn
            // 
            eliminartodobtn.BackColor = Color.Red;
            eliminartodobtn.Cursor = Cursors.Hand;
            eliminartodobtn.FlatAppearance.BorderColor = Color.White;
            eliminartodobtn.FlatAppearance.BorderSize = 0;
            eliminartodobtn.FlatStyle = FlatStyle.Flat;
            eliminartodobtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminartodobtn.ForeColor = SystemColors.ControlLightLight;
            eliminartodobtn.Location = new Point(181, 70);
            eliminartodobtn.Name = "eliminartodobtn";
            eliminartodobtn.Size = new Size(159, 33);
            eliminartodobtn.TabIndex = 14;
            eliminartodobtn.Text = "Eliminar TODO";
            eliminartodobtn.UseVisualStyleBackColor = false;
            eliminartodobtn.Click += eliminartodobtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 39);
            label12.Name = "label12";
            label12.Size = new Size(178, 17);
            label12.TabIndex = 13;
            label12.Text = "Seleccione la fila para eliminar";
            // 
            // eliminarbtn
            // 
            eliminarbtn.BackColor = Color.Red;
            eliminarbtn.Cursor = Cursors.Hand;
            eliminarbtn.FlatAppearance.BorderColor = Color.White;
            eliminarbtn.FlatAppearance.BorderSize = 0;
            eliminarbtn.FlatStyle = FlatStyle.Flat;
            eliminarbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarbtn.ForeColor = SystemColors.ControlLightLight;
            eliminarbtn.Location = new Point(15, 69);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(159, 33);
            eliminarbtn.TabIndex = 13;
            eliminarbtn.Text = "Eliminar";
            eliminarbtn.UseVisualStyleBackColor = false;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 9);
            label11.Name = "label11";
            label11.Size = new Size(87, 30);
            label11.TabIndex = 3;
            label11.Text = "Eliminar";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(agregarbtn);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(preciotb);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(itemtb);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(699, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 205);
            panel3.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 42);
            label13.Name = "label13";
            label13.Size = new Size(122, 17);
            label13.TabIndex = 13;
            label13.Text = "Agrege nuevos items";
            // 
            // agregarbtn
            // 
            agregarbtn.BackColor = Color.LimeGreen;
            agregarbtn.Cursor = Cursors.Hand;
            agregarbtn.FlatAppearance.BorderColor = Color.White;
            agregarbtn.FlatAppearance.BorderSize = 0;
            agregarbtn.FlatStyle = FlatStyle.Flat;
            agregarbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarbtn.ForeColor = SystemColors.ControlLightLight;
            agregarbtn.Location = new Point(15, 151);
            agregarbtn.Name = "agregarbtn";
            agregarbtn.Size = new Size(321, 33);
            agregarbtn.TabIndex = 10;
            agregarbtn.Text = "Agregar";
            agregarbtn.UseVisualStyleBackColor = false;
            agregarbtn.Click += agregarbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // preciotb
            // 
            preciotb.Font = new Font("Segoe UI", 9.75F);
            preciotb.ForeColor = Color.Gray;
            preciotb.Location = new Point(93, 113);
            preciotb.Name = "preciotb";
            preciotb.Size = new Size(243, 25);
            preciotb.TabIndex = 8;
            preciotb.Text = "Ingrese el Precio";
            preciotb.Enter += preciotb_Enter;
            preciotb.Leave += preciotb_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(15, 116);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // itemtb
            // 
            itemtb.BackColor = Color.White;
            itemtb.Font = new Font("Segoe UI", 9.75F);
            itemtb.ForeColor = Color.Gray;
            itemtb.Location = new Point(93, 71);
            itemtb.Name = "itemtb";
            itemtb.Size = new Size(243, 25);
            itemtb.TabIndex = 6;
            itemtb.Text = "Ingrese el Item";
            itemtb.Enter += itemtb_Enter;
            itemtb.Leave += itemtb_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(19, 73);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 3;
            label2.Text = "Agregar";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveBorder;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(editarbtn);
            panel4.Controls.Add(agregarbtn2);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(preciotbE);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(itemtbE);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(699, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 205);
            panel4.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 36);
            label8.Name = "label8";
            label8.Size = new Size(165, 17);
            label8.TabIndex = 12;
            label8.Text = "Seleccione la fila para editar";
            // 
            // editarbtn
            // 
            editarbtn.BackColor = Color.Gold;
            editarbtn.Cursor = Cursors.Hand;
            editarbtn.FlatAppearance.BorderColor = Color.White;
            editarbtn.FlatAppearance.BorderSize = 0;
            editarbtn.FlatStyle = FlatStyle.Flat;
            editarbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarbtn.ForeColor = SystemColors.ControlLightLight;
            editarbtn.Location = new Point(19, 151);
            editarbtn.Name = "editarbtn";
            editarbtn.Size = new Size(155, 33);
            editarbtn.TabIndex = 11;
            editarbtn.Text = "Editar";
            editarbtn.UseVisualStyleBackColor = false;
            editarbtn.Click += editarbtn_Click;
            // 
            // agregarbtn2
            // 
            agregarbtn2.BackColor = Color.LimeGreen;
            agregarbtn2.Cursor = Cursors.Hand;
            agregarbtn2.FlatAppearance.BorderColor = Color.White;
            agregarbtn2.FlatAppearance.BorderSize = 0;
            agregarbtn2.FlatStyle = FlatStyle.Flat;
            agregarbtn2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarbtn2.ForeColor = SystemColors.ControlLightLight;
            agregarbtn2.Location = new Point(181, 151);
            agregarbtn2.Name = "agregarbtn2";
            agregarbtn2.Size = new Size(155, 33);
            agregarbtn2.TabIndex = 10;
            agregarbtn2.Text = "Aceptar";
            agregarbtn2.UseVisualStyleBackColor = false;
            agregarbtn2.Click += agregarbtn2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 74);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(69, 115);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // preciotbE
            // 
            preciotbE.Font = new Font("Segoe UI", 9.75F);
            preciotbE.Location = new Point(93, 113);
            preciotbE.Name = "preciotbE";
            preciotbE.Size = new Size(243, 25);
            preciotbE.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(15, 116);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // itemtbE
            // 
            itemtbE.Font = new Font("Segoe UI", 9.75F);
            itemtbE.Location = new Point(93, 71);
            itemtbE.Name = "itemtbE";
            itemtbE.Size = new Size(243, 25);
            itemtbE.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(19, 73);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "Item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 9);
            label7.Name = "label7";
            label7.Size = new Size(66, 30);
            label7.TabIndex = 3;
            label7.Text = "Editar";
            // 
            // listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "listado";
            Size = new Size(1053, 572);
            Load += listado_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dlbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox dlbtn;
        private DataGridView dataGridView1;
        private Label listatxt;
        private Panel panel5;
        private Button eliminartodobtn;
        private Label label12;
        private Button eliminarbtn;
        private Label label11;
        private Panel panel3;
        private Label label13;
        private Button agregarbtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox preciotb;
        private Label label4;
        private TextBox itemtb;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Label label8;
        private Button editarbtn;
        private Button agregarbtn2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox preciotbE;
        private Label label5;
        private TextBox itemtbE;
        private Label label6;
        private Label label7;
    }
}
