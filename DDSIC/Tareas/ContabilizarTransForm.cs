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



    public partial class ContabilizarTransForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ContabilizarTransForm frmInstance = null;

        public static ContabilizarTransForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ContabilizarTransForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBSIC dbSIC;
        private DBPartida dbPartida;
        private eSistema SISTEMA;
        private string SUCURSAL;
        private DataTable TRANSACCIONES;


        public ContabilizarTransForm()
        {
            InitializeComponent();
            dbSIC = new DBSIC();
            dbPartida = new DBPartida();
        }

        private void permisos()
        {

        }


        private void ContabilizarTransForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblTRANSACCIONES.AutoGenerateColumns = false;
            cbxSISTEMA.DataSource = Enum.GetValues(new eSistema().GetType());
            dateDESDE.Value = HOME.Instance().FECHA_SISTEMA;
            dateHASTA.Value = HOME.Instance().FECHA_SISTEMA;
        }



        private bool validarParametros()
        {
            bool OK = true;
            if (dateDESDE.Value > dateHASTA.Value)
            {
                OK = false;
                MessageBox.Show("FECHAS INVALIDAS", "ERROR DE PARAMETROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        private void TRANS_PENDIENTES(object sender, EventArgs e)
        {
            if (validarParametros())
            {
                SISTEMA = (eSistema)cbxSISTEMA.SelectedItem;
                SUCURSAL = (string)cbxSUCURSAL.SelectedValue;
                TRANSACCIONES = dbPartida.getTransPendientes(SISTEMA,SUCURSAL,dateDESDE.Value, dateHASTA.Value);
                tblTRANSACCIONES.DataSource = TRANSACCIONES;
                MessageBox.Show("TRANSACCIONES CARGADAS", "BUSQUEDA FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void tblTRANSACCIONES_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblTRANSACCIONES.Rows != null)
            {
                lbTOTAL.Text = tblTRANSACCIONES.Rows.Count + " TRANS PENDIENTES";
            }
            else
            {
                lbTOTAL.Text = "No hay trans pendientes";
            }

        }

        private void tblTRANSACCIONES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string columnName = this.tblTRANSACCIONES.Columns[e.ColumnIndex].Name;
                switch (columnName)
                {
                    case "btnPreview":
                        PreviewPartidaForm preview = new PreviewPartidaForm(SISTEMA,TRANSACCIONES.Rows[e.RowIndex]);
                        preview.ShowDialog();
                        break;
                }
            }
        }

        private void tblTRANSACCIONES_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                string columnName = this.tblTRANSACCIONES.Columns[e.ColumnIndex].Name;
                switch (columnName)
                {
                    case "btnPreview":
                        Image icoVer = Properties.Resources.calculadora;
                        e.Graphics.DrawImage(icoVer, e.CellBounds.Left + 2, e.CellBounds.Top + 2);

                        tblTRANSACCIONES.Rows[e.RowIndex].Height = icoVer.Height + 10;
                        tblTRANSACCIONES.Columns[e.ColumnIndex].Width = icoVer.Width + 10;

                        break;
                }

                e.Handled = true;
            }
        }

        private void cbxSISTEMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSISTEMA.SelectedIndex >= 0)
            {
                cbxSUCURSAL.DataSource = dbSIC.getSucursales((eSistema) cbxSISTEMA.SelectedItem);
                if (((DataTable)cbxSUCURSAL.DataSource).Rows.Count > 0)
                {
                    cbxSUCURSAL.DisplayMember = "SUCURSAL";
                    cbxSUCURSAL.ValueMember = "COD_SUC";
                    cbxSUCURSAL.SelectedIndex = 0;
                    DataRow R = ((DataTable)cbxSUCURSAL.DataSource).NewRow();
                    R.SetField<string>("COD_SUC", "00");
                    R.SetField<string>("SUCURSAL", "TODAS LAS SUCURSALES");
                    R.SetField<bool>("ACTIVA", false);
                    ((DataTable)cbxSUCURSAL.DataSource).Rows.InsertAt(R, 0);
                }
            }
        }







    }
}
