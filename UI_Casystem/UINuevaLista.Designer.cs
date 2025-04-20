namespace UI_Casystem
{
    partial class UINuevaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UINuevaLista));
            panel1 = new Panel();
            inputNombre = new TextBox();
            btnNuevoListado = new Button();
            labelNombre = new Label();
            labelRegistrarse = new Label();
            iconVolver = new PictureBox();
            linkListado = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconVolver).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 31, 39);
            panel1.Controls.Add(inputNombre);
            panel1.Controls.Add(btnNuevoListado);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(labelRegistrarse);
            panel1.Location = new Point(20, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 390);
            panel1.TabIndex = 2;
            // 
            // inputNombre
            // 
            inputNombre.BackColor = Color.FromArgb(64, 64, 64);
            inputNombre.BorderStyle = BorderStyle.None;
            inputNombre.Font = new Font("Tahoma", 14.25F);
            inputNombre.ForeColor = Color.White;
            inputNombre.Location = new Point(32, 176);
            inputNombre.Name = "inputNombre";
            inputNombre.PlaceholderText = "Nombre";
            inputNombre.Size = new Size(347, 23);
            inputNombre.TabIndex = 6;
            // 
            // btnNuevoListado
            // 
            btnNuevoListado.BackColor = Color.FromArgb(48, 108, 243);
            btnNuevoListado.FlatStyle = FlatStyle.Flat;
            btnNuevoListado.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnNuevoListado.ForeColor = Color.White;
            btnNuevoListado.Location = new Point(32, 312);
            btnNuevoListado.Name = "btnNuevoListado";
            btnNuevoListado.Size = new Size(347, 41);
            btnNuevoListado.TabIndex = 4;
            btnNuevoListado.Text = "Añadir nuevo listado";
            btnNuevoListado.UseVisualStyleBackColor = false;
            btnNuevoListado.Click += btnNuevoListado_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(123, 145);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(158, 19);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre de la lista";
            // 
            // labelRegistrarse
            // 
            labelRegistrarse.AutoSize = true;
            labelRegistrarse.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistrarse.ForeColor = Color.White;
            labelRegistrarse.Location = new Point(105, 68);
            labelRegistrarse.Name = "labelRegistrarse";
            labelRegistrarse.Size = new Size(201, 33);
            labelRegistrarse.TabIndex = 0;
            labelRegistrarse.Text = "Nuevo listado";
            // 
            // iconVolver
            // 
            iconVolver.Cursor = Cursors.Hand;
            iconVolver.Image = (Image)resources.GetObject("iconVolver.Image");
            iconVolver.Location = new Point(14, 414);
            iconVolver.Name = "iconVolver";
            iconVolver.Size = new Size(25, 25);
            iconVolver.SizeMode = PictureBoxSizeMode.Zoom;
            iconVolver.TabIndex = 13;
            iconVolver.TabStop = false;
            iconVolver.Click += iconCerrarSesion_Click;
            // 
            // linkListado
            // 
            linkListado.ActiveLinkColor = Color.DodgerBlue;
            linkListado.AutoSize = true;
            linkListado.Cursor = Cursors.Hand;
            linkListado.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkListado.LinkBehavior = LinkBehavior.NeverUnderline;
            linkListado.LinkColor = Color.White;
            linkListado.Location = new Point(37, 417);
            linkListado.Name = "linkListado";
            linkListado.Size = new Size(61, 19);
            linkListado.TabIndex = 12;
            linkListado.TabStop = true;
            linkListado.Text = "Volver";
            linkListado.TextAlign = ContentAlignment.MiddleCenter;
            linkListado.VisitedLinkColor = Color.White;
            linkListado.LinkClicked += linkListado_LinkClicked;
            // 
            // UINuevaLista
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(448, 449);
            Controls.Add(iconVolver);
            Controls.Add(linkListado);
            Controls.Add(panel1);
            Name = "UINuevaLista";
            Text = "Crear Nueva Lista";
            Load += UINewList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox inputNombre;
        private Button btnNuevoListado;
        private Label labelNombre;
        private Label labelRegistrarse;
        private PictureBox iconVolver;
        private LinkLabel linkListado;
    }
}