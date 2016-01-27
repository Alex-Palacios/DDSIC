using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesPersonalizados;

namespace DDSIC.Tareas
{
    using MODELO;
    using DDB;

    public partial class ConfirmarPartida : Form
    {
        private DBUsuario dbUser;
        private DBPartida dbPartida;

        private Partida PARTIDA;
        private eOperacion ACCION;


        public ConfirmarPartida(Partida p, eOperacion operacion)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbPartida = new DBPartida();
            ACCION = operacion;
            PARTIDA = p;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (PARTIDA != null)
            {
                lbNUMPARTIDA.Text = PARTIDA.PERIODO + " " + PARTIDA.NUMPARTIDA;
                lbFECHA.Text = PARTIDA.FECHA.ToString("dd/MM/yyyy");
                lbREFERENCIA.Text = PARTIDA.REFERENCIA;
                lbCONCEPTO.Text = PARTIDA.CONCEPTO;
                lbDEBE.Text = PARTIDA.DEBE.ToString("C2");
                lbHABER.Text = PARTIDA.HABER.ToString("C2");
                
            }
        }







        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBSIC.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:

                        if (dbPartida.insert(PARTIDA, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                        {
                            PartidaDiariaForm.Instance().buscarPartida(PARTIDA.PERIODO, PARTIDA.NUMPARTIDA);
                            this.Close();
                        }
                        break;
                    case eOperacion.UPDATE:
                        if (dbPartida.update(PARTIDA, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                        {
                            PartidaDiariaForm.Instance().buscarPartida(PARTIDA.PERIODO, PARTIDA.NUMPARTIDA);
                            this.Close();
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
