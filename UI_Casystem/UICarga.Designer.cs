namespace UI_Casystem
{
    partial class UICarga
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UICarga));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            PorcentajeCarga = new Label();
            TimePorcentajeCarga = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 325);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Porcentage de carga";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(27, 31, 39);
            progressBar1.Location = new Point(89, 360);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(517, 18);
            progressBar1.TabIndex = 3;
            // 
            // PorcentajeCarga
            // 
            PorcentajeCarga.AutoSize = true;
            PorcentajeCarga.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PorcentajeCarga.ForeColor = Color.White;
            PorcentajeCarga.Location = new Point(295, 419);
            PorcentajeCarga.Name = "PorcentajeCarga";
            PorcentajeCarga.Size = new Size(145, 29);
            PorcentajeCarga.TabIndex = 4;
            PorcentajeCarga.Text = "Bienvenido";
            // 
            // TimePorcentajeCarga
            // 
            TimePorcentajeCarga.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(89, -55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(517, 350);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 450);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "skipear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UICarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(718, 485);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(PorcentajeCarga);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UICarga";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido ";
            Load += UICarga_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ProgressBar progressBar1;
        private Label PorcentajeCarga;
        private System.Windows.Forms.Timer TimePorcentajeCarga;
        private PictureBox pictureBox1;
        private Button button1;
    }
}