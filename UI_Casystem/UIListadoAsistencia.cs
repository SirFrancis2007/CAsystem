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
    public partial class UIListadoAsistencia : Form
    {
        // recibe el nombre de la tabla seleccionada de UI_Listado
        string nombreTabla;
        uint xidListado;
        public uint CantAsistentes;
        public uint CantFaltantes;

        public UIListadoAsistencia(string NombreTabla, uint idListado)
        {
            InitializeComponent();
            nombreTabla = NombreTabla;
            xidListado = idListado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UIListadoAsistencia_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            CenterToParent();
            labelFecha.Text = $"Hoy es: {DateTime.Now:dd/MM/yyyy}";

            labelNombreLista.Text = $"Estas en el listado: {nombreTabla}";
            DGVListadoAsistencia.DataSource = null;
            DGVListadoAsistencia.RowCount = 0;
            DGVListadoAsistencia.ColumnCount = 0;
            CargarDatosDGV();

            DAT.Text = $"Asistencia confirmada: {CantAsistentes}";
            DAF.Text = $"Asistencia no confirmada: {CantFaltantes}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UINuevaAsistencia uINuevaAsistencia = new();
            uINuevaAsistencia.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UINuevaAsistencia uINuevaAsistencia = new();
            uINuevaAsistencia.ShowDialog();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIIndex uIIndex = new();
            uIIndex.Show();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UIIndex uIIndex = new();
            uIIndex.Show();
            Close();
        }

        private void linkListado_Click(object sender, EventArgs e)
        {
            UIListado uIListado = new();
            uIListado.Show();
            Close();
        }

        private void iconVolver_Click(object sender, EventArgs e)
        {
            UIListado uIListado = new();
            uIListado.Show();
            Close();
        }

        //Mth de cargar los datos en el datagridview
        private void CargarDatosDGV()
        {
            try
            {
                DataTable ResultadosListado = Global.AC.MthTraerListadoAsistencia(nombreTabla, (int)xidListado);
                // carga en el datagridview
                DGVListadoAsistencia.DataSource = ResultadosListado;

                GetDataAsistencia(ResultadosListado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los datos: " + ex.Message);
            }
        }

        private void labelNombreLista_Click(object sender, EventArgs e)
        {
            labelNombreLista.Text = nombreTabla;
        }

        private void GetDataAsistencia (DataTable ResultadosListado)
        {
            foreach (DataRow fila in ResultadosListado.Rows)
            {
                if (fila["Asistencia"] != DBNull.Value)
                {
                    bool asistio = Convert.ToBoolean(fila["Asistencia"]);
                    if (asistio == true)
                        CantAsistentes++; // TRUE
                    else
                        CantFaltantes++; // FALSE
                }
            }
        }
    }
}
