namespace UI_Casystem
{
    partial class UIRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIRegistro));
            panel1 = new Panel();
            inputPassword = new TextBox();
            inputEmail = new TextBox();
            inputNombre = new TextBox();
            linkLogin = new LinkLabel();
            btnIngresar = new Button();
            labelRegistrarse = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 28, 35);
            panel1.Controls.Add(inputPassword);
            panel1.Controls.Add(inputEmail);
            panel1.Controls.Add(inputNombre);
            panel1.Controls.Add(linkLogin);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(labelRegistrarse);
            panel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(488, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 2;
            // 
            // inputPassword
            // 
            inputPassword.BackColor = Color.FromArgb(64, 64, 64);
            inputPassword.BorderStyle = BorderStyle.None;
            inputPassword.Font = new Font("Tahoma", 14.25F);
            inputPassword.ForeColor = Color.White;
            inputPassword.Location = new Point(32, 245);
            inputPassword.Multiline = true;
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '•';
            inputPassword.PlaceholderText = "Contraseña";
            inputPassword.Size = new Size(347, 26);
            inputPassword.TabIndex = 8;
            inputPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // inputEmail
            // 
            inputEmail.BackColor = Color.FromArgb(64, 64, 64);
            inputEmail.BorderStyle = BorderStyle.None;
            inputEmail.Font = new Font("Tahoma", 14.25F);
            inputEmail.ForeColor = Color.White;
            inputEmail.Location = new Point(32, 188);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Email";
            inputEmail.Size = new Size(347, 26);
            inputEmail.TabIndex = 7;
            inputEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // inputNombre
            // 
            inputNombre.BackColor = Color.FromArgb(64, 64, 64);
            inputNombre.BorderStyle = BorderStyle.None;
            inputNombre.Font = new Font("Tahoma", 14.25F);
            inputNombre.ForeColor = Color.White;
            inputNombre.Location = new Point(32, 131);
            inputNombre.Multiline = true;
            inputNombre.Name = "inputNombre";
            inputNombre.PlaceholderText = "Nombre";
            inputNombre.RightToLeft = RightToLeft.No;
            inputNombre.Size = new Size(347, 26);
            inputNombre.TabIndex = 6;
            inputNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLogin
            // 
            linkLogin.ActiveLinkColor = Color.DodgerBlue;
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLogin.LinkColor = Color.White;
            linkLogin.Location = new Point(106, 372);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(230, 19);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "¿Ya tienes cuenta? Ingresa";
            linkLogin.VisitedLinkColor = Color.White;
            linkLogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(48, 108, 243);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(32, 317);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(347, 41);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // labelRegistrarse
            // 
            labelRegistrarse.AutoSize = true;
            labelRegistrarse.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistrarse.ForeColor = Color.White;
            labelRegistrarse.Location = new Point(150, 53);
            labelRegistrarse.Name = "labelRegistrarse";
            labelRegistrarse.Size = new Size(130, 33);
            labelRegistrarse.TabIndex = 0;
            labelRegistrarse.Text = "Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 327);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UIRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(914, 550);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UIRegistro";
            Text = "Registro";
            Load += UIRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox inputPassword;
        private TextBox inputEmail;
        private TextBox inputNombre;
        private LinkLabel linkLogin;
        private Button btnIngresar;
        private Label labelRegistrarse;
        private PictureBox pictureBox1;
    }
}