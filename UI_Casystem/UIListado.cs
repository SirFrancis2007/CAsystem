using ControllerEntity;
using System.Data;

namespace UI_Casystem
{
    public partial class UIListado : Form
    {
        string Nombre = Global.CurrentUser.Nombre;
        public UIListado()
        {
            InitializeComponent();
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.DataSource = null;
                dgvListado.Rows.Clear();
                dgvListado.Columns.Clear();
            }

            button1.Visible = false;
        }

        private void UIListado_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            labelFecha.Text = $"Hoy es: {DateTime.Now:dd/MM/yyyy}";
            labelSaludo.Text = $"¡Bienvenido a CAsystem!";

            // cada vez que se carga la ventana, se cargan los datos
            dgvListado.DataSource = null;
            dgvListado.Rows.Clear();
            dgvListado.Columns.Clear();

            CargarDatosListado();
            dgvListado.Columns["idLista"].Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UINuevaLista uINuevaLista = new();
            uINuevaLista.ShowDialog();
        }

        private void iconNuevaLista_Click(object sender, EventArgs e)
        {
            UINuevaLista uINuevaLista = new();
            uINuevaLista.ShowDialog();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIIndex uIIndex = new();
            uIIndex.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UIListadoAsistencia uIListadoAsistencia = new();
            //uIListadoAsistencia.Show();
            //Close();
        }

        private void iconCerrarSesion_Click(object sender, EventArgs e)
        {
            UIIndex uIIndex = new();
            uIIndex.Show();
            Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvListado.Rows[e.RowIndex];

                string NombreTabla = filaSeleccionada.Cells["NombreLista"].Value.ToString();
                uint idListado = (uint)Convert.ToInt32(filaSeleccionada.Cells["IdLista"].Value);

                Global.CurrentListId = (uint)idListado;

                Hide();
                UIListadoAsistencia listadoAsistencia = new UIListadoAsistencia(NombreTabla, idListado);
                listadoAsistencia.Show();
            }
        }


        private void CargarDatosListado ()
        {
            try
            {
                if (dgvListado.Rows.Count > 0)
                {
                    dgvListado.DataSource = null;
                    dgvListado.Rows.Clear();
                    dgvListado.Columns.Clear();
                }
                DataTable ResultadosListado = Global.LDC.MthGetList();
                // carga en el datagridview
                dgvListado.DataSource = ResultadosListado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los datos del Gran Premio: " + ex.Message);
            }
        }
    }
}
