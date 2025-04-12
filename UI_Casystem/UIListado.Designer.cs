namespace UI_Casystem
{
    partial class UIListado
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 554);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Hola {nombre}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(763, 26);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Hoy es: {dia}";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(24, 154);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar listado";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(24, 478);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cerrar sesion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 526);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Copyrigth 2025";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 117);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(665, 441);
            dataGridView1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 61);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Tablas";
            // 
            // UIListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 550);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UIListado";
            Text = "UIListado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
    }
}