using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB
{
    using System.Windows.Forms;
    using System.Data;
    using MySql.Data.MySqlClient;
    using MODELO;

    public class DBSIC
    {
        private DBConexion conn;

        public DBSIC()
        {
            conn = DBConexion.Instance();
        }


        //PROCEDIMIENTOS

        public DataTable getDeptos()
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_GET_DEPTOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e) { }
            return datos;
        }



        public DataTable getMunicipios(string d)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_GET_MUNICIPIOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter depto = cmd.Parameters.Add("departamento", MySqlDbType.VarChar, 30);
                depto.Direction = ParameterDirection.Input;
                depto.Value = d;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e) { }
            return datos;
        }




        public DataTable getLOG(string sistema, string tabla, string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_GET_LOG;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;
                MySqlParameter tbl = cmd.Parameters.Add("tbl", MySqlDbType.VarChar, 50);
                tbl.Direction = ParameterDirection.Input;
                MySqlParameter cod = cmd.Parameters.Add("cod", MySqlDbType.VarChar, 50);
                cod.Direction = ParameterDirection.Input;

                sys.Value = sistema;
                tbl.Value = tabla;
                cod.Value = codigo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR EL LOG DE TRANSACCIONES \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        //FUNCIONES
        public DateTime date_system()
        {
            DateTime fecha = new DateTime();
            try
            {
                string sql = "SELECT ddicark.FN_GET_DATE_SYSTEM();";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                fecha = (DateTime)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            { MessageBox.Show("NO SE PUDO OBTENER FECHA DE SERVIDOR", "ERROR SERVER", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            return fecha;
        }






        public bool LOGIN(string sistema, string usuario, string password)
        {
            bool reader = false;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT ddicark.FN_LOGIN(@sys,@user,@pass)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;
                MySqlParameter user = cmd.Parameters.Add("user", MySqlDbType.VarChar, 15);
                user.Direction = ParameterDirection.Input;
                MySqlParameter pass = cmd.Parameters.Add("pass", MySqlDbType.VarChar, 32);
                pass.Direction = ParameterDirection.Input;

                user.Value = usuario;
                pass.Value = md5(password);
                sys.Value = sistema;

                reader = (bool)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                reader = false;
                MessageBox.Show(e.Message, "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return reader;
        }



        public static string md5(string password)
        {
            //Declaraciones
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //Conversion
            Byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));  //genero el hash a partir de la password original

            //return BitConverter.ToString(encodedBytes);      //esto, devuelve el hash con "-" cada 2 char
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), @"-", "");     //devuelve el hash continuo y en minuscula. (igual que en php)
        }




        //CONFIG CONTABLE

        private string buildItemsConfigConta(DataTable cuentas)
        {
            string items = "";
            foreach (DataRow row in cuentas.Rows)
            {
                string cuenta = null;
                if (row.Field<string>("COD_CTA") != "Ninguna")
                {
                    cuenta = row.Field<string>("COD_CTA");
                }
                items = items + row.Field<string>("COD_SUC") + ">"
                    + row.Field<string>("TIPO_CUENTA") + ">"
                    + cuenta +"&";
            }
            return items;
        }


        public DataTable getConfigConta(eSistema sistema)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM ddsic.view_config_cuentas WHERE COD_SISTEM = @sys;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                sys.Value = sistema.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LAS CUENTAS CONFIGURADAS DEL SISTEMA " + sistema.ToString() + " \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public bool setConfigConta(eSistema sistemconta,DataTable cuentas, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_SET_CONFIG_CONTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter items_cuentas = cmd.Parameters.Add("items_cuentas", MySqlDbType.LongText);
                items_cuentas.Direction = ParameterDirection.Input;
                MySqlParameter sistemconfig = cmd.Parameters.Add("sistemconfig", MySqlDbType.VarChar, 20);
                sistemconfig.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                sistemconfig.Value = sistemconta;
                items_cuentas.Value = buildItemsConfigConta(cuentas);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CONFIGURACION DE CUENTAS ACTUALIZADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR CONFIGURACION DE CUENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }


        private string buildItemsConfigInvConta(DataTable cuentas)
        {
            string items = "";
            foreach (DataRow row in cuentas.Rows)
            {
                string cuenta = null;
                if (row.Field<string>("COD_CTA") != "Ninguna")
                {
                    cuenta = row.Field<string>("COD_CTA");
                }
                items = items + row.Field<string>("CATEGORIA") + ">"
                    + row.Field<string>("COD_ITEM") + ">"
                    + cuenta + "&";
            }
            return items;
        }


        public DataTable getConfigInvConta(eCategoriaInv categoria)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM ddsic.view_config_inv WHERE CATEGORIA = @cat;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                cat.Value = categoria.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LAS CUENTAS CONFIGURADAS DE CATEGORIA " + categoria.ToString() + " \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public bool setConfigInvConta(eCategoriaInv categoriaconta, DataTable cuentas, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_SET_CONFIG_INV_CONTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter items_cuentas = cmd.Parameters.Add("items_cuentas", MySqlDbType.LongText);
                items_cuentas.Direction = ParameterDirection.Input;
                MySqlParameter categoriaconfig = cmd.Parameters.Add("categoriaconfig", MySqlDbType.VarChar, 50);
                categoriaconfig.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                categoriaconfig.Value = categoriaconta.ToString();
                items_cuentas.Value = buildItemsConfigInvConta(cuentas);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CONFIGURACION DE CUENTAS DE INVENTARIO ACTUALIZADAS", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR CONFIGURACION DE CUENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool insertConfigInvConta(eCategoriaInv categoria, string estilo,string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_INSERT_INV_CONTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;
                MySqlParameter item = cmd.Parameters.Add("item", MySqlDbType.VarChar, 15);
                item.Direction = ParameterDirection.Input;


                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;


                cat.Value = categoria.ToString();
                item.Value = estilo;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CONFIGURACION DE CUENTAS DE INVENTARIO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL REGISTRAR CONFIGURACION DE INVENTARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool deleteConfigInvConta(eCategoriaInv categoria, string estilo, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_DELETE_INV_CONTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;
                MySqlParameter item = cmd.Parameters.Add("item", MySqlDbType.VarChar, 15);
                item.Direction = ParameterDirection.Input;


                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;


                cat.Value = categoria.ToString();
                item.Value = estilo;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CONFIGURACION DE CUENTAS DE INVENTARIO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show(ex.Message, "ERROR AL ELIMINAR CONFIGURACION DE INVENTARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        //CATEGORIAS Y CATALOGO PRODUCTOS

        public DataTable getEstilos(eCategoriaInv categoria)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM ddicark.view_catalogo WHERE CATEGORIA = @cat;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                cat.Value = categoria.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR CATALOGO DE CATEGORIA " + categoria.ToString() + " \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        

        //PERSONAL
        public DataTable getPersonal(ePuestoPersonal puesto)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "ddicark.SP_GET_PERSONAL;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.VarChar, 50);
                tipo.Direction = ParameterDirection.Input;

                tipo.Value = puesto.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUEDE CONSULTAR " + puesto.ToString() + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        //SUCURSALES
        public DataTable getSucursales(eSistema sistema)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "ddicark.SP_GET_SUCURSALES;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                sys.Value = sistema.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUEDE CONSULTAR SUCURSALES DE " + sistema.ToString() + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


    }
}
