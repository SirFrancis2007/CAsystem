namespace UI_Casystem
{
    partial class UINuevaAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UINuevaAsistencia));
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            inputDepartamento = new TextBox();
            inputNombre = new TextBox();
            btnAgregarAsistencia = new Button();
            labelAgregarAsistencia = new Label();
            iconVolver = new PictureBox();
            linkListado = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconVolver).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 28, 35);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(inputDepartamento);
            panel1.Controls.Add(inputNombre);
            panel1.Controls.Add(btnAgregarAsistencia);
            panel1.Controls.Add(labelAgregarAsistencia);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 365);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(135, 226);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 23);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Asistencia";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // inputDepartamento
            // 
            inputDepartamento.BackColor = Color.FromArgb(64, 64, 64);
            inputDepartamento.BorderStyle = BorderStyle.None;
            inputDepartamento.Font = new Font("Tahoma", 14.25F);
            inputDepartamento.ForeColor = Color.White;
            inputDepartamento.Location = new Point(19, 180);
            inputDepartamento.Name = "inputDepartamento";
            inputDepartamento.PlaceholderText = "Departamento";
            inputDepartamento.Size = new Size(347, 23);
            inputDepartamento.TabIndex = 7;
            // 
            // inputNombre
            // 
            inputNombre.BackColor = Color.FromArgb(64, 64, 64);
            inputNombre.BorderStyle = BorderStyle.None;
            inputNombre.Font = new Font("Tahoma", 14.25F);
            inputNombre.ForeColor = Color.White;
            inputNombre.Location = new Point(19, 110);
            inputNombre.Name = "inputNombre";
            inputNombre.PlaceholderText = "Nombre";
            inputNombre.Size = new Size(347, 23);
            inputNombre.TabIndex = 6;
            // 
            // btnAgregarAsistencia
            // 
            btnAgregarAsistencia.BackColor = Color.FromArgb(48, 108, 243);
            btnAgregarAsistencia.FlatStyle = FlatStyle.Flat;
            btnAgregarAsistencia.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnAgregarAsistencia.ForeColor = Color.White;
            btnAgregarAsistencia.Location = new Point(19, 291);
            btnAgregarAsistencia.Name = "btnAgregarAsistencia";
            btnAgregarAsistencia.Size = new Size(347, 41);
            btnAgregarAsistencia.TabIndex = 4;
            btnAgregarAsistencia.Text = "Agregar";
            btnAgregarAsistencia.UseVisualStyleBackColor = false;
            btnAgregarAsistencia.Click += btnAgregarAsistencia_Click;
            // 
            // labelAgregarAsistencia
            // 
            labelAgregarAsistencia.AutoSize = true;
            labelAgregarAsistencia.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarAsistencia.ForeColor = Color.White;
            labelAgregarAsistencia.Location = new Point(68, 40);
            labelAgregarAsistencia.Name = "labelAgregarAsistencia";
            labelAgregarAsistencia.Size = new Size(267, 33);
            labelAgregarAsistencia.TabIndex = 0;
            labelAgregarAsistencia.Text = "Agregar Asistencia";
            // 
            // iconVolver
            // 
            iconVolver.Cursor = Cursors.Hand;
            iconVolver.Image = (Image)resources.GetObject("iconVolver.Image");
            iconVolver.Location = new Point(18, 391);
            iconVolver.Name = "iconVolver";
            iconVolver.Size = new Size(25, 25);
            iconVolver.SizeMode = PictureBoxSizeMode.Zoom;
            iconVolver.TabIndex = 15;
            iconVolver.TabStop = false;
            iconVolver.Click += iconVolver_Click;
            // 
            // linkListado
            // 
            linkListado.ActiveLinkColor = Color.DodgerBlue;
            linkListado.AutoSize = true;
            linkListado.Cursor = Cursors.Hand;
            linkListado.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkListado.LinkBehavior = LinkBehavior.NeverUnderline;
            linkListado.LinkColor = Color.White;
            linkListado.Location = new Point(41, 394);
            linkListado.Name = "linkListado";
            linkListado.Size = new Size(61, 19);
            linkListado.TabIndex = 14;
            linkListado.TabStop = true;
            linkListado.Text = "Volver";
            linkListado.TextAlign = ContentAlignment.MiddleCenter;
            linkListado.VisitedLinkColor = Color.White;
            linkListado.LinkClicked += linkListado_LinkClicked;
            // 
            // UINuevaAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(422, 440);
            Controls.Add(iconVolver);
            Controls.Add(linkListado);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UINuevaAsistencia";
            Text = "Nueva asistencia";
            Load += UINewAsistent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private TextBox inputDepartamento;
        private TextBox inputNombre;
        private Button btnAgregarAsistencia;
        private Label labelAgregarAsistencia;
        private PictureBox iconVolver;
        private LinkLabel linkListado;
    }
}