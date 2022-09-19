using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCapa
{
    public class Historial
    {
        private string nombre_cliente;
        private string numero_de_venta;
        private string nombre_de_venta;
        private string fecha_de_entrega;
        private string cantidad_de_articulos_despachados;
        private string ultima_modificacion;
        private string valor_total;
        private string fecha_de_solicitud; 
        private string metodo_de_pago;


        public string NOMBRE_CLIENTE
        {
            get
            { return nombre_cliente; }
            set
            { nombre_cliente = value; }
        }
        public string NUMERO_DE_VENTA
        { 
            get
            { return numero_de_venta; }
            set
            { numero_de_venta = value; }
        }
        public string NOMBRE_DE_VENTA
        {
            get
            { return nombre_de_venta; }
            set
            { nombre_de_venta = value; }
        }
        public string FECHA_DE_ENTREGA
        {
            get
            { return fecha_de_entrega; }
            set
            { fecha_de_entrega = value; }
        }
        public string CANTIDAD_DE_ARTICULOS_DESPACHADOS
        {
            get
            { return cantidad_de_articulos_despachados; }
            set
            { cantidad_de_articulos_despachados = value; }
        }
        public string ULTIMA_MODIFICACION
        {
            get
            { return ultima_modificacion; }
            set
            { ultima_modificacion = value; }
        }
        public string VALOR_TOTAL
        {
            get
            { return valor_total; }
            set
            { valor_total = value; }
        }
        public string FECHA_DE_SOLICITUD
        {
            get
            { return fecha_de_solicitud; }
            set
            { fecha_de_solicitud = value; }
        }
        public string METODO_DE_PAGO
        {
            get
            { return metodo_de_pago; }
            set
            { metodo_de_pago = value; }
        }
    }
}
