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
        public UIListado()
        {
            InitializeComponent();
        }

        private void UIListado_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            labelFecha.Text = $"Hoy es: {DateTime.Now:dd/MM/yyyy}";
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
            UIListadoAsistencia uIListadoAsistencia = new();
            uIListadoAsistencia.Show();
            Close();
        }
    }
}
