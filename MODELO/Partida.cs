using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class Partida
    {
        public int PERIODO;
        public int NUMPARTIDA;
        public string COD_TRANS;
        public DateTime FECHA;
        public string REFERENCIA;
        public string CONCEPTO;
        public bool INIT_BALANCE;
        public bool BLOQUEADA;

        public DataTable MOVIMIENTOS;

        public Partida()
        {
            MOVIMIENTOS = new DataTable();
            MOVIMIENTOS.Columns.Add("COD_CTA").DataType = System.Type.GetType("System.String");
            MOVIMIENTOS.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            MOVIMIENTOS.Columns.Add("DEBE").DataType = System.Type.GetType("System.Decimal");
            MOVIMIENTOS.Columns.Add("HABER").DataType = System.Type.GetType("System.Decimal");
            
        }


        public static Partida ConvertToPartida(DataRow dr)
        {
            Partida asiento = null;
            if (dr != null)
            {
                asiento = new Partida();
                if (dr.Table.Columns.Contains("PERIODO")) { asiento.PERIODO = dr.Field<int>("PERIODO"); }
                if (dr.Table.Columns.Contains("NUMPARTIDA")) { asiento.NUMPARTIDA = dr.Field<int>("NUMPARTIDA"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { asiento.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { asiento.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("REFERENCIA")) { asiento.REFERENCIA =dr.Field<string>("REFERENCIA"); }
                if (dr.Table.Columns.Contains("CONCEPTO")) { asiento.CONCEPTO = dr.Field<string>("CONCEPTO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { asiento.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("BLOQUEADA")) { asiento.BLOQUEADA = dr.Field<bool>("BLOQUEADA"); }
                
            }
            return asiento;

        }



        public Partida Copy()
        {
            Partida copy = (Partida)this.MemberwiseClone();
            copy.MOVIMIENTOS = this.MOVIMIENTOS.Copy();
            return copy;
        }


        public decimal DEBE
        {
            get
            {
                decimal total = (decimal)0.00;
                if(this.MOVIMIENTOS != null ){ total = this.MOVIMIENTOS.AsEnumerable().Select(r => r.Field<decimal>("DEBE")).Sum();}
                return total;
            }
        }



        public decimal HABER
        {
            get
            {
                decimal total = (decimal)0.00;
                if(this.MOVIMIENTOS != null ){ total = this.MOVIMIENTOS.AsEnumerable().Select(r => r.Field<decimal>("HABER")).Sum();}
                return total;
            }
        }




        public decimal BALANCE
        {
            get
            {
                decimal total = this.DEBE - this.HABER;
                return total;
            }
        }


    }
}
