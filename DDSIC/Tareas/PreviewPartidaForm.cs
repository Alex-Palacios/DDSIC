using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDSIC.Tareas
{
    using MODELO;
    using DDB;

    public partial class PreviewPartidaForm : Form
    {
        private DBPartida dbPartida;
        private eSistema SISTEMA;
        private DataRow ROW;
        private Partida PREVIEW;

        public PreviewPartidaForm(eSistema sys,DataRow trans)
        {
            InitializeComponent();
            dbPartida = new DBPartida();
            this.SISTEMA = sys;
            this.ROW = trans;
        }

        private void PreviewPartidaForm_Load(object sender, EventArgs e)
        {
            tblMOVIMIENTOS.AutoGenerateColumns = false;
            generarPreview();
        }

        private void generarPreview()
        {
            PREVIEW = new Partida();
            PREVIEW.COD_TRANS = ROW.Field<string>("COD_TRANS");
            PREVIEW.FECHA = ROW.Field<DateTime>("FECHA");
            PREVIEW.REFERENCIA = ROW.Field<string>("REFERENCIA");
            PREVIEW.CONCEPTO = ROW.Field<string>("DESCRIPCION");
            PREVIEW.MOVIMIENTOS = dbPartida.getPreviewPartida(SISTEMA, ROW.Field<string>("TRANSACCION"), PREVIEW.COD_TRANS);
            cargarDatosPartida();
        }



        public void cargarDatosPartida()
        {
            if (PREVIEW != null)
            {
                datePartida.Value = PREVIEW.FECHA;
                txtREFERENCIA.Text = PREVIEW.REFERENCIA;
                txtCONCEPTO.Text = PREVIEW.CONCEPTO;
                txtCODTRANS.Text = PREVIEW.COD_TRANS;
                txtNUMPARTIDA.Text = "PREVIEW";

                tblMOVIMIENTOS.DataSource = PREVIEW.MOVIMIENTOS;

                calcularTotales();

            }
        }




        public void calcularTotales()
        {
            lbMontoDebe.Text = PREVIEW.DEBE.ToString("C2");
            lbMontoHaber.Text = PREVIEW.HABER.ToString("C2");
            if (PREVIEW.BALANCE == 0)
            {
                lbBalance.ForeColor = Color.Green;
            }
            else
            {
                lbBalance.ForeColor = Color.Red;
            }
            lbBalance.Text = PREVIEW.BALANCE.ToString("C2");
        }







        private void tblMOVIMIENTOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblMOVIMIENTOS.Columns[e.ColumnIndex].Name)
                {
                    case "NUMERO":
                        e.Value = e.RowIndex + 1;
                        break;
                    case "DEBE":
                        if (e.Value != DBNull.Value)
                        {
                            decimal x = Decimal.Parse(e.Value.ToString());
                            if (x == 0)
                            {
                                e.Value = string.Empty;
                            }
                        }
                        break;
                    case "HABER":
                        if (e.Value != DBNull.Value)
                        {
                            decimal x = Decimal.Parse(e.Value.ToString());
                            if (x == 0)
                            {
                                e.Value = string.Empty;
                            }
                        }
                        break;
                }
            }

        }








    }
}
