using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCapa
{
    public class Facturacion
    {
        private string id_servicio;
        private string id_facturacion;
        private string id_empleado;
        private string numero_de_facturacion;
        private string nombre_de_facturacion;
        private string fecha_de_entrega;
        private string cantidad_de_articulos_despachados;
        private string ultima_modificacion;
        private string valor_total;
        private string fecha_de_solicitud; 
        private string metodo_de_pago;
        private string estado_facturacion;
        
        public string ID_SERVICIO
        {
            get
            { return id_servicio; }
            set
            { id_servicio = value; }
        }
        public string ID_FACTURACION
        {
            get
            { return id_facturacion; }
            set
            { id_facturacion = value; }
        }
        public string ID_EMPLEADO
        {
            get
            { return id_empleado; }
            set
            { id_empleado = value; }
        }

        public string NUMERO_DE_FACTURACION
        { 
            get
            { return numero_de_facturacion; }
            set
            { numero_de_facturacion = value; }
        }
        public string NOMBRE_DE_FACTURACION
        {
            get
            { return nombre_de_facturacion; }
            set
            { nombre_de_facturacion = value; }
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
        public string Estado_Facturacion
        {
            get
            { return estado_facturacion; }
            set
            { estado_facturacion = value; }
        }
    }
}
