using System.Runtime.InteropServices;

namespace UI_Casystem
{
    public partial class UIIndex : Form
    {
        public UIIndex()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CAsystem_Load(object sender, EventArgs e)
        {
            btnRegistro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegistro.Width, btnRegistro.Height, 15, 15));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 15, 15));
            btnSalir.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSalir.Width, btnSalir.Height, 7, 7));
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Hide();
            UILogin UILogin = new();
            UILogin.Show();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            UIRegistro UIRegistro = new();
            UIRegistro.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
