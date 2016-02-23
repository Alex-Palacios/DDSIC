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




    public partial class PartidaDiariaForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static PartidaDiariaForm frmInstance = null;

        public static PartidaDiariaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new PartidaDiariaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBPartida dbPartida;


        private eOperacion ACCION;
        private Partida SELECTED;
        private Partida PARTIDA;

        private DataTable PARTIDAS_PERIODO;

        public PartidaDiariaForm()
        {
            InitializeComponent();
            dbPartida = new DBPartida();
        }

        private void permisos()
        {
            
        }



        private void PartidaDiaria_Load(object sender, EventArgs e)
        {
            permisos();
            tblMOVIMIENTOS.AutoGenerateColumns = false;

            DataTable CATALOGO = HOME.Instance().CATALOGO_SUBCUENTAS.Copy();
            if (CATALOGO.Rows.Count == 0)
            {
                CATALOGO.Columns.Add("COD_CTA");
                CATALOGO.Columns.Add("NOMBRE");
                CATALOGO.Columns.Add("MAYOR");
                CATALOGO.Columns.Add("SALDO");
                CATALOGO.Columns.Add("CATEGORIA");
                CATALOGO.Columns.Add("TIPO");
                CATALOGO.Columns.Add("ACTIVA");
                CATALOGO.Columns.Add("CLASE");
            }
            DataRow R = CATALOGO.NewRow();
            R.SetField<string>("COD_CTA", "-----");
            R.SetField<string>("NOMBRE", "-----");
            R.SetField<string>("MAYOR", "-----");
            R.SetField<string>("SALDO", "-");
            R.SetField<string>("CATEGORIA", "-");
            R.SetField<int>("TIPO", 0);
            R.SetField<bool>("ACTIVA", false);
            R.SetField<string>("CLASE", "-----");

            CATALOGO.Rows.InsertAt(R, 0);

            ((DataGridViewComboBoxColumn)tblMOVIMIENTOS.Columns["COD_CTA"]).DataSource = CATALOGO;
            ((DataGridViewComboBoxColumn)tblMOVIMIENTOS.Columns["COD_CTA"]).DisplayMember = "COD_CTA";
            ((DataGridViewComboBoxColumn)tblMOVIMIENTOS.Columns["COD_CTA"]).ValueMember = "COD_CTA";

            bloquear();
            NUEVO(null, null);
        }



        public void bloquear()
        {
            grPartida.Enabled = false;
        }


        public void desbloquear()
        {
            grPartida.Enabled = true;
        }



        public void limpiar()
        {
            txtNUMPARTIDA.Text = "-----";
            txtCODTRANS.Text = string.Empty;
            datePartida.Value = DateTime.Today.Date;
            txtREFERENCIA.Text = "";
            txtCONCEPTO.Text = "";
            ckBLOQUEAR.Checked = true;
            ckIGNORAR.Checked = false; 
            tblMOVIMIENTOS.DataSource = null;
        }




        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            limpiar();
            PARTIDA = new Partida();
            PARTIDA.FECHA = HOME.Instance().FECHA_SISTEMA;
            PARTIDA.PERIODO = PARTIDA.FECHA.Year;
            PARTIDA.NUMPARTIDA = dbPartida.nextNumPartida(PARTIDA.PERIODO);

            cargarDatosPartida();
            desbloquear();
            txtREFERENCIA.Focus();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAnular.Enabled = false;
        }



        public void cargarDatosPartida()
        {
            if (PARTIDA != null)
            {
                datePartida.Value = PARTIDA.FECHA;
                txtREFERENCIA.Text = PARTIDA.REFERENCIA;
                txtCONCEPTO.Text = PARTIDA.CONCEPTO;
                txtCODTRANS.Text = PARTIDA.COD_TRANS;
                txtNUMPARTIDA.Text = PARTIDA.NUMPARTIDA+"";
                ckBLOQUEAR.Checked = PARTIDA.BLOQUEADA;

                tblMOVIMIENTOS.DataSource = PARTIDA.MOVIMIENTOS;

                lbMontoDebe.Text = PARTIDA.DEBE.ToString("C2");
                lbMontoHaber.Text = PARTIDA.HABER.ToString("C2");
                calcularTotales();
                
            }
            else
            {
                limpiar();
            }
        }




        public void calcularTotales()
        {
            lbMontoDebe.Text = PARTIDA.DEBE.ToString("C2");
            lbMontoHaber.Text = PARTIDA.HABER.ToString("C2");
            if (PARTIDA.BALANCE == 0)
            {
                lbBalance.ForeColor = Color.Green;
            }
            else
            {
                lbBalance.ForeColor = Color.Red;
            }
            lbBalance.Text = PARTIDA.BALANCE.ToString("C2");
        }




        private void addItemPartida(object sender, EventArgs e)
        {
            PARTIDA.MOVIMIENTOS.Rows.Add("-----","", 0.00,0.00);
        }




        private void removeItemPartida(object sender, EventArgs e)
        {
            if (PARTIDA.MOVIMIENTOS.Rows.Count > 0)
            {
                PARTIDA.MOVIMIENTOS.Rows.RemoveAt(tblMOVIMIENTOS.CurrentCell.RowIndex);
                calcularTotales();
            }
        }






        private bool validarPartida()
        {
            bool OK = true;
            try
            {
                if (PARTIDA.REFERENCIA == null || PARTIDA.REFERENCIA == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Ingrese documento o referencia", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (PARTIDA.CONCEPTO == null || PARTIDA.CONCEPTO == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Especifique concepto de la partida", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                //else if (PARTIDA.BALANCE != 0)
                //{
                //    OK = false;
                //    MessageBox.Show("PARTIDA NO ESTA CUADRADA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return OK;
                //}
                //else if (PARTIDA.DEBE == 0 && PARTIDA.HABER == 0)
                //{
                //    OK = false;
                //    MessageBox.Show("TOTAL DE MOVIMIENTOS INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return OK;
                //}
                OK = validarItemsPartida();
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR PARTIDA", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }




        private bool validarItemsPartida()
        {
            bool OK = true;
            if (tblMOVIMIENTOS.Rows.Count > 0)
            {
                foreach(DataRow row in PARTIDA.MOVIMIENTOS.Rows)
                {
                    if (row.Field<string>("COD_CTA") == null || row.Field<string>("COD_CTA") == string.Empty || row.Field<string>("COD_CTA") == "-----")
                    {
                        OK = false;
                        MessageBox.Show("Codigo de movimiento inválido", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return OK;
                    }
                    if (row.Field<string>("DESCRIPCION") == null || row.Field<string>("DESCRIPCION") == string.Empty)
                    {
                        OK = false;
                        MessageBox.Show("Falta descripcion de movimiento", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return OK;
                    }
                    if (row.Field<decimal>("DEBE") < 0)
                    {
                        OK = false;
                        MessageBox.Show("Monto del DEBE inválido en movimiento", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return OK;
                    }
                    if (row.Field<decimal>("HABER") < 0)
                    {
                        OK = false;
                        MessageBox.Show("Monto del HABER inválido en movimiento", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return OK;
                    }
                }
            }
            else
            {
                OK = false;
                MessageBox.Show("NO HAY MOVIMIENTOS DE CUENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }







        private void GUARDAR(object sender, EventArgs e)
        {
            txtPARTIDA_LOAD.Focus();
            PARTIDA.FECHA = datePartida.Value;
            PARTIDA.REFERENCIA = txtREFERENCIA.Text.Trim();
            PARTIDA.CONCEPTO = txtCONCEPTO.Text.Trim();
            PARTIDA.BLOQUEADA = ckBLOQUEAR.Checked;

            if (validarPartida())
            {
                ConfirmarPartida confirmar = new ConfirmarPartida(PARTIDA, ACCION);
                confirmar.ShowDialog();
            }

        }


        private void CANCELAR(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    NUEVO(null, null);
                    break;
                case eOperacion.UPDATE:
                    ACCION = eOperacion.SEARCH;
                    PARTIDA = SELECTED.Copy();
                    cargarDatosPartida();
                    bloquear();

                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAnular.Enabled = true;

                    break;
            }
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (PARTIDA != null)
            {
                ACCION = eOperacion.UPDATE;
                desbloquear();

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAnular.Enabled = false;
            }
            else
            {
                MessageBox.Show("CARGUE UNA PARTIDA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void ELIMINAR(object sender, EventArgs e)
        {
            if (PARTIDA != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la PARTIDA " + PARTIDA.PERIODO+" - "+PARTIDA.NUMPARTIDA + " con FECHA:" + PARTIDA.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR PARTIDA DIARIA REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBSIC.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbPartida.delete(PARTIDA, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                        {
                            NUEVO(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("CARGUE UNA PARTIDA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }




        private void txtPARTIDA_LOAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtPARTIDA_LOAD.Text.Trim() != string.Empty)
            {
                if (buscarPartida(HOME.Instance().PERIODO_CONTABLE_ACTUAL, Int32.Parse(txtPARTIDA_LOAD.Text)))
                {
                    MessageBox.Show("PARTIDA # " + SELECTED.NUMPARTIDA + " CARGADA", "BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PARTIDA NO ENCONTRADA", "ERROR AL BUSCAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }


        }

        public bool buscarPartida(int periodo,int partida)
        {
            bool OK = false;
            SELECTED = Partida.ConvertToPartida(dbPartida.findByPartida(periodo,partida));
            if (SELECTED != null)
            {
                ACCION = eOperacion.SEARCH;
                SELECTED.MOVIMIENTOS = dbPartida.getMovimientos(SELECTED);
                PARTIDA = SELECTED.Copy();
                cargarDatosPartida();
                calcularTotales();
                bloquear();
                OK = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAnular.Enabled = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }

      

        private void BACK(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                int anterior = SELECTED.NUMPARTIDA - 1;
                if (buscarPartida(SELECTED.PERIODO, anterior))
                {
                    txtPARTIDA_LOAD.Text = SELECTED.NUMPARTIDA+"";
                    MessageBox.Show("PARTIDA # " + SELECTED.NUMPARTIDA + " CARGADA", "BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PARTIDA NO ENCONTRADA", "ERROR AL BUSCAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (buscarPartida(HOME.Instance().PERIODO_CONTABLE_ACTUAL, 2))
                {
                    txtPARTIDA_LOAD.Text = SELECTED.NUMPARTIDA + "";
                    MessageBox.Show("PARTIDA # " + SELECTED.NUMPARTIDA + " CARGADA", "BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PARTIDA NO ENCONTRADA", "ERROR AL BUSCAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NEXT(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                int siguiente = SELECTED.NUMPARTIDA + 1;
                if (buscarPartida(SELECTED.PERIODO, siguiente))
                {
                    txtPARTIDA_LOAD.Text = SELECTED.NUMPARTIDA + "";
                    MessageBox.Show("PARTIDA # " + SELECTED.NUMPARTIDA + " CARGADA", "BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PARTIDA NO ENCONTRADA", "ERROR AL BUSCAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (buscarPartida(HOME.Instance().PERIODO_CONTABLE_ACTUAL, 2))
                {
                    txtPARTIDA_LOAD.Text = SELECTED.NUMPARTIDA + "";
                    MessageBox.Show("PARTIDA # " + SELECTED.NUMPARTIDA + " CARGADA", "BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PARTIDA NO ENCONTRADA", "ERROR AL BUSCAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void tblMOVIMIENTOS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tblMOVIMIENTOS.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
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







        private void tblMOVIMIENTOS_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string columnName = tblMOVIMIENTOS.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "DESCRIPCION":
                    //if (tblMOVIMIENTOS.Rows[e.RowIndex].Cells["COD_CTA"].FormattedValue.ToString() == string.Empty || tblMOVIMIENTOS.Rows[e.RowIndex].Cells["COD_CTA"].FormattedValue.ToString() == "-----")
                    //{
                    //    System.Media.SystemSounds.Beep.Play();
                    //    e.Cancel = true;
                    //}
                    break;
            }
        }






        private void tblMOVIMIENTOS_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = tblMOVIMIENTOS.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "DEBE":
                    decimal debe;
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        //tblDETALLE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                        //CAJA.ITEMS.Rows[e.RowIndex].SetField<int>(columnName, 0);
                        //e.Cancel = true;
                    }
                    else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out debe))
                    {
                        tblMOVIMIENTOS.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    else if (debe < 0)
                    {
                        tblMOVIMIENTOS.Rows[e.RowIndex].ErrorText = "Columna DEBE debe ser mayor o igual a cero";
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    
                    break;

                case "HABER":
                    decimal haber;
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        //tblDETALLE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                        //CAJA.ITEMS.Rows[e.RowIndex].SetField<int>(columnName, 0);
                        //e.Cancel = true;
                    }
                    else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out haber))
                    {
                        tblMOVIMIENTOS.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    else if (haber < 0)
                    {
                        tblMOVIMIENTOS.Rows[e.RowIndex].ErrorText = "Columna HABER debe ser mayor o igual a cero";
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    
                    break;
            }
        }





        private void tblMOVIMIENTOS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tblMOVIMIENTOS.Rows[e.RowIndex].ErrorText = String.Empty;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = tblMOVIMIENTOS.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "COD_CTA":
                        string codigo = tblMOVIMIENTOS.Rows[e.RowIndex].Cells["COD_CTA"].FormattedValue.ToString();
                
                        if (codigo == string.Empty || codigo == "-----")
                        {
                            tblMOVIMIENTOS.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = string.Empty;
                            tblMOVIMIENTOS.Rows[e.RowIndex].Cells["DEBE"].Value = 0.00;
                            tblMOVIMIENTOS.Rows[e.RowIndex].Cells["HABER"].Value = 0.00;
                        }
                        break;
                    case "DESCRIPCION":
                        string descripcion = tblMOVIMIENTOS.Rows[e.RowIndex].Cells["DESCRIPCION"].FormattedValue.ToString();
                
                        tblMOVIMIENTOS.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = descripcion.ToString().ToUpper().Replace('>', ' ').Replace('&', ' ');
                        break;
                    case "DEBE":
                        if (string.IsNullOrEmpty(tblMOVIMIENTOS.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                        {
                            tblMOVIMIENTOS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                            PARTIDA.MOVIMIENTOS.Rows[e.RowIndex].SetField<decimal>(columnName, (decimal)0.00);
                        }
                        calcularTotales();
                        break;
                    case "HABER":
                        if (string.IsNullOrEmpty(tblMOVIMIENTOS.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                        {
                            tblMOVIMIENTOS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                            PARTIDA.MOVIMIENTOS.Rows[e.RowIndex].SetField<decimal>(columnName, (decimal)0.00);
                        }
                        calcularTotales();
                        break;
                }
            }
        }




    }
}
