﻿namespace UI_Casystem
{
    partial class Form2
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(TextBoxPassworld);
            panel1.Controls.Add(TextBoxEmail);
            panel1.Controls.Add(TxtBoxName);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Registrarse);
            panel1.Location = new Point(254, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 0;
            // 
            // Registrarse
            // 
            Registrarse.AutoSize = true;
            Registrarse.Location = new Point(173, 22);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(64, 15);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Registrarse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 146);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 234);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(32, 312);
            button1.Name = "button1";
            button1.Size = new Size(349, 32);
            button1.TabIndex = 4;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(136, 375);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ya tienes cuenta, Ingresá?";
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new Point(32, 91);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(348, 23);
            TxtBoxName.TabIndex = 6;
            TxtBoxName.Text = "Nombre";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(32, 184);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(347, 23);
            TextBoxEmail.TabIndex = 7;
            TextBoxEmail.Text = "Email";
            // 
            // TextBoxPassworld
            // 
            TextBoxPassworld.Location = new Point(33, 263);
            TextBoxPassworld.Name = "TextBoxPassworld";
            TextBoxPassworld.Size = new Size(341, 23);
            TextBoxPassworld.TabIndex = 8;
            TextBoxPassworld.Text = "*********";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Registrarse;
        private TextBox TextBoxPassworld;
        private TextBox TextBoxEmail;
        private TextBox TxtBoxName;
    }
}