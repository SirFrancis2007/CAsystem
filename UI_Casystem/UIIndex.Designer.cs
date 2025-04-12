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
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            panel1 = new Panel();
            linkLabel3 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(373, 119);
            Title.Name = "Title";
            Title.Size = new Size(152, 40);
            Title.TabIndex = 0;
            Title.Text = "CAsystem";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 90, 167);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 11.25F);
            button1.ForeColor = Color.GhostWhite;
            button1.Location = new Point(422, 294);
            button1.Name = "button1";
            button1.Size = new Size(186, 35);
            button1.TabIndex = 2;
            button1.Text = "Inicio Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 90, 167);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Verdana", 11.25F);
            button2.ForeColor = Color.GhostWhite;
            button2.Location = new Point(421, 233);
            button2.Name = "button2";
            button2.Size = new Size(187, 35);
            button2.TabIndex = 3;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(51, 12);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(123, 13);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Termino y condiciones";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.DisabledLinkColor = Color.Black;
            linkLabel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(200, 11);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 13);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Privacidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(792, 10);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "Copyrigth 2025";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(2, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 36);
            panel1.TabIndex = 8;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.DisabledLinkColor = Color.Black;
            linkLabel3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(794, 24);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(91, 13);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Sobre CAsystem";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(257, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 106);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // CAsystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(914, 550);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel3);
            Controls.Add(panel1);
            Controls.Add(Title);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "CAsystem";
            Text = "CAsystem";
            Load += CAsystem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label2;
        private Panel panel1;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox1;
    }
}
