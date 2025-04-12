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
            Title = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(376, 177);
            Title.Name = "Title";
            Title.Size = new Size(152, 40);
            Title.TabIndex = 1;
            Title.Text = "CAsystem";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 293);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Porcentage de carga";
            // 
            // UICarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 550);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "UICarga";
            Text = "UICarga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
    }
}