using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDB
{
    using MODELO;
    using System.Data;
    using MySql.Data.MySqlClient;

    public class DBCuenta
    {
        private DBConexion conn;

        public DBCuenta()
        {
            conn = DBConexion.Instance();
        }


        // FUNCIONES CRUD


        private string buildItemsImport(DataTable ITEMS)
        {
            string items = "";
            foreach (DataRow row in ITEMS.Rows)
            {
                items = items
                    + row.Field<string>("CODIGO") + ">"
                    + row.Field<string>("CUENTA") + ">"
                    + row.Field<string>("MAYOR") + ">"
                    + row.Field<string>("SALDO") + ">"
                    + row.Field<string>("CATEGORIA") + ">"
                    + row.Field<int>("TIPO") + "&";
            }
            return items;
        }



        public bool importCatalogo(DataTable items, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_IMPORT_CATALOGO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter items_cta = cmd.Parameters.Add("items_cta", MySqlDbType.LongText);
                items_cta.Direction = ParameterDirection.Input;


                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                items_cta.Value = buildItemsImport(items);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("IMPORTACION DE CATALOGO DE CUENTAS COMPLETADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL IMPORTAR CATALOGO DE CUENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool insert(Cuenta cuenta, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_INSERT_CUENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter nombre_cta = cmd.Parameters.Add("nombre_cta", MySqlDbType.VarChar, 100);
                nombre_cta.Direction = ParameterDirection.Input;
                MySqlParameter mayor_cta = cmd.Parameters.Add("mayor_cta", MySqlDbType.VarChar, 15);
                mayor_cta.Direction = ParameterDirection.Input;
                MySqlParameter saldo_cta = cmd.Parameters.Add("saldo_cta", MySqlDbType.VarChar, 1);
                saldo_cta.Direction = ParameterDirection.Input;
                MySqlParameter cat_cta = cmd.Parameters.Add("cat_cta", MySqlDbType.VarChar,1);
                cat_cta.Direction = ParameterDirection.Input;
                MySqlParameter tipo_cta = cmd.Parameters.Add("tipo_cta", MySqlDbType.Int32);
                tipo_cta.Direction = ParameterDirection.Input;


                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                
                codigo.Value = cuenta.COD_CTA;
                nombre_cta.Value = cuenta.NOMBRE;
                mayor_cta.Value = cuenta.MAYOR;
                saldo_cta.Value = cuenta.SALDO;
                cat_cta.Value = cuenta.CATEGORIA;
                tipo_cta.Value = (int)cuenta.TIPO;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("CUENTA REGISTRADA EN EL CATALOGO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL REGISTRAR CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(Cuenta cuenta, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_UPDATE_CUENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter nombre_cta = cmd.Parameters.Add("nombre_cta", MySqlDbType.VarChar, 100);
                nombre_cta.Direction = ParameterDirection.Input;
                MySqlParameter mayor_cta = cmd.Parameters.Add("mayor_cta", MySqlDbType.VarChar, 15);
                mayor_cta.Direction = ParameterDirection.Input;
                MySqlParameter saldo_cta = cmd.Parameters.Add("saldo_cta", MySqlDbType.VarChar, 1);
                saldo_cta.Direction = ParameterDirection.Input;
                MySqlParameter cat_cta = cmd.Parameters.Add("cat_cta", MySqlDbType.VarChar,1);
                cat_cta.Direction = ParameterDirection.Input;
                MySqlParameter tipo_cta = cmd.Parameters.Add("tipo_cta", MySqlDbType.Int32);
                tipo_cta.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                codigo.Value = cuenta.COD_CTA;
                nombre_cta.Value = cuenta.NOMBRE;
                mayor_cta.Value = cuenta.MAYOR;
                saldo_cta.Value = cuenta.SALDO;
                cat_cta.Value = cuenta.CATEGORIA;
                tipo_cta.Value = (int)cuenta.TIPO;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("CUENTA ACTUALIZADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL ACTUALIZAR CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool changeACTIVA(string cuenta, bool activa, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_CHANGE_ESTADO_CUENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado", MySqlDbType.Bit);
                estado.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                codigo.Value = cuenta;
                estado.Value = activa;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();

                string accion = "";
                if (activa)
                {
                    accion = "ACTIVADA";
                }
                else
                {
                    accion = "DESACTIVADA";
                }
                MessageBox.Show("CUENTA " + cuenta + " HA SIDO " + accion, "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL CAMBIAR ESTADO CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool changeCODIGO(string oldCodigo, string newCodigo, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_CHANGE_CODIGO_CUENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigoOld = cmd.Parameters.Add("old_codigo", MySqlDbType.VarChar, 15);
                codigoOld.Direction = ParameterDirection.Input;
                MySqlParameter codigoNew = cmd.Parameters.Add("new_codigo", MySqlDbType.VarChar, 15);
                codigoNew.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                codigoOld.Value = oldCodigo;
                codigoNew.Value = newCodigo;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CODIGO ID DE LA CUENTA " + oldCodigo + " CAMBIADA A " + newCodigo, "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL CAMBIAR CODIGO DE CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool delete(Cuenta cuenta, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_DELETE_CUENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                codigo.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                codigo.Value = cuenta.COD_CTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CUENTA CON CODIGO: " + cuenta + " ELIMINADA DEL CATALOGO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL ELIMINAR CUENTA DE CATALOGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        public DataTable getCatalogoCuentas()
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddsic.view_catalogo_cuentas;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR CATALOGO CUENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datos;
        }



        public DataTable getCatalogoCuentas(eClaseCuenta clase)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddsic.view_catalogo_cuentas WHERE CLASE = @clase_cta;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter clase_cta = cmd.Parameters.Add("clase_cta", MySqlDbType.VarChar, 50);
                clase_cta.Direction = ParameterDirection.Input;

                clase_cta.Value = clase.ToString();

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR CATALOGO CUENTAS DE " + clase.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datos;
        }


    }
}
