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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIListado));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelAside = new Panel();
            iconCerrarSesion = new PictureBox();
            linkLogout = new LinkLabel();
            pictureBox1 = new PictureBox();
            labelFecha = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            labelSaludo = new Label();
            dgvPrincipal = new DataGridView();
            label4 = new Label();
            iconNuevaLista = new PictureBox();
            linkNuevaLista = new LinkLabel();
            button1 = new Button();
            panelAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconNuevaLista).BeginInit();
            SuspendLayout();
            // 
            // panelAside
            // 
            panelAside.BackColor = Color.FromArgb(27, 31, 39);
            panelAside.Controls.Add(button1);
            panelAside.Controls.Add(iconCerrarSesion);
            panelAside.Controls.Add(linkLogout);
            panelAside.Controls.Add(pictureBox1);
            panelAside.Controls.Add(labelFecha);
            panelAside.Controls.Add(label3);
            panelAside.Controls.Add(linkLabel1);
            panelAside.Location = new Point(0, 0);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(204, 554);
            panelAside.TabIndex = 0;
            // 
            // iconCerrarSesion
            // 
            iconCerrarSesion.Cursor = Cursors.Hand;
            iconCerrarSesion.Image = (Image)resources.GetObject("iconCerrarSesion.Image");
            iconCerrarSesion.Location = new Point(32, 463);
            iconCerrarSesion.Name = "iconCerrarSesion";
            iconCerrarSesion.Size = new Size(25, 25);
            iconCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            iconCerrarSesion.TabIndex = 11;
            iconCerrarSesion.TabStop = false;
            // 
            // linkLogout
            // 
            linkLogout.ActiveLinkColor = Color.DodgerBlue;
            linkLogout.AutoSize = true;
            linkLogout.Cursor = Cursors.Hand;
            linkLogout.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLogout.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLogout.LinkColor = Color.White;
            linkLogout.Location = new Point(50, 466);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(117, 19);
            linkLogout.TabIndex = 10;
            linkLogout.TabStop = true;
            linkLogout.Text = "Cerrar sesion";
            linkLogout.TextAlign = ContentAlignment.MiddleCenter;
            linkLogout.VisitedLinkColor = Color.White;
            linkLogout.LinkClicked += linkLogout_LinkClicked;
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
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(12, 209);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(119, 19);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "Hoy es: {dia}";
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
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Purple;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(40, 154);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 19);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar listado";
            // 
            // labelSaludo
            // 
            labelSaludo.AutoSize = true;
            labelSaludo.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelSaludo.ForeColor = Color.White;
            labelSaludo.Location = new Point(227, 42);
            labelSaludo.Name = "labelSaludo";
            labelSaludo.Size = new Size(143, 19);
            labelSaludo.TabIndex = 1;
            labelSaludo.Text = "Hola, {nombre}.";
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.AllowUserToAddRows = false;
            dgvPrincipal.AllowUserToDeleteRows = false;
            dgvPrincipal.BackgroundColor = Color.FromArgb(24, 28, 35);
            dgvPrincipal.BorderStyle = BorderStyle.None;
            dgvPrincipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(227, 154);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.ReadOnly = true;
            dgvPrincipal.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrincipal.Size = new Size(665, 380);
            dgvPrincipal.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(227, 103);
            label4.Name = "label4";
            label4.Size = new Size(184, 29);
            label4.TabIndex = 4;
            label4.Text = "Listas Creadas";
            // 
            // iconNuevaLista
            // 
            iconNuevaLista.Cursor = Cursors.Hand;
            iconNuevaLista.Image = Properties.Resources.add;
            iconNuevaLista.Location = new Point(740, 111);
            iconNuevaLista.Name = "iconNuevaLista";
            iconNuevaLista.Size = new Size(25, 25);
            iconNuevaLista.SizeMode = PictureBoxSizeMode.Zoom;
            iconNuevaLista.TabIndex = 13;
            iconNuevaLista.TabStop = false;
            iconNuevaLista.Click += iconNuevaLista_Click;
            // 
            // linkNuevaLista
            // 
            linkNuevaLista.ActiveLinkColor = Color.DodgerBlue;
            linkNuevaLista.AutoSize = true;
            linkNuevaLista.Cursor = Cursors.Hand;
            linkNuevaLista.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkNuevaLista.LinkBehavior = LinkBehavior.NeverUnderline;
            linkNuevaLista.LinkColor = Color.White;
            linkNuevaLista.Location = new Point(753, 114);
            linkNuevaLista.Name = "linkNuevaLista";
            linkNuevaLista.Size = new Size(139, 19);
            linkNuevaLista.TabIndex = 12;
            linkNuevaLista.TabStop = true;
            linkNuevaLista.Text = "Agregar Listado";
            linkNuevaLista.TextAlign = ContentAlignment.MiddleCenter;
            linkNuevaLista.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(35, 262);
            button1.Name = "button1";
            button1.Size = new Size(132, 33);
            button1.TabIndex = 12;
            button1.Text = "listadoAsistencia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UIListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 28);
            ClientSize = new Size(914, 550);
            Controls.Add(iconNuevaLista);
            Controls.Add(label4);
            Controls.Add(linkNuevaLista);
            Controls.Add(dgvPrincipal);
            Controls.Add(panelAside);
            Controls.Add(labelSaludo);
            Name = "UIListado";
            Text = "Inicio";
            Load += UIListado_Load;
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconNuevaLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAside;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label labelSaludo;
        private Label labelFecha;
        private DataGridView dgvPrincipal;
        private Label label4;
        private PictureBox iconCerrarSesion;
        private LinkLabel linkLogout;
        private PictureBox iconNuevaLista;
        private LinkLabel linkNuevaLista;
        private Button button1;
    }
}