namespace UI_Casystem
{
    partial class UINewAsistent
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
            checkBox1 = new CheckBox();
            TextBoxEmail = new TextBox();
            TxtBoxName = new TextBox();
            linkLabel1 = new LinkLabel();
            BtnRegistro = new Button();
            Registrarse = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 31, 39);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(TextBoxEmail);
            panel1.Controls.Add(TxtBoxName);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(BtnRegistro);
            panel1.Controls.Add(Registrarse);
            panel1.Location = new Point(250, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Font = new Font("Arial", 12F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(32, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 23);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Asistencia";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.Font = new Font("Arial", 12F, FontStyle.Bold);
            TextBoxEmail.ForeColor = Color.White;
            TextBoxEmail.Location = new Point(32, 184);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(347, 19);
            TextBoxEmail.TabIndex = 7;
            TextBoxEmail.Text = "Departamento";
            // 
            // TxtBoxName
            // 
            TxtBoxName.BackColor = Color.FromArgb(29, 31, 33);
            TxtBoxName.BorderStyle = BorderStyle.None;
            TxtBoxName.Font = new Font("Arial", 12F, FontStyle.Bold);
            TxtBoxName.ForeColor = Color.White;
            TxtBoxName.Location = new Point(32, 91);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(348, 19);
            TxtBoxName.TabIndex = 6;
            TxtBoxName.Text = "Nombre";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(107, 376);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(218, 19);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ya tienes cuenta, Ingresá?";
            // 
            // BtnRegistro
            // 
            BtnRegistro.BackColor = Color.FromArgb(46, 55, 78);
            BtnRegistro.FlatStyle = FlatStyle.Popup;
            BtnRegistro.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            BtnRegistro.ForeColor = Color.White;
            BtnRegistro.Location = new Point(32, 312);
            BtnRegistro.Name = "BtnRegistro";
            BtnRegistro.Size = new Size(349, 32);
            BtnRegistro.TabIndex = 4;
            BtnRegistro.Text = "Registrarse";
            BtnRegistro.UseVisualStyleBackColor = false;
            // 
            // Registrarse
            // 
            Registrarse.AutoSize = true;
            Registrarse.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrarse.ForeColor = Color.White;
            Registrarse.Location = new Point(123, 14);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(170, 40);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Registrarse";
            // 
            // UINewAsistent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Name = "UINewAsistent";
            Text = "UINewAsistent";
            Load += UINewAsistent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private TextBox TextBoxEmail;
        private TextBox TxtBoxName;
        private LinkLabel linkLabel1;
        private Button BtnRegistro;
        private Label Registrarse;
    }
}