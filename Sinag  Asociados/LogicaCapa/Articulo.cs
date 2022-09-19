using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCapa
{
    public class Articulo
    {
        private string nombre_articulo;
        private string numero_articulo;
        private string cantidad_articulos;
        private string precio_unidad;
        private string fecha_ultima_modificacion;
        private string precio_total;
        private string metodo_pago;

        public string Nombre__Articulo
        {
            get { return nombre_articulo; }
            set { nombre_articulo = value; }
        }
        public string Numero_Articulo
        {
            get { return numero_articulo; }
            set { numero_articulo = value; }
        }
        public string Cantidad_Articulos
        {
            get { return cantidad_articulos; }
            set { cantidad_articulos = value; }       
        }
        public string Precio_Unidad
        {
            get { return precio_unidad; }
            set { precio_unidad = value; }
        }
        public string Fecha_Ultima_Modificacion
        {
            get { return fecha_ultima_modificacion; }
            set { fecha_ultima_modificacion = value; }
        }
        public string Precio_Total
        {
            get { return precio_total; }
            set { precio_total = value; }
        }
        public string Metodo_Pago
        {
            get { return metodo_pago; }
            set { metodo_pago = value; }
        }
    }
}
