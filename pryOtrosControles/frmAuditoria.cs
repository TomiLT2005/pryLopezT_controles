using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOtrosControles
{
    public partial class frmAuditoria: Form
    {

        //conexion a la base de datos
        clsConexionBD conexion = new clsConexionBD();


        public frmAuditoria()
        {
            InitializeComponent();
        }


        //contador de tiempo
        int tiempo = 0;


        private void pnlPanelTrabajo_MouseMove(object sender, MouseEventArgs e)
        {
            
            timerTiempoTrabajo.Enabled = true;                   //se activa cuando muevo el cursor

            string coordenadas = e.Location.ToString();          //coordenadas del mouse
            lblCoordenadas.Text = coordenadas;                   //muestro las coordenadas en el label

            conexion.GuardarCoordenadas(coordenadas);            //guardo las coordenadas en la base de datos
        }


        private void pnlPanelTrabajo_MouseLeave(object sender, EventArgs e)
        {
            timerTiempoTrabajo.Enabled = false;     //se desactiva cuando salgo del panel
        }


        private void timerTiempoTrabajo_Tick(object sender, EventArgs e)
        {
            tiempo++;
            TimeSpan ts = TimeSpan.FromSeconds(tiempo);
            lblTiempo.Text = ts.ToString(@"hh\:mm\:ss");
        }


        
        private void btnAuditar_Click(object sender, EventArgs e)
        {
            lstCoordenadas.Visible = true;
            lstCoordenadas.Items.Clear();

            conexion.MostrarCoordenadas(lstCoordenadas);
        }
    }
}
