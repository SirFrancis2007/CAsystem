namespace UI_Casystem
{
    partial class UINewList
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
            TxtBoxName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            Registrarse = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtBoxName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Registrarse);
            panel1.Location = new Point(272, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 417);
            panel1.TabIndex = 2;
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new Point(32, 134);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(348, 23);
            TxtBoxName.TabIndex = 6;
            TxtBoxName.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(32, 312);
            button1.Name = "button1";
            button1.Size = new Size(349, 32);
            button1.TabIndex = 4;
            button1.Text = "Añadir nuevo listado";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 95);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la lista";
            // 
            // Registrarse
            // 
            Registrarse.AutoSize = true;
            Registrarse.Location = new Point(161, 34);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(80, 15);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Nuevo listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 206);
            label2.Name = "label2";
            label2.Size = new Size(351, 15);
            label2.TabIndex = 7;
            label2.Text = "Recuerda que no se pueden repetir nombre de tablas prexistentes";
            // 
            // UINewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Name = "UINewList";
            Text = "UINewList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtBoxName;
        private Button button1;
        private Label label1;
        private Label Registrarse;
        private Label label2;
    }
}