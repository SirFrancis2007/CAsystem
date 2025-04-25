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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIListadoAsistencia));
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            labelNombreLista = new Label();
            pictureBox1 = new PictureBox();
            panelAside = new Panel();
            iconVolver = new PictureBox();
            pictureBox3 = new PictureBox();
            linkListado = new LinkLabel();
            linkLogout = new LinkLabel();
            label3 = new Label();
            linkLabel3 = new LinkLabel();
            pictureBox2 = new PictureBox();
            labelFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(24, 28, 35);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(665, 429);
            dataGridView1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(740, 55);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 19);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar Asistencia";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // labelNombreLista
            // 
            labelNombreLista.AutoSize = true;
            labelNombreLista.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreLista.ForeColor = Color.White;
            labelNombreLista.Location = new Point(227, 42);
            labelNombreLista.Name = "labelNombreLista";
            labelNombreLista.Size = new Size(182, 19);
            labelNombreLista.TabIndex = 6;
            labelNombreLista.Text = "*Nombre de la Lista*";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelAside
            // 
            panelAside.BackColor = Color.FromArgb(27, 31, 39);
            panelAside.Controls.Add(iconVolver);
            panelAside.Controls.Add(pictureBox3);
            panelAside.Controls.Add(linkListado);
            panelAside.Controls.Add(linkLogout);
            panelAside.Controls.Add(pictureBox1);
            panelAside.Controls.Add(label3);
            panelAside.Controls.Add(linkLabel3);
            panelAside.Location = new Point(0, 0);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(208, 552);
            panelAside.TabIndex = 7;
            // 
            // iconVolver
            // 
            iconVolver.Cursor = Cursors.Hand;
            iconVolver.Image = (Image)resources.GetObject("iconVolver.Image");
            iconVolver.Location = new Point(17, 260);
            iconVolver.Name = "iconVolver";
            iconVolver.Size = new Size(25, 25);
            iconVolver.SizeMode = PictureBoxSizeMode.Zoom;
            iconVolver.TabIndex = 17;
            iconVolver.TabStop = false;
            iconVolver.Click += iconVolver_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 463);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // linkListado
            // 
            linkListado.ActiveLinkColor = Color.DodgerBlue;
            linkListado.AutoSize = true;
            linkListado.Cursor = Cursors.Hand;
            linkListado.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkListado.LinkBehavior = LinkBehavior.NeverUnderline;
            linkListado.LinkColor = Color.White;
            linkListado.Location = new Point(40, 263);
            linkListado.Name = "linkListado";
            linkListado.Size = new Size(61, 19);
            linkListado.TabIndex = 16;
            linkListado.TabStop = true;
            linkListado.Text = "Volver";
            linkListado.TextAlign = ContentAlignment.MiddleCenter;
            linkListado.VisitedLinkColor = Color.White;
            linkListado.Click += linkListado_Click;
            // 
            // linkLogout
            // 
            linkLogout.ActiveLinkColor = Color.DodgerBlue;
            linkLogout.AutoSize = true;
            linkLogout.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLogout.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLogout.LinkColor = Color.White;
            linkLogout.Location = new Point(50, 466);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(117, 19);
            linkLogout.TabIndex = 4;
            linkLogout.TabStop = true;
            linkLogout.Text = "Cerrar sesion";
            linkLogout.TextAlign = ContentAlignment.MiddleCenter;
            linkLogout.VisitedLinkColor = Color.White;
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(45, 527);
            label3.Name = "label3";
            label3.Size = new Size(109, 13);
            label3.TabIndex = 2;
            label3.Text = "© CASystem 2025";
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Purple;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Arial", 12F, FontStyle.Bold);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(40, 154);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(125, 19);
            linkLabel3.TabIndex = 0;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Agregar listado";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.add;
            pictureBox2.Location = new Point(727, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = Color.FromArgb(27, 31, 39);
            labelFecha.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(12, 209);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(119, 19);
            labelFecha.TabIndex = 9;
            labelFecha.Text = "Hoy es: {dia}";
            // 
            // UIListadoAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 28);
            ClientSize = new Size(914, 550);
            Controls.Add(labelFecha);
            Controls.Add(pictureBox2);
            Controls.Add(panelAside);
            Controls.Add(labelNombreLista);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Name = "UIListadoAsistencia";
            Text = "Nombre de la lista aquí";
            Load += UIListadoAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private Label labelNombreLista;
        private PictureBox pictureBox1;
        private Panel panelAside;
        private LinkLabel linkLogout;
        private Label label3;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelFecha;
        private PictureBox iconVolver;
        private LinkLabel linkListado;
    }
}