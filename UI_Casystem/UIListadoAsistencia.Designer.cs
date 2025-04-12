namespace UI_Casystem
{
    partial class UIListadoAsistencia
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            linkLabel3 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(665, 441);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 554);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 117);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(24, 154);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar Asistencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 36);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre de lista: {nombre lista}";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(27, 191);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(96, 15);
            linkLabel3.TabIndex = 4;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Listado de Tablas";
            // 
            // UIListadoAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 550);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UIListadoAsistencia";
            Text = "UIListadoAsistencia";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}