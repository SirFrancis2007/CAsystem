namespace UI_Casystem
{
    partial class UIIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIIndex));
            btnLogin = new Button();
            btnRegistro = new Button();
            labelCopyright = new Label();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(48, 108, 243);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(632, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(217, 56);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnIngresar_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(48, 108, 243);
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnRegistro.ForeColor = Color.GhostWhite;
            btnRegistro.Location = new Point(631, 202);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(218, 56);
            btnRegistro.TabIndex = 3;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCopyright.ForeColor = Color.FromArgb(176, 176, 176);
            labelCopyright.Location = new Point(29, 524);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(103, 14);
            labelCopyright.TabIndex = 7;
            labelCopyright.Text = "© CASystem 2025";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(63, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(48, 108, 243);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(847, 514);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 30);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // UIIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(954, 561);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(labelCopyright);
            Controls.Add(btnRegistro);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "UIIndex";
            Text = "CAsystem";
            Load += CAsystem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Button btnRegistro;
        private Label labelCopyright;
        private PictureBox pictureBox1;
        private Button btnSalir;
    }
}
