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
            panel1 = new Panel();
            TextBoxPassworld = new TextBox();
            TextBoxEmail = new TextBox();
            TxtBoxName = new TextBox();
            linkLabel1 = new LinkLabel();
            BtnIngresar = new Button();
            Registrarse = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 31, 39);
            panel1.Controls.Add(TextBoxPassworld);
            panel1.Controls.Add(TextBoxEmail);
            panel1.Controls.Add(TxtBoxName);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(BtnIngresar);
            panel1.Controls.Add(Registrarse);
            panel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(250, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // TextBoxPassworld
            // 
            TextBoxPassworld.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxPassworld.BorderStyle = BorderStyle.None;
            TextBoxPassworld.ForeColor = Color.White;
            TextBoxPassworld.Location = new Point(33, 263);
            TextBoxPassworld.Multiline = true;
            TextBoxPassworld.Name = "TextBoxPassworld";
            TextBoxPassworld.PlaceholderText = "Contraseña";
            TextBoxPassworld.Size = new Size(341, 32);
            TextBoxPassworld.TabIndex = 8;
            TextBoxPassworld.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.ForeColor = Color.White;
            TextBoxEmail.Location = new Point(32, 180);
            TextBoxEmail.Multiline = true;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PlaceholderText = "Email";
            TextBoxEmail.Size = new Size(347, 35);
            TextBoxEmail.TabIndex = 7;
            TextBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtBoxName
            // 
            TxtBoxName.BackColor = Color.FromArgb(29, 31, 33);
            TxtBoxName.BorderStyle = BorderStyle.None;
            TxtBoxName.ForeColor = Color.White;
            TxtBoxName.Location = new Point(32, 91);
            TxtBoxName.Multiline = true;
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.PlaceholderText = "Nombre";
            TxtBoxName.RightToLeft = RightToLeft.No;
            TxtBoxName.Size = new Size(348, 37);
            TxtBoxName.TabIndex = 6;
            TxtBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(105, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(218, 19);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ya tienes cuenta, Ingresa?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(46, 55, 78);
            BtnIngresar.FlatStyle = FlatStyle.Popup;
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(32, 317);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(349, 32);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // Registrarse
            // 
            Registrarse.AutoSize = true;
            Registrarse.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrarse.ForeColor = Color.White;
            Registrarse.Location = new Point(148, 14);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(127, 33);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Registro";
            // 
            // UIRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "UIRegistro";
            Text = "UIRegistro";
            Load += UIRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TextBoxPassworld;
        private TextBox TextBoxEmail;
        private TextBox TxtBoxName;
        private LinkLabel linkLabel1;
        private Button BtnIngresar;
        private Label Registrarse;
    }
}