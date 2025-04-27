using System.Runtime.InteropServices;
using ControllerEntity;

namespace UI_Casystem
{
    public partial class UINuevaAsistencia : Form
    {
        public UINuevaAsistencia()
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
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            CenterToParent();
            btnAgregarAsistencia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAgregarAsistencia.Width, btnAgregarAsistencia.Height, 20, 20));
        }

        private void iconVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkListado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnAgregarAsistencia_Click(object sender, EventArgs e)
        {
            GetContent();
            // Guardar la asistencia
            bool insertado = Global.AC.SaveAsistencia(Global.AsistenciaModel);
            if (insertado)
            {
                //MessageBox.Show("Asistencia guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar la asistencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetContent()
        {
            string nombre = inputNombre.Text;
            string departamente = inputDepartamento.Text;
            bool asistencia = checkBox1.Checked; // check de asistencia

            // Validar los campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(departamente))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            Global.AC.CreateObjAsistencia(nombre, departamente, asistencia);
        }
    }
}
