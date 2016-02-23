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

    public partial class CuentaForm : Form
    {
        private DBUsuario dbUser;
        private DBCuenta dbCuenta;
        private DBSIC dbSIC;

        private Cuenta SELECTED;
        private eOperacion ACCION;

        public CuentaForm()
        {
            InitializeComponent();
            dbSIC = new DBSIC();
            dbUser = new DBUsuario();
            dbCuenta = new DBCuenta();

            ACCION = eOperacion.INSERT;
        }

        public CuentaForm(Cuenta item)
        {
            InitializeComponent();
            dbSIC = new DBSIC();
            dbUser = new DBUsuario();
            dbCuenta = new DBCuenta();

            ACCION = eOperacion.UPDATE;
            SELECTED = item;
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

        private void CuentaForm_Load(object sender, EventArgs e)
        {
            permisos_FORM();
            cbxSaldo.DataSource = Enum.GetValues(new eSaldoCuenta().GetType());
            cbxCategoria.DataSource = Enum.GetValues(new eCategoriaCuenta().GetType());
            cbxTipo.DataSource = Enum.GetValues(new eTipoCuenta().GetType());
            cbxMayor.DataSource = dbCuenta.getCatalogoCuentas();
            if (((DataTable)cbxMayor.DataSource).Rows.Count > 0)
            {
                cbxMayor.ValueMember = "COD_CTA";
            }
            DataRow R = ((DataTable)cbxMayor.DataSource).NewRow();
            R.SetField<string>("COD_CTA","----");
            R.SetField<string>("NOMBRE", "----");
            R.SetField<string>("MAYOR", "----");
            R.SetField<string>("SALDO", "-");
            R.SetField<string>("CATEGORIA", "-");
            R.SetField<int>("TIPO", 0);
            R.SetField<bool>("ACTIVA", true);
            R.SetField<string>("CLASE", "----");
            ((DataTable)cbxMayor.DataSource).Rows.InsertAt(R, 0);
            cbxMayor.SelectedIndex = 0;

            
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    break;
                case eOperacion.UPDATE:
                    txtCodigo.ReadOnly = true;
                    cargarSELECTED();
                    break;
            }
        }



        private bool validar()
        {
            bool OK = true;
            if (txtCodigo.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Codigo de cuenta Requerido", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (txtNombreCta.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Nombe de cuenta Requerida", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }




        public Cuenta buildCuenta()
        {
            Cuenta c = new Cuenta();
            c.COD_CTA = txtCodigo.Text.Trim();
            c.NOMBRE = txtNombreCta.Text.Trim();
            if (cbxMayor.SelectedIndex > 0)
            {
                c.MAYOR = (string)cbxMayor.SelectedValue;
            }
            c.CATEGORIA = (eCategoriaCuenta)cbxCategoria.SelectedItem;
            c.TIPO = (eTipoCuenta)cbxTipo.SelectedItem;
            c.SALDO = (eSaldoCuenta)cbxSaldo.SelectedItem;
            return c;
        }



        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void GUARDAR_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        c = buildCuenta();
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBSIC.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbCuenta.insert(c, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                            {
                                CatalogoCuentaForm.Instance().cargarDatos();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }
                    break;
                case eOperacion.UPDATE:
                    if (validar())
                    {
                        c = buildCuenta();
                        c.COD_CTA = SELECTED.COD_CTA;
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBSIC.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbCuenta.update(c, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                            {
                                CatalogoCuentaForm.Instance().cargarDatos();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;
            }

        }




        private void cargarSELECTED()
        {
            if (SELECTED != null)
            {
                txtCodigo.Text = SELECTED.COD_CTA;
                txtNombreCta.Text = SELECTED.NOMBRE;
                if (SELECTED.MAYOR != null)
                {
                    cbxMayor.SelectedValue = SELECTED.MAYOR;
                }
                else
                {
                    cbxMayor.SelectedIndex = 0;
                }
                cbxCategoria.SelectedItem = SELECTED.CATEGORIA;
                cbxTipo.SelectedItem = SELECTED.TIPO;
                cbxSaldo.SelectedItem = SELECTED.SALDO;
            }
        }




    }
}
