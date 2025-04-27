namespace UI_Casystem
{
    partial class UILogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILogin));
            panel1 = new Panel();
            inputPassword = new TextBox();
            inputEmail = new TextBox();
            linkRegistro = new LinkLabel();
            btnIngresar = new Button();
            labelRegistro = new Label();
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
            panel1.Controls.Add(linkRegistro);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(labelRegistro);
            panel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(470, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // inputPassword
            // 
            inputPassword.BackColor = Color.FromArgb(64, 64, 64);
            inputPassword.BorderStyle = BorderStyle.None;
            inputPassword.Font = new Font("Tahoma", 14.25F);
            inputPassword.ForeColor = Color.White;
            inputPassword.Location = new Point(34, 182);
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
            inputEmail.Location = new Point(34, 125);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "E-mail";
            inputEmail.Size = new Size(347, 26);
            inputEmail.TabIndex = 7;
            inputEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // linkRegistro
            // 
            linkRegistro.ActiveLinkColor = Color.DodgerBlue;
            linkRegistro.AutoSize = true;
            linkRegistro.Cursor = Cursors.Hand;
            linkRegistro.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkRegistro.LinkBehavior = LinkBehavior.NeverUnderline;
            linkRegistro.LinkColor = Color.White;
            linkRegistro.Location = new Point(82, 377);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(255, 19);
            linkRegistro.TabIndex = 5;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "¿No tienes cuenta? Registrate";
            linkRegistro.TextAlign = ContentAlignment.MiddleCenter;
            linkRegistro.VisitedLinkColor = Color.White;
            linkRegistro.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(48, 108, 243);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.GhostWhite;
            btnIngresar.Location = new Point(34, 288);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(347, 41);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistro.ForeColor = Color.White;
            labelRegistro.Location = new Point(149, 52);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new Size(132, 33);
            labelRegistro.TabIndex = 0;
            labelRegistro.Text = "Ingresar";
            labelRegistro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(-12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 327);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UILogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(914, 550);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UILogin";
            Text = "Inicio de Sesión";
            Load += UILogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox inputPassword;
        private TextBox inputEmail;
        private LinkLabel linkRegistro;
        private Button btnIngresar;
        private Label labelRegistro;
        private PictureBox pictureBox1;
    }
}