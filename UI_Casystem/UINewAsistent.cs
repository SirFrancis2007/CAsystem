using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Casystem
{
    public partial class UINewAsistent : Form
    {
        public UINewAsistent()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private void UINewAsistent_Load(object sender, EventArgs e)
        {
            //BtnRegistro
            BtnRegistro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnRegistro.Width, BtnRegistro.Height, 20, 20));
            BtnRegistro.FlatStyle = FlatStyle.Flat;
            BtnRegistro.FlatAppearance.BorderSize = 0;
            BtnRegistro.BackColor = Color.FromArgb(46, 55, 78);
            BtnRegistro.ForeColor = Color.White;
            BtnRegistro.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
    }
}
