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
            //BtnIngresar  
            BtnIngresar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnIngresar.Width, BtnIngresar.Height, 20, 20));
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.BackColor = Color.FromArgb(46, 55, 78);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            //TextBoxPassworld  
            TextBoxPassworld.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxPassworld.Width, TextBoxPassworld.Height, 20, 20));
            TextBoxPassworld.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxPassworld.ForeColor = Color.White;
            TextBoxPassworld.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            //TextBoxEmail  
            TextBoxEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxEmail.Width, TextBoxEmail.Height, 20, 20));
            TextBoxEmail.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxEmail.ForeColor = Color.White;
            TextBoxEmail.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            UIRegistro uIRegistro = new UIRegistro();
            uIRegistro.Show();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string password = TextBoxPassworld.Text;

            try
            {
                // Use the instance of LoginController to call PassCredencial  
                bool IngresoUsuario = _loginController.PassCredencial(email, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! No se pudo Ingresar: {ex.Message}");
            }
        }
    }
}
