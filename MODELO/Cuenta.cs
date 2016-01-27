using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class Cuenta
    {
        public string COD_CTA;
        public string NOMBRE;
        public string MAYOR;
        public eSaldoCuenta SALDO;
        public eCategoriaCuenta CATEGORIA;
        public eTipoCuenta TIPO;
        public bool ACTIVA;

        public eClaseCuenta CLASE;


        public Cuenta()
        {

        }


        public static Cuenta ConvertToCuenta(DataRow dr)
        {
            Cuenta cuenta = null;
            if (dr != null)
            {
                cuenta = new Cuenta();
                if (dr.Table.Columns.Contains("COD_CTA")) { cuenta.COD_CTA = dr.Field<string>("COD_CTA"); }
                if (dr.Table.Columns.Contains("NOMBRE")) { cuenta.NOMBRE = dr.Field<string>("NOMBRE"); }
                if (dr.Table.Columns.Contains("MAYOR")) { cuenta.MAYOR = dr.Field<string>("MAYOR"); }
                if (dr.Table.Columns.Contains("SALDO")) { cuenta.SALDO = (eSaldoCuenta)Char.ConvertToUtf32(dr.Field<string>("SALDO"), 0); }
                if (dr.Table.Columns.Contains("CATEGORIA")) { cuenta.CATEGORIA = (eCategoriaCuenta)Char.ConvertToUtf32(dr.Field<string>("CATEGORIA"), 0); }
                if (dr.Table.Columns.Contains("TIPO")) { cuenta.TIPO = (eTipoCuenta)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("ACTIVA")) { cuenta.ACTIVA = dr.Field<bool>("ACTIVA"); }
                if (dr.Table.Columns.Contains("CLASE")) { cuenta.CLASE = (eClaseCuenta)Enum.Parse(typeof(eClaseCuenta), dr.Field<string>("CLASE")); }

            }
            return cuenta;

        }



        public Cuenta Copy()
        {
            Cuenta copy = (Cuenta)this.MemberwiseClone();
            return copy;
        }






    }
}
