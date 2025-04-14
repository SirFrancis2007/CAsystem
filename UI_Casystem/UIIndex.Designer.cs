namespace UI_Casystem
{
    partial class CAsystem
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
            Title = new Label();
            btnIngresar = new Button();
            BtnRegistro = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            panel1 = new Panel();
            linkLabel3 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(369, 143);
            Title.Name = "Title";
            Title.Size = new Size(191, 50);
            Title.TabIndex = 0;
            Title.Text = "CAsystem";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(48, 89, 233);
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Verdana", 11.25F);
            btnIngresar.ForeColor = Color.GhostWhite;
            btnIngresar.Location = new Point(373, 307);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(186, 35);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Inicio Sesion";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button1_Click;
            // 
            // BtnRegistro
            // 
            BtnRegistro.BackColor = Color.FromArgb(48, 89, 233);
            BtnRegistro.FlatStyle = FlatStyle.Popup;
            BtnRegistro.Font = new Font("Verdana", 11.25F);
            BtnRegistro.ForeColor = Color.GhostWhite;
            BtnRegistro.Location = new Point(373, 249);
            BtnRegistro.Name = "BtnRegistro";
            BtnRegistro.Size = new Size(187, 35);
            BtnRegistro.TabIndex = 3;
            BtnRegistro.Text = "Registrarse";
            BtnRegistro.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 192, 0);
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.DisabledLinkColor = Color.FromArgb(176, 176, 176);
            linkLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            linkLabel1.ForeColor = Color.FromArgb(176, 176, 176);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = SystemColors.ButtonFace;
            linkLabel1.Location = new Point(190, 12);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 13);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Termino y condiciones";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 192, 0);
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.DisabledLinkColor = Color.FromArgb(176, 176, 176);
            linkLabel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            linkLabel2.ForeColor = Color.FromArgb(176, 176, 176);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = SystemColors.ButtonFace;
            linkLabel2.Location = new Point(371, 12);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 13);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Privacidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(636, 12);
            label2.Name = "label2";
            label2.Size = new Size(88, 14);
            label2.TabIndex = 7;
            label2.Text = "Copyrigth 2025";
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(2, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 36);
            panel1.TabIndex = 8;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(176, 176, 176);
            linkLabel3.Location = new Point(490, 12);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(91, 13);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Sobre CAsystem";
            // 
            // CAsystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(954, 561);
            Controls.Add(panel1);
            Controls.Add(Title);
            Controls.Add(BtnRegistro);
            Controls.Add(btnIngresar);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "CAsystem";
            Text = "CAsystem";
            Load += CAsystem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button btnIngresar;
        private Button BtnRegistro;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label2;
        private Panel panel1;
        private LinkLabel linkLabel3;
    }
}
