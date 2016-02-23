using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Media;
using System.IO;
using Microsoft.Win32;

namespace DDSIC
{
    using DDB;
    using MODELO;

    public partial class HOME : Office2007Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static HOME frmInstance = null;

        public static HOME Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new HOME();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;
        private DBSIC dbSIC;
        private DBCuenta dbCatalogo;

        public DateTime FECHA_SISTEMA;
        public Usuario USUARIO;
        public string SISTEMA;
        public string TIPO_SESION;
        public int PERIODO_CONTABLE_ACTUAL;

        public DataTable CATALOGO_SUBCUENTAS;


        public HOME()
        {
            InitializeComponent();
            this.Font = SystemFonts.IconTitleFont;
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            this.FormClosing += new FormClosingEventHandler(HOME_FormClosing);
            this.PerformAutoScale();
            dbSIC = new DBSIC();
            dbUser = new DBUsuario();
            dbCatalogo = new DBCuenta();
            SISTEMA = Properties.Settings.Default.SISTEMA;
        }


        void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
            }
        }




        void HOME_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }


        private void HOME_Load(object sender, EventArgs e)
        {
            moduloREPORTES.Select();
            MENU_PRINCIPAL.Expanded = false;
            cargarDatosIniciales();
        }







        public void LOGOUT()
        {
            USUARIO = null;
            LoginForm logear = new LoginForm();
            logear.Show();
            this.Hide();
        }






        public void OPEN_SESION(Usuario USER,  DateTime FECHA)
        {

            this.Show();
            USUARIO = USER;
            FECHA_SISTEMA = FECHA;
            PERIODO_CONTABLE_ACTUAL = FECHA.Year;
            MENU_PRINCIPAL.Visible = true;
            STATUS_BAR.Visible = true;// Sonido de inicio de sesion
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.Startup_Ubuntu;

            statusLabelFecha.Text = FECHA_SISTEMA.Date.ToString("dd/MM/yyyy");
            statusLabelPeriodo.Text = PERIODO_CONTABLE_ACTUAL+"";
            statusCODEMPLEADO.Text = USUARIO.COD_EMPLEADO;
            statusEMPLEADO.Text = USUARIO.NOMBRE;
            statusTipoSesion.Text = USUARIO.TIPO.ToString();

            cargarPermisos();
            player.Play();
        }





        private void bloquearTodo()
        {
            //MODULO CATALOGOS
            //moduloCATALOGOS.Visible = false;
            
            //MODULO OPERACIONES
            //moduloTAREAS.Visible = false;
            
            //MODULO REPORTES
            //moduloREPORTES.Visible = false;
            
            //MODULO CONFIGURACION
            //moduloCONFIG.Visible = false;
            
        }






        private void cargarPermisos()
        {
            bloquearTodo();
            USUARIO.PERMISOS = dbUser.getPermisos(Properties.Settings.Default.SISTEMA, USUARIO.TIPO);
            foreach (DataRow p in USUARIO.PERMISOS.Rows)
            {
                switch (p.Field<string>("MODULO"))
                {
                    //MODULO CATALOGOS
                    case "CATALOGOS":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Clientes":
                                
                                break;
                            case "Proveedores":
                                
                                break;
                            case "Personal":
                                
                                break;
                            case "Catalogos":
                                
                                break;
                        }
                        break;


                    //MODULO OPERACIONES
                    case "OPERACIONES":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Lista Vencidos":
                                break;
                            case "Recibir":
                                break;
                            case "Enviar":
                                break;
                            case "Corte Inicial":
                                break;
                        }
                        break;

                    //MODULO REPORTES
                    case "REPORTES":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Resguardo":
                                break;
                            case "En Venta":
                                break;
                        }

                        break;

                    //MODULO CONFIGURACION
                    case "CONFIGURACION":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Base de Datos":
                                btnConfigConexionDB.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Mi Cuenta":
                                btnConfigMiCuenta.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Usuarios":
                                btnConfigUsuarios.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Permisos":
                                btnConfigPermisos.Visible = p.Field<bool>("ACCESO");
                                break;
                        }
                        break;

                }
            }


            //VISIBILIDAD DE MODULOS
            //moduloCATALOGOS.Visible = (btnMenuClientes.Visible || btnMenuAMIGO.Visible || btnMenuVIP.Visible || btnMenuCatalogoProductos.Visible);
            //grupoClientes.Visible = (btnMenuClientes.Visible || btnMenuAMIGO.Visible || btnMenuVIP.Visible);
            
        }





        private void HOME_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("CERRAR LA APLICACION?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                LOGOUT();
            }
        }



        private void CERRAR_SESION(object sender, EventArgs e)
        {
            ventanasCERRAR(null, null);
            moduloTAREAS.Select();
            LOGOUT();
        }


        public void RESTART(object sender, EventArgs e)
        {
            DialogResult reiniciar = MessageBox.Show("DESEA REINICIAR APLICACION?", "ERROR INESPERADO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (reiniciar == DialogResult.Yes)
            {
                Application.Restart();
            }
        }



        public void EXIT(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }



        private void cargarDatosIniciales()
        {
            //CATALOGO DE CUENTAS
            CATALOGO_SUBCUENTAS = dbCatalogo.getCatalogoCuentas(eClaseCuenta.SUBCUENTA);
        }



        private void ventanasCASCADA(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }



        private void ventanasPARALELO(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void ventanasCERRAR(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void ventanasMinimizar(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Minimized;
            }
        }



        private void BUSCAR_TRANSACCION(object sender, EventArgs e)
        {

        }



        // MENU CATALOGOS

        private void menuCatalogoCuentas(object sender, EventArgs e)
        {
            Catalogos.CatalogoCuentaForm catalogo;
            catalogo = Catalogos.CatalogoCuentaForm.Instance();
            catalogo.MdiParent = this;
            catalogo.Show();
            if (catalogo.WindowState == FormWindowState.Minimized)
            {
                catalogo.WindowState = FormWindowState.Normal;
            }
        }




        //MENU TAREAS

        private void menuTareasPartidaDiaria(object sender, EventArgs e)
        {
            Tareas.PartidaDiariaForm partida;
            partida = Tareas.PartidaDiariaForm.Instance();
            partida.MdiParent = this;
            partida.Show();
            if (partida.WindowState == FormWindowState.Minimized)
            {
                partida.WindowState = FormWindowState.Normal;
            }
        }

        private void menuTareasContabilizarTrans(object sender, EventArgs e)
        {
            Tareas.ContabilizarTransForm contabilizar;
            contabilizar = Tareas.ContabilizarTransForm.Instance();
            contabilizar.MdiParent = this;
            contabilizar.Show();
            if (contabilizar.WindowState == FormWindowState.Minimized)
            {
                contabilizar.WindowState = FormWindowState.Normal;
            }
        }


        // MENU CONFIGURACION
        private void menuConfigConta(object sender, EventArgs e)
        {
            Configuracion.ConfigCuentasForm conta;
            conta = Configuracion.ConfigCuentasForm.Instance();
            conta.MdiParent = this;
            conta.Show();
            if (conta.WindowState == FormWindowState.Minimized)
            {
                conta.WindowState = FormWindowState.Normal;
            }
        }


        private void menuConfigInvConta(object sender, EventArgs e)
        {
            Configuracion.ConfigCtaInvForm contaInv;
            contaInv = Configuracion.ConfigCtaInvForm.Instance();
            contaInv.MdiParent = this;
            contaInv.Show();
            if (contaInv.WindowState == FormWindowState.Minimized)
            {
                contaInv.WindowState = FormWindowState.Normal;
            }
        }



        // MENU REPORTES
        




        //MENU AYUDA
        






        // FUNCIONES GLOBALES


        public String convertirCantidadEnLetras(Decimal monto)
        {
            //float fraccion = new funciones().redondearMas(monto.floatValue() - (int)monto.floatValue(), 2);
            decimal fraccion = monto - (int)monto;
            int parteEntera = (int)monto;
            string Moneda = "DOLAR"; //Nombre de Moneda (Singular)
            string Monedas = "DOLARES";      //Nombre de Moneda (Plural)
            string Centimos = "CTVS.";  //Nombre de Céntimos (Plural)
            string Preposicion = "CON";    //Preposición entre Moneda y Céntimos
            int NumCentimos;
            string Letra = "";
            double Maximo = 1999999999.99;
            //Validar que el Numero está dentro de los límites
            if ((double)monto >= 0 && (double)monto <= Maximo)
            {
                Letra = convertirNumeroLetra(parteEntera);              //Convertir la parte Entera en letras

                NumCentimos = (int)(fraccion * 100);   //Obtener los centimos del Numero

                //Si Numero = 1 agregar leyenda Moneda (Singular)
                if (parteEntera == 1)
                {
                    Letra = Letra + " " + Moneda;
                    //De lo contrario agregar leyenda Monedas (Plural)
                }
                else
                {
                    Letra = Letra + " " + Monedas;
                }
                //Si NumCentimos es mayor a cero inicar la conversión
                if (NumCentimos > 0)
                {
                    //Si el parámetro CentimosEnLetra es VERDADERO obtener letras para los céntimos
                    //Mostrar los céntimos como número
                    if (NumCentimos < 10)
                    {
                        Letra = Letra + " " + " " + Preposicion + " " + NumCentimos + "/100" + Centimos;
                    }
                    else
                    {
                        Letra = Letra + " " + Preposicion + " " + NumCentimos + "/100" + Centimos;
                    }
                }

                return Letra;
            }
            else
            {
                return "ERROR: El número excede los limites";
            }
        }




        public string convertirNumeroLetra(int Numero)
        {
            String resultado = "";

            //Nombre de los números
            List<string> Unidades = new List<string>();
            Unidades.Add(""); Unidades.Add("UN"); Unidades.Add("DOS"); Unidades.Add("TRES"); Unidades.Add("CUATRO"); Unidades.Add("CINCO"); Unidades.Add("SEIS"); Unidades.Add("SIETE"); Unidades.Add("OCHO"); Unidades.Add("NUEVE"); Unidades.Add("DIEZ"); Unidades.Add("ONCE"); Unidades.Add("DOCE"); Unidades.Add("TRECE"); Unidades.Add("CATARCE"); Unidades.Add("QUINCE"); Unidades.Add("DIECISEIS"); Unidades.Add("DIECISIETE"); Unidades.Add("DIECIOCHO"); Unidades.Add("DIECINUEVE"); Unidades.Add("VEINTE"); Unidades.Add("VEINTIUNO"); Unidades.Add("VEINTIDOS"); Unidades.Add("VEINTITRES"); Unidades.Add("VEINTICUATRO"); Unidades.Add("VEINTICINCO"); Unidades.Add("VEINTISEIS"); Unidades.Add("VEINTISIETE"); Unidades.Add("VEINTIOCHO"); Unidades.Add("VEINTINUEVE");
            List<string> Decenas = new List<string>();
            Decenas.Add(""); Decenas.Add("DIEZ"); Decenas.Add("VEINTE"); Decenas.Add("TREINTA"); Decenas.Add("CUARENTA"); Decenas.Add("CINCUENTA"); Decenas.Add("SESENTA"); Decenas.Add("SETENTA"); Decenas.Add("OCHENTA"); Decenas.Add("NOVENTA"); Decenas.Add("CIEN");
            List<string> Centenas = new List<string>();
            Centenas.Add(""); Centenas.Add("CIENTO"); Centenas.Add("DOSCIENTOS"); Centenas.Add("TRESCIENTOS"); Centenas.Add("CUATROCIENTOS"); Centenas.Add("QUINIENTOS"); Centenas.Add("SEISCIENTOS"); Centenas.Add("SETECIENTOS"); Centenas.Add("OCHOCIENTOS"); Centenas.Add("NOVECIENTOS");

            //Convertir a Letra
            if (Numero == 0)
            {
                resultado = "CERO";
            }
            else if (Numero >= 1 && Numero <= 29)
            {
                resultado = Unidades[Numero];
            }
            else if (Numero >= 30 && Numero <= 100)
            {
                resultado = Decenas[Numero / 10];
                if (Numero % 10 != 0)
                {
                    resultado = resultado + " Y ";
                    resultado = resultado + convertirNumeroLetra(Numero % 10);
                }
            }
            else if (Numero >= 101 && Numero <= 999)
            {
                resultado = Centenas[Numero / 100];
                if (Numero % 100 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 100);
                }
            }
            else if (Numero >= 1000 && Numero <= 1999)
            {
                resultado = "MIL";
                if (Numero % 1000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000);
                }
            }
            else if (Numero >= 2000 && Numero <= 999999)
            {
                resultado = convertirNumeroLetra(Numero % 1000);
                resultado = resultado + "MIL";
                if (Numero % 1000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000);
                }
            }
            else if (Numero >= 1000000 && Numero <= 1999999)
            {
                resultado = "UN MILLON";
                if (Numero % 1000000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000000);
                }
            }
            else if (Numero >= 2000000 && Numero <= 1999999999)
            {
                resultado = convertirNumeroLetra(Numero % 1000000);
                resultado = resultado + "MILLONES";
                if (Numero % 1000000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000000);
                }
            }

            return resultado;
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }



        public void exportDataGridViewToExcel(string titulo, DataGridViewColumnCollection encabezados, DataTable datos, string nombreArchivo)
        {
            int columna = 1;
            int fila = 1;
            if (encabezados != null && datos != null)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Workbooks.Add(true);

                    foreach (DataGridViewColumn column in encabezados)
                    {
                        excel.Cells[fila, columna] = column.HeaderText;
                        excel.ActiveCell.Font.Bold = true;
                        excel.ActiveCell.EntireColumn.NumberFormat = convertFormatExcel(column.DefaultCellStyle.Format);
                        excel.ActiveCell.get_Offset(0, 1).Activate();
                        columna++;
                    }
                    fila++;
                    foreach (DataRow row in datos.Rows)
                    {
                        columna = 1;
                        foreach (DataGridViewColumn column in encabezados)
                        {
                            if (column.Visible)
                            {
                                if (row.Table.Columns.Contains(column.Name))
                                {
                                    excel.Cells[fila, columna] = row.Field<object>(column.Name);
                                }
                                columna++;
                            }
                        }
                        fila++;
                    }
                    excel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR AL GENERAR ARCHIVO EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private string convertFormatExcel(string formatDataGrid)
        {
            string formato = string.Empty;
            switch (formatDataGrid)
            {
                case "N0":
                    formato = "#,##0";
                    break;
                case "N1":
                    formato = "#,##0.0";
                    break;
                case "C2":
                    formato = "$#,##0.00_);[Red]($#,##0.00)";
                    break;
                case "d":
                    formato = "dd/mm/yyyy";
                    break;
                default:
                    formato = "@";
                    break;
            }
            return formato;
        }

      



        

       
    }
}
