using System.Runtime.InteropServices;

namespace UI_Casystem
{
    public partial class CAsystem : Form
    {
        public CAsystem()
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
            BtnRegistro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnRegistro.Width, BtnRegistro.Height, 20, 20));
            BtnRegistro.FlatStyle = FlatStyle.Flat;
            BtnRegistro.FlatAppearance.BorderSize = 0;
            BtnRegistro.BackColor = Color.FromArgb(48, 108, 243);
            BtnRegistro.ForeColor = Color.White;
            BtnRegistro.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btnIngresar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnRegistro.Width, BtnRegistro.Height, 20, 20));
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.BackColor = Color.FromArgb(48, 108, 243);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
