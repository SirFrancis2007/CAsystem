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
            Title = new Label();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            PorcentajeCarga = new Label();
            TimePorcentajeCarga = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(371, 145);
            Title.Name = "Title";
            Title.Size = new Size(191, 50);
            Title.TabIndex = 1;
            Title.Text = "CAsystem";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 306);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Porcentage de carga";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(27, 31, 39);
            progressBar1.Location = new Point(0, 542);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(955, 18);
            progressBar1.TabIndex = 3;
            // 
            // PorcentajeCarga
            // 
            PorcentajeCarga.AutoSize = true;
            PorcentajeCarga.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PorcentajeCarga.ForeColor = Color.White;
            PorcentajeCarga.Location = new Point(423, 236);
            PorcentajeCarga.Name = "PorcentajeCarga";
            PorcentajeCarga.Size = new Size(83, 32);
            PorcentajeCarga.TabIndex = 4;
            PorcentajeCarga.Text = "label2";
            // 
            // TimePorcentajeCarga
            // 
            TimePorcentajeCarga.Tick += timer1_Tick;
            // 
            // UICarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(954, 561);
            ControlBox = false;
            Controls.Add(PorcentajeCarga);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "UICarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UICarga";
            Load += UICarga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private ProgressBar progressBar1;
        private Label PorcentajeCarga;
        private System.Windows.Forms.Timer TimePorcentajeCarga;
    }
}