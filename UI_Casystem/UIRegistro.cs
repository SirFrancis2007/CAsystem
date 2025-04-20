using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ControllerEntity;
using Models;

namespace UI_Casystem
{
    public partial class UIRegistro : Form
    {
        ControllerEntity.RegistroController _registroController;
        public UIRegistro()
        {
            InitializeComponent();
            _registroController = new RegistroController();
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private void UIRegistro_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            CenterToParent();
            btnIngresar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnIngresar.Width, btnIngresar.Height, 20, 20));
            inputNombre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, inputNombre.Width, inputNombre.Height, 20, 20));
            inputEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, inputEmail.Width, inputEmail.Height, 20, 20));
            inputPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, inputPassword.Width, inputPassword.Height, 20, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            UILogin uILogin = new UILogin();
            uILogin.Show();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = inputNombre.Text;
            string email = inputEmail.Text;
            string contraseña = inputPassword.Text;

            try
            {
                Usuario nuevoUsuario = _registroController.CreateObjectUser(nombre, email, contraseña);

                if (!_registroController.ValidateUser(nuevoUsuario))
                {
                    MessageBox.Show("Los datos no son válidos. Verificá los campos.");
                    return;
                }

                bool insertado = _registroController.AddNewUser(nuevoUsuario);

                if (insertado)
                {
                    UIListado InterfazListado = new UIListado();
                    InterfazListado.Show();
                    Close();
                }
                else
                    MessageBox.Show("No se pudo registrar el usuario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

    }
}
