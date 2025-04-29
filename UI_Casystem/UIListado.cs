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
            LimpiarDataGridView();
            button1.Visible = false;
        }

        private void UIListado_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            labelFecha.Text = $"Hoy es: {DateTime.Now:dd/MM/yyyy}";
            labelSaludo.Text = $"¡Bienvenido a CAsystem!";

            LimpiarDataGridView();
            CargarDatosListado();
            dgvListado.Columns["idLista"].Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UINuevaLista uINuevaLista = new();
            if (uINuevaLista.ShowDialog() == DialogResult.OK)
            {
                // Recargar los datos solo si se creó una nueva lista
                CargarDatosListado();
            }
        }

        private void iconNuevaLista_Click(object sender, EventArgs e)
        {
            UINuevaLista uINuevaLista = new();
            if (uINuevaLista.ShowDialog() == DialogResult.OK)
            {
                // Recargar los datos solo si se creó una nueva lista
                CargarDatosListado();
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void LimpiarDataGridView()
        {
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.DataSource = null;
                dgvListado.Rows.Clear();
                dgvListado.Columns.Clear();
            }
        }

        private void CargarDatosListado()
        {
            try
            {
                LimpiarDataGridView();
                DataTable ResultadosListado = Global.LDC.MthGetList();
                dgvListado.DataSource = ResultadosListado;

                // Ocultar columna idLista si existe
                if (dgvListado.Columns.Contains("idLista"))
                {
                    dgvListado.Columns["idLista"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los datos: " + ex.Message);
            }
        }

        private void btnlinkRefrescar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarDatosListado();
        }
    }
}
