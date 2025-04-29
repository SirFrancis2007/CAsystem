using System.Runtime.InteropServices;
using ControllerEntity;

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
            string nombre = inputNombre.Text;
            GetNombre(nombre);
            try
            {
                // enviar el nombre a CL
                Global.LDC.CreateObjLista(nombre);
                
                var insertado  = Global.LDC.MthAddNewList(nombre);
                if (insertado)
                {
                    MessageBox.Show($"Lista {nombre} fue creada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al crear la lista {nombre}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error al crear la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal string GetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(inputNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            return inputNombre.Text;
        }
    }
}
