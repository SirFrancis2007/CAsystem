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
            BtnIngresar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnIngresar.Width, BtnIngresar.Height, 20, 20));
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.BackColor = Color.FromArgb(46, 55, 78);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            TxtBoxName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtBoxName.Width, TxtBoxName.Height, 20, 20));
            TxtBoxName.BackColor = Color.FromArgb(29, 31, 33);
            TxtBoxName.ForeColor = Color.White;
            TxtBoxName.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            //TextBoxEmail
            TextBoxEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxEmail.Width, TextBoxEmail.Height, 20, 20));
            TextBoxEmail.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxEmail.ForeColor = Color.White;
            TextBoxEmail.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            //TextBoxPassworld
            TextBoxPassworld.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxPassworld.Width, TextBoxPassworld.Height, 20, 20));
            TextBoxPassworld.BackColor = Color.FromArgb(29, 31, 33);
            TextBoxPassworld.ForeColor = Color.White;
            TextBoxPassworld.Font = new Font("Segoe UI", 10, FontStyle.Bold);
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
            string nombre = TxtBoxName.Text;
            string email = TextBoxEmail.Text;
            string contraseña = TextBoxPassworld.Text;

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
