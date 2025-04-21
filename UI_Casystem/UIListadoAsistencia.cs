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
        public UIListadoAsistencia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UIListadoAsistencia_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            CenterToParent();
            labelFecha.Text = $"Hoy es: {DateTime.Now:dd/MM/yyyy}";
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
    }
}
