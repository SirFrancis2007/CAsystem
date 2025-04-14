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
    public partial class UINewList : Form
    {
        public UINewList()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private void UINewList_Load(object sender, EventArgs e)
        {
            btnNuevoListado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNuevoListado.Width, btnNuevoListado.Height, 20, 20));
            btnNuevoListado.FlatStyle = FlatStyle.Flat;
            btnNuevoListado.FlatAppearance.BorderSize = 0;
            btnNuevoListado.BackColor = Color.FromArgb(46, 55, 78);
            btnNuevoListado.ForeColor = Color.White;
            btnNuevoListado.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            TxtBoxName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtBoxName.Width, TxtBoxName.Height, 20, 20));
            TxtBoxName.BackColor = Color.FromArgb(29, 31, 33);
            TxtBoxName.ForeColor = Color.White;
            TxtBoxName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
    }
}
