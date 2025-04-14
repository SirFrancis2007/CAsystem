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
    public partial class UICarga : Form
    {
        public UICarga()
        {
            InitializeComponent();
        }

        private void UICarga_Load(object sender, EventArgs e)
        {
            TimePorcentajeCarga.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label1.Text = progressBar1.Value.ToString() + "%";
            }

            else
            {
                TimePorcentajeCarga.Stop();
                this.Hide();
            }
        }

        //hacer un mth asincronico que haga la conexion con la bd. 
    }
}
