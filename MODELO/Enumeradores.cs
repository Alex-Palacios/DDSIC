using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    public enum eTransaccion
    {
        PARTIDA= 1,

    }

    public enum eSistema
    {
        DDSIC,
        PRENDASAL,
        KAROL
    }


    public enum eOperacion
    {
        INSERT,
        UPDATE,
        DELETE,
        SEARCH,
        PREVIEW
    }



    public enum eEstado
    {
        HISTORICO = -2,
        PREINGRESADO = -1,
        ANULADO = 0,
        CONTABILIZADO = 1
    }


    public enum ePuestoPersonal
    {
        ADMIN = 1,
        GERENTE,
        CONTADOR,
        BODEGA,
        VENDEDOR,
        ASESOR,
        SUPERVISOR
    }



    public enum eTipoUsuario
    {
        ADMIN = 1,
        GERENTE,
        CONTADOR,
        AUXILIAR
    }



    public enum eTipoPago
    {
        EFECTIVO = 1,
        CHEQUE,
        REMESA
    }


    public enum eCategoriaCuenta
    {
        ACTIVO = 'A',
        PASIVO = 'P',
        CAPITAL = 'C',
        EGRESO  = 'E',
        INGRESO = 'I',
        LIQUIDACION = 'L',
        ORDEN = 'O'
    }


    public enum eTipoCuenta
    {
        ND,
        EFECTIVO,
        CxC,
        OTRO_ACTIVO,
        INVENTARIO,
        ACTIVO_FIJO,
        DEPRECIACION,
        CxP,
        UTILIDAD,
        CAPITAL,
        GASTO,
        COSTO,
        INGRESO,
        TRANSITORIA,
        ORDEN
    }

    public enum eClaseCuenta
    {
        RUBRO = 1,
        AGRUPACION,
        MAYOR,
        SUBCUENTA
    }

    public enum eSaldoCuenta
    {
        DEUDOR = 'D',
        ACREEDOR = 'A',
    }




    class Enumeradores
    {
    }
}
