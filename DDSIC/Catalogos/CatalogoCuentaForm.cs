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

namespace DDSIC.Catalogos
{
    using MODELO;
    using DDB;

    public partial class CatalogoCuentaForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static CatalogoCuentaForm frmInstance = null;

        public static CatalogoCuentaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CatalogoCuentaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private eOperacion ACCION;
        private DBCuenta dbCuenta;
        private DBSIC dbSIC;

        private Cuenta SELECTED;

        private DataTable CATALOGO;
        private DataTable FILTRO;


        private int currentRowSelected = -1;

        public CatalogoCuentaForm()
        {
            InitializeComponent();
            dbSIC = new DBSIC();
            dbCuenta = new DBCuenta();
        }

        private void permisos_FORM()
        {
            switch (HOME.Instance().USUARIO.TIPO)
            {
                case eTipoUsuario.ADMIN:

                    break;
                default:

                    break;
            }
        }



        private void CatalogoCuenta_Load(object sender, EventArgs e)
        {
            permisos_FORM();
            tblCatalogo.AutoGenerateColumns = false;
            ACCION = eOperacion.INSERT;
            cargarDatos();
            bloquear();
            tabCatalogo.SelectedIndex = -1;
            tabCatalogo.SelectedIndex = 0;
        }



        private void bloquear()
        {
            btnEditar.Enabled = false;
            btnCambiarKEY.Enabled = false;
            btnCambiarEstado.Enabled = false;
            btnEliminar.Enabled = false;
            
            
        }

        public void cargarDatos()
        {
            CATALOGO = dbCuenta.getCatalogoCuentas();
            filtarDatos();
            bloquear();
        }





        private void filtarDatos()
        {
            DataRow[] filtros;
            FILTRO = CATALOGO.Copy();
            if (FILTRO.Rows.Count > 0)
            {
                if (txtFiltroCodigo.Text.Trim() != string.Empty)
                {
                    filtros = FILTRO.Select("COD_CTA LIKE '" + txtFiltroCodigo.Text.Trim() + "%'");
                    if (filtros.Count() > 0)
                    {
                        FILTRO = filtros.CopyToDataTable();
                    }
                    else
                    {
                        FILTRO.Clear();
                    }
                }
            }
            tblCatalogo.DataSource = FILTRO;
        }


        private void txtFiltroCodigo_TextChanged(object sender, EventArgs e)
        {
            filtarDatos();
        }



        private void cargarSelected()
        {
            SELECTED = new Cuenta();
            if (tblCatalogo.CurrentCell != null)
            {
                SELECTED = Cuenta.ConvertToCuenta(CATALOGO.Rows[tblCatalogo.CurrentCell.RowIndex]);

                btnEditar.Enabled = true;
                btnCambiarKEY.Enabled = true;
                btnCambiarEstado.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }




        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            CuentaForm nuevo = new CuentaForm();
            nuevo.ShowDialog(this);
        }



        private void IMPORTAR_CATALOGO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            ImportarCatalogoExcel import = new ImportarCatalogoExcel();
            import.ShowDialog(this);
        }

        
        


        private void CHANGE_KEY(object sender, EventArgs e)
        {
            if (tblCatalogo.SelectedRows.Count == 1)
            {
                ACCION = eOperacion.UPDATE;
                cargarSelected();
                string oldCodigo = FILTRO.Rows[tblCatalogo.CurrentCell.RowIndex].Field<string>("COD_CTA");
                string newCodigo = Controles.InputBox("CAMBIAR CODIGO DE CUENTA " + oldCodigo + " POR : ", "CAMBIAR CODIGO");
                if (newCodigo.Trim() != "")
                {
                    if (dbCuenta.changeCODIGO(oldCodigo, newCodigo.ToUpper().Trim(), Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                    {
                        cargarDatos();
                    }
                }
            }
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (tblCatalogo.SelectedRows.Count == 1)
            {
                ACCION = eOperacion.UPDATE;
                cargarSelected();
                CuentaForm editar = new CuentaForm(SELECTED);
                editar.ShowDialog(this);
            }
        }

        private void CHANGE_ESTADO(object sender, EventArgs e)
        {
            if (tblCatalogo.SelectedRows.Count == 1)
            {
                ACCION = eOperacion.UPDATE;
                cargarSelected();
                string codigo = FILTRO.Rows[tblCatalogo.CurrentCell.RowIndex].Field<string>("COD_CTA");
                if (codigo.Trim() != string.Empty)
                {
                    if (dbCuenta.changeACTIVA(codigo, !SELECTED.ACTIVA,Properties.Settings.Default.SUCURSAL,HOME.Instance().USUARIO.COD_EMPLEADO,Properties.Settings.Default.SISTEMA))
                    {
                        cargarDatos();
                    }
                }
            }
        }

        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblCatalogo.SelectedRows.Count == 1)
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la cuenta " + SELECTED.COD_CTA + " de la Cartera ?", "Eliminar Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBSIC.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        ACCION = eOperacion.DELETE;
                        cargarSelected();
                        if (dbCuenta.delete(SELECTED, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                        {
                            cargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }



        private void EXPORTAR(object sender, EventArgs e)
        {
            if (FILTRO != null)
            {
                HOME.Instance().exportDataGridViewToExcel("CATALOGO CUENTAS", tblCatalogo.Columns, FILTRO, "CatalogoCuentas");
            }
        }

        private void IMPRIMIR(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }


        private void tblCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCatalogo.CurrentCell != null && tblCatalogo.CurrentCell.RowIndex >= 0)
            {
                cargarSelected();
            }
        }


        private void tblCatalogo_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblCatalogo.DataSource != null)
            {
                lbTotalCuentas.Text = tblCatalogo.Rows.Count + " CUENTAS";
            }
        }

        private void tblCatalogo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = tblCatalogo.Columns[e.ColumnIndex].Name;
                switch (columnName)
                {
                    case "SALDO":
                        eSaldoCuenta saldo = (eSaldoCuenta)Char.ConvertToUtf32(e.Value.ToString(),0);
                        e.Value = saldo.ToString();
                        break;
                    case "CATEGORIA":
                        eCategoriaCuenta cat = (eCategoriaCuenta)Char.ConvertToUtf32(e.Value.ToString(),0);
                        e.Value = cat.ToString();
                        break;
                    case "TIPO":
                        eTipoCuenta tipo = (eTipoCuenta)(int)e.Value;
                        switch (tipo)
                        {
                            case eTipoCuenta.ND:
                                e.Value = string.Empty;
                                break;
                            default:
                                e.Value = tipo.ToString().Replace('_',' ');
                                break;
                        }
                        break;
                }
            }
        }
        
    }
}
