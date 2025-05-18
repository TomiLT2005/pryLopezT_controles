using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOtrosControles
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        int tiempo = 0;

        private void btnTrabajo_Click(object sender, EventArgs e)
        {

            if (btnTrabajo.Text == "Trabajo")
            {
                btnTrabajo.Text = "Finalizar";
                btnTrabajo.BackColor = Color.Salmon;
                btnTrabajo.ForeColor = Color.White;
                dtpTiempo.Enabled = true;
                

            }
            else if(btnTrabajo.Text == "Finalizar")
            {
                btnTrabajo.Text = "Trabajo";
                btnTrabajo.BackColor = Color.Green;
                btnTrabajo.ForeColor = Color.White;

                dtpTiempo.Enabled = false;
            }
        }

        private void dtpTiempo_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblEstado.Text = tiempo.ToString();
        }
    }
}
