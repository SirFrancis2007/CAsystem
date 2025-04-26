using ControllerEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void UIListado_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            labelFecha.Text = $"Hoy es: {DateTime.Now:dd/MM/yyyy}";
            labelSaludo.Text = $"Bienvenido, {Nombre}!";

            // cada vez que se carga la ventana, se cargan los datos
            dgvListado.DataSource = null;
            dgvListado.Rows.Clear();
            dgvListado.Columns.Clear();

            CargarDatosListado();
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

                SessionData.CurrentListId = (uint)idListado;

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
