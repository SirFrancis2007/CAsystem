﻿namespace UI_Casystem
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
            panel1 = new Panel();
            TextBoxPassworld = new TextBox();
            TextBoxEmail = new TextBox();
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
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(BtnIngresar);
            panel1.Controls.Add(Registrarse);
            panel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(256, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 1;
            // 
            // TextBoxPassworld
            // 
            TextBoxPassworld.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxPassworld.BorderStyle = BorderStyle.None;
            TextBoxPassworld.ForeColor = Color.White;
            TextBoxPassworld.Location = new Point(32, 226);
            TextBoxPassworld.Multiline = true;
            TextBoxPassworld.Name = "TextBoxPassworld";
            TextBoxPassworld.Size = new Size(341, 32);
            TextBoxPassworld.TabIndex = 8;
            TextBoxPassworld.Text = "Contraseña";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.ForeColor = Color.White;
            TextBoxEmail.Location = new Point(32, 125);
            TextBoxEmail.Multiline = true;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(347, 35);
            TextBoxEmail.TabIndex = 7;
            TextBoxEmail.Text = "Email";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(93, 379);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(243, 19);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿No tienes cuenta, Registrate?";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(46, 55, 78);
            BtnIngresar.FlatStyle = FlatStyle.Popup;
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(32, 312);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(349, 32);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            // 
            // Registrarse
            // 
            Registrarse.AutoSize = true;
            Registrarse.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrarse.ForeColor = Color.White;
            Registrarse.Location = new Point(148, 14);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(125, 33);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Ingresar";
            // 
            // UILogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Name = "UILogin";
            Text = "Login";
            Load += UILogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TextBoxPassworld;
        private TextBox TextBoxEmail;
        private LinkLabel linkLabel1;
        private Button BtnIngresar;
        private Label Registrarse;
    }
}