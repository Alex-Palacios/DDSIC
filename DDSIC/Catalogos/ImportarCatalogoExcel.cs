using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace DDSIC.Catalogos
{
    using DDB;
    using MODELO;

    public partial class ImportarCatalogoExcel : Form
    {
        //private DBCuenta dbCatalogo;
        private string Excel03ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR={1};IMEX=1'";
        
        private DataTable CATALOGO;
        private DataTable IMPORT;
        private DBCuenta dbCatalogo;

        public ImportarCatalogoExcel()
        {
            InitializeComponent();
            dbCatalogo = new DBCuenta();

        }

        private void ImportarCatalogoExcel_Load(object sender, EventArgs e)
        {
            tblCATALOGO.AutoGenerateColumns = false;
            IMPORT = new DataTable();
            IMPORT.Columns.Add("CODIGO").DataType = System.Type.GetType("System.String");
            IMPORT.Columns.Add("CUENTA").DataType = System.Type.GetType("System.String");
            IMPORT.Columns.Add("MAYOR").DataType = System.Type.GetType("System.String");
            IMPORT.Columns.Add("SALDO").DataType = System.Type.GetType("System.String");
            IMPORT.Columns.Add("CATEGORIA").DataType = System.Type.GetType("System.String");
            IMPORT.Columns.Add("TIPO").DataType = System.Type.GetType("System.Int32");
            CATALOGO = dbCatalogo.getCatalogoCuentas();
        }

        private void calcularTotales()
        {
            //lbTOTAL_UNIDADES.Text = tblCATALOGO.Rows.Count.ToString("N0");
        }



        private void EXAMINAR(object sender, EventArgs e)
        {
            openFileCatalogo.ShowDialog();
        }

        

        private void LIMPIAR(object sender, EventArgs e)
        {
            tblCATALOGO.DataSource = null;
        }


        private bool existCUENTA(string cuenta)
        {
            bool OK = false;
            if (cuenta != null && cuenta != string.Empty && CATALOGO.Rows.Count > 0 && CATALOGO.Select("COD_CTA LIKE " +cuenta).Count() > 0)
            {
                OK = true;
            }
            return OK;
        }

        private void openFileCatalogo_FileOk(object sender, CancelEventArgs e)
        {
            progreso.Minimum = 0;
            progreso.Value = 0;
            string filePath = openFileCatalogo.FileName;
            string extension = Path.GetExtension(filePath);
            string header = "YES";
            string conStr;
            string sheetName = "CATALOGO";
            int f = 1;

            conStr = string.Empty;
            switch (extension)
            {
                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            try
            {
                OleDbConnection conn = new OleDbConnection(conStr);
                OleDbDataAdapter ada = new OleDbDataAdapter("SELECT * From [" + sheetName + "$] ", conn);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                progreso.Maximum = dt.Rows.Count;
                if (dt.Rows.Count <= 1)
                {
                    MessageBox.Show("No hay datos que importar", "ERROR AL IMPORTAR ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Cuenta cuenta = new Cuenta();
                        if (existCUENTA(row.Field<string>("CODIGO")))
                        {
                            throw new Exception("CUENTA " + row.ItemArray[0].ToString() + " ya existe en el catalogo");
                        }
                        else
                        {
                            cuenta.COD_CTA = row.Field<string>("CODIGO");
                            cuenta.NOMBRE = row.Field<string>("CUENTA").Replace('&','y').Replace('>',' ');
                            cuenta.MAYOR = row.Field<string>("MAYOR");
                            switch (row.Field<string>("CATEGORIA").ToUpper())
                            {
                                case "A":
                                    cuenta.CATEGORIA = eCategoriaCuenta.ACTIVO; break;
                                case "ACTIVO":
                                    cuenta.CATEGORIA = eCategoriaCuenta.ACTIVO; break;
                                case "P":
                                    cuenta.CATEGORIA = eCategoriaCuenta.PASIVO; break;
                                case "PASIVO":
                                    cuenta.CATEGORIA = eCategoriaCuenta.PASIVO; break;
                                case "C":
                                    cuenta.CATEGORIA = eCategoriaCuenta.CAPITAL; break;
                                case "CAPITAL":
                                    cuenta.CATEGORIA = eCategoriaCuenta.CAPITAL; break;
                                case "E":
                                    cuenta.CATEGORIA = eCategoriaCuenta.EGRESO; break;
                                case "EGRESO":
                                    cuenta.CATEGORIA = eCategoriaCuenta.EGRESO; break;
                                case "I":
                                    cuenta.CATEGORIA = eCategoriaCuenta.INGRESO; break;
                                case "INGRESO":
                                    cuenta.CATEGORIA = eCategoriaCuenta.INGRESO; break;
                                case "L":
                                    cuenta.CATEGORIA = eCategoriaCuenta.LIQUIDACION; break;
                                case "LIQUIDACION":
                                    cuenta.CATEGORIA = eCategoriaCuenta.LIQUIDACION; break;
                                case "O":
                                    cuenta.CATEGORIA = eCategoriaCuenta.ORDEN; break;
                                case "ORDEN":
                                    cuenta.CATEGORIA = eCategoriaCuenta.ORDEN; break;
                                default: throw new Exception("ERROR CATEGORIA INVALIDA PARA LA CUENTA " + cuenta.COD_CTA);
                            }
                            eTipoCuenta t;
                            string x = row.Field<string>("TIPO");
                            if (x != null && x != string.Empty)
                            {
                                x = x.Trim().Replace(" ", "_").ToUpper();
                            }
                            if (Enum.TryParse(x, out t))
                            {
                                cuenta.TIPO = t;
                            }
                            else
                            {
                                cuenta.TIPO = eTipoCuenta.ND;
                            }
                            switch (row.Field<string>("SALDO").ToUpper())
                            {
                                case "A":
                                    cuenta.SALDO = eSaldoCuenta.ACREEDOR; break;
                                case "ACREEDOR":
                                    cuenta.SALDO = eSaldoCuenta.ACREEDOR; break;
                                case "D":
                                    cuenta.SALDO = eSaldoCuenta.DEUDOR; break;
                                case "DEUDOR":
                                    cuenta.SALDO = eSaldoCuenta.DEUDOR; break;
                                default: throw new Exception("ERROR SALDO INVALIDO EN CUENTA " + cuenta.COD_CTA);
                            }
                            IMPORT.Rows.Add(cuenta.COD_CTA, cuenta.NOMBRE, cuenta.MAYOR, cuenta.SALDO.ToString()[0], cuenta.CATEGORIA.ToString()[0], (int)cuenta.TIPO);
                            f++;
                            progreso.Value = IMPORT.Rows.Count * 100 / dt.Rows.Count;
                        }

                    }
                    tblCATALOGO.DataSource = IMPORT;
                }
                progreso.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar fila " + f + "\nDetalle:" + ex.Message, "ERROR AL IMPORTAR ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        


        private void tblITEMS_CALZADO_DataSourceChanged(object sender, EventArgs e)
        {
            calcularTotales();
        }






        private void btnPLANTILLA_Click(object sender, EventArgs e)
        {
            // Specify a file to read from and to create.
            saveFileCatalogoPlantilla = new SaveFileDialog();
            saveFileCatalogoPlantilla.Filter = "Excel File|*.xlsx";
            saveFileCatalogoPlantilla.Title = "Guardar Archivo Excel";
            saveFileCatalogoPlantilla.DefaultExt = "xlsx";
            saveFileCatalogoPlantilla.FileName = "PlantillaCatalogoCuenta.xlsx";
            saveFileCatalogoPlantilla.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileCatalogoPlantilla.FileName != string.Empty )
            {
                string pathNew = saveFileCatalogoPlantilla.FileName;
                try
                {
                    // Read the source file into a byte array.
                    byte[] bytes = Properties.Resources.PlantillaImportCatalogo;
                    int numBytesToRead = (int)Properties.Resources.PlantillaImportCatalogo.Length;
                    numBytesToRead = bytes.Length;

                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(pathNew,
                        FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
                catch (FileNotFoundException ioEx)
                {
                    MessageBox.Show(ioEx.Message, "ERROR AL DESCARGAR PLANTILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ruta de Destino invalida", "ERROR AL DESCARGAR PLANTILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }





        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (IMPORT != null && IMPORT.Rows.Count > 0)
            {
                if (dbCatalogo.importCatalogo(IMPORT, Properties.Settings.Default.SUCURSAL, HOME.Instance().USUARIO.COD_EMPLEADO, Properties.Settings.Default.SISTEMA))
                {
                    CatalogoCuentaForm.Instance().cargarDatos();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("NO HAY DATOS QUE IMPORTAR", "ERROR AL IMPORTAR PLANTILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
