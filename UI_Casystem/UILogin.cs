using ControllerEntity;
using Models;
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
    public partial class UILogin : Form
    {
        private LoginController _loginController;

        public UILogin()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private void UILogin_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            CenterToScreen();

            //BtnIngresar  
            btnIngresar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnIngresar.Width, btnIngresar.Height, 20, 20));
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderSize = 0;

            //TextBoxPassworld  
            inputPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, inputPassword.Width, inputPassword.Height, 7, 7));

            //TextBoxEmail  
            inputEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, inputEmail.Width, inputEmail.Height, 7, 7));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            UIRegistro uIRegistro = new UIRegistro();
            uIRegistro.Show();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;

            try
            {
                bool IngresoUsuario = _loginController.PassCredencial(email, password);
                if (IngresoUsuario)
                {
                    Hide();
                    UIListado InterfazListado = new();
                    InterfazListado.Show();
                }
                else
                {
                    MessageBox.Show("Error! No se pudo Ingresar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! No se pudo Ingresar: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
