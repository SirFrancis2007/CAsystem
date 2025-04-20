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
    public partial class UINuevaLista : Form
    {
        public UINuevaLista()
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
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            CenterToParent();
            btnNuevoListado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNuevoListado.Width, btnNuevoListado.Height, 20, 20));
            inputNombre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, inputNombre.Width, inputNombre.Height, 7, 7));
        }

        private void linkListado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void iconCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevoListado_Click(object sender, EventArgs e)
        {

        }
    }
}
