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
            label2 = new Label();
            TxtBoxName = new TextBox();
            btnNuevoListado = new Button();
            label1 = new Label();
            Registrarse = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 31, 39);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtBoxName);
            panel1.Controls.Add(btnNuevoListado);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Registrarse);
            panel1.Location = new Point(272, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 390);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 195);
            label2.Name = "label2";
            label2.Size = new Size(340, 38);
            label2.TabIndex = 7;
            label2.Text = "Recuerda que no se pueden repetir nombre\r\nde tablas prexistentes";
            // 
            // TxtBoxName
            // 
            TxtBoxName.BackColor = Color.FromArgb(29, 31, 33);
            TxtBoxName.BorderStyle = BorderStyle.None;
            TxtBoxName.Font = new Font("Arial", 12F);
            TxtBoxName.ForeColor = Color.White;
            TxtBoxName.Location = new Point(32, 134);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(348, 19);
            TxtBoxName.TabIndex = 6;
            TxtBoxName.Text = "Nombre";
            // 
            // btnNuevoListado
            // 
            btnNuevoListado.BackColor = Color.FromArgb(46, 55, 78);
            btnNuevoListado.FlatStyle = FlatStyle.Popup;
            btnNuevoListado.Font = new Font("Arial", 12F);
            btnNuevoListado.ForeColor = Color.White;
            btnNuevoListado.Location = new Point(32, 312);
            btnNuevoListado.Name = "btnNuevoListado";
            btnNuevoListado.Size = new Size(349, 32);
            btnNuevoListado.TabIndex = 4;
            btnNuevoListado.Text = "Añadir nuevo listado";
            btnNuevoListado.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 95);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la lista";
            // 
            // Registrarse
            // 
            Registrarse.AutoSize = true;
            Registrarse.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrarse.ForeColor = Color.White;
            Registrarse.Location = new Point(123, 23);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(169, 30);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Nuevo listado";
            // 
            // UINewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 39);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Name = "UINewList";
            Text = "UINewList";
            Load += UINewList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtBoxName;
        private Button btnNuevoListado;
        private Label label1;
        private Label Registrarse;
        private Label label2;
    }
}