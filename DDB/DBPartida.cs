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

    public class DBPartida
    {
        private DBConexion conn;

        public DBPartida()
        {
            conn = DBConexion.Instance();
        }




        private string buildItemsPartida(Partida partida)
        {
            string items = "";
            foreach (DataRow row in partida.MOVIMIENTOS.Rows)
            {
                items = items + row.Field<string>("COD_CTA") + ">"
                    + row.Field<string>("DESCRIPCION") + ">"
                    + row.Field<decimal>("DEBE") + ">"
                    + row.Field<decimal>("HABER") + "&";
            }
            return items;
        }




        // FUNCIONES CRUD
        public bool insert(Partida partida, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_INSERT_PARTIDA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;
                MySqlParameter num_partida = cmd.Parameters.Add("num_partida", MySqlDbType.Int32);
                num_partida.Direction = ParameterDirection.Input;
                MySqlParameter fecha_partida = cmd.Parameters.Add("fecha_partida", MySqlDbType.Date);
                fecha_partida.Direction = ParameterDirection.Input;
                MySqlParameter ref_partida = cmd.Parameters.Add("ref_partida", MySqlDbType.VarChar, 20);
                ref_partida.Direction = ParameterDirection.Input;
                MySqlParameter concepto_partida = cmd.Parameters.Add("concepto_partida", MySqlDbType.VarChar, 100);
                concepto_partida.Direction = ParameterDirection.Input;
                MySqlParameter bloquear_partida = cmd.Parameters.Add("bloquear_partida", MySqlDbType.Bit);
                bloquear_partida.Direction = ParameterDirection.Input;

                MySqlParameter items_partida = cmd.Parameters.Add("items_partida", MySqlDbType.LongText);
                items_partida.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                num_periodo.Value = partida.PERIODO;
                num_partida.Value = partida.NUMPARTIDA;
                fecha_partida.Value = partida.FECHA;
                ref_partida.Value = partida.REFERENCIA;
                concepto_partida.Value = partida.CONCEPTO;
                bloquear_partida.Value = partida.BLOQUEADA;

                items_partida.Value = buildItemsPartida(partida);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("PARTIDA REGISTRADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(null, e.Message, "ERROR AL REGISTRAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }


        public bool update(Partida partida, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_UPDATE_PARTIDA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;
                MySqlParameter num_partida = cmd.Parameters.Add("num_partida", MySqlDbType.Int32);
                num_partida.Direction = ParameterDirection.Input;
                MySqlParameter fecha_partida = cmd.Parameters.Add("fecha_partida", MySqlDbType.Date);
                fecha_partida.Direction = ParameterDirection.Input;
                MySqlParameter ref_partida = cmd.Parameters.Add("ref_partida", MySqlDbType.VarChar, 20);
                ref_partida.Direction = ParameterDirection.Input;
                MySqlParameter concepto_partida = cmd.Parameters.Add("concepto_partida", MySqlDbType.VarChar, 100);
                concepto_partida.Direction = ParameterDirection.Input;
                MySqlParameter bloquear_partida = cmd.Parameters.Add("bloquear_partida", MySqlDbType.Bit);
                bloquear_partida.Direction = ParameterDirection.Input;

                MySqlParameter items_partida = cmd.Parameters.Add("items_partida", MySqlDbType.LongText);
                items_partida.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                num_periodo.Value = partida.PERIODO;
                num_partida.Value = partida.NUMPARTIDA;
                fecha_partida.Value = partida.FECHA;
                ref_partida.Value = partida.REFERENCIA;
                concepto_partida.Value = partida.CONCEPTO;
                bloquear_partida.Value = partida.BLOQUEADA;

                items_partida.Value = buildItemsPartida(partida);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("PARTIDA ACTUALIZADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool delete(Partida partida, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "ddsic.SP_DELETE_PARTIDA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;
                MySqlParameter num_partida = cmd.Parameters.Add("num_partida", MySqlDbType.Int32);
                num_partida.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                num_periodo.Value = partida.PERIODO;
                num_partida.Value = partida.NUMPARTIDA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show(" PARTIDA N° " + partida.NUMPARTIDA + " ELIMINADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR PARTIDA N° " + partida.NUMPARTIDA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public int nextNumPartida(int periodo)
        {
            int reader = 0;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT ddsic.FN_NEXT_NUMPARTIDA(@num_periodo)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;

                num_periodo.Value = periodo;

                reader = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = 0; }
            return reader;
        }







        public DataTable getMovimientos(Partida partida)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddsic.view_libro_diario WHERE PERIODO = @num_periodo AND NUMPARTIDA = @num_partida;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;
                MySqlParameter num_partida = cmd.Parameters.Add("num_partida", MySqlDbType.Int32);
                num_partida.Direction = ParameterDirection.Input;

                num_periodo.Value = partida.PERIODO;
                num_partida.Value = partida.NUMPARTIDA;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR MOVIMIENTO DE PARTIDA DIARIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            return datos;
        }



        public DataTable showPartidas(int periodo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddsic.view_partidas WHERE PERIODO = @num_periodo;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;

                num_periodo.Value = periodo;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR MOVIMIENTO DE PARTIDA DIARIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            return datos;
        }




        public DataRow findByPartida(int periodo , int partida)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM ddsic.view_partidas WHERE PERIODO = @num_periodo AND NUMPARTIDA = @num_partida;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;


                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;
                MySqlParameter num_partida = cmd.Parameters.Add("num_partida", MySqlDbType.Int32);
                num_partida.Direction = ParameterDirection.Input;

                num_periodo.Value = periodo;
                num_partida.Value = partida;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL OBTENER PARTIDA DIARIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }




        //CONTABILIZAR TRANSACCIONES


        public DataTable getTransPendientes(eSistema sistema , string sucursal,DateTime desde , DateTime hasta)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddsic.SP_GET_TRANS_PENDIENTES;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter inicio = cmd.Parameters.Add("inicio", MySqlDbType.Date);
                inicio.Direction = ParameterDirection.Input;
                MySqlParameter fin = cmd.Parameters.Add("fin", MySqlDbType.Date);
                fin.Direction = ParameterDirection.Input;

                sys.Value = sistema.ToString();
                suc.Value = sucursal;
                inicio.Value = desde.Date;
                fin.Value = hasta.Date;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR TRANSACCIONES DE " + sistema.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable getPreviewPartida(eSistema sistema, string transaccion, string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddsic.SP_GET_PREVIEW_PARTIDA;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;
                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.VarChar, 50);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter trans = cmd.Parameters.Add("trans", MySqlDbType.VarChar, 15);
                trans.Direction = ParameterDirection.Input;

                sys.Value = sistema.ToString();
                tipo.Value = transaccion;
                trans.Value = codigo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL OBTENER PREVIEW DE PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






        //REPORTES


        public DataTable getLIBRO_DIARIO(int periodo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddsic.view_libro_diario WHERE PERIODO = @num_periodo;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter num_periodo = cmd.Parameters.Add("num_periodo", MySqlDbType.Int32);
                num_periodo.Direction = ParameterDirection.Input;

                num_periodo.Value = periodo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR PARTIDAS DIARIAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


    }
}
