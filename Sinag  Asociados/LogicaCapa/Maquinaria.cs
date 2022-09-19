using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCapa
{
    public class Maquinaria
    {
        private string id_empleado;
        private string id_articulo;
        private string nombre_maquinaria;
        private string numero_maquinaria;
        private string cantidad_maquinaria;
        private string precio_unidad;
        private string fecha_ultima_modificacion;
        private string precio_total;
        private string metodo_pago;
        private string estado_maquina;


        public string ID_EMPLEADO
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }
        public string ID_ARTICULO
        {
            get { return id_articulo; }
            set { id_articulo = value; }
        }
        public string Nombre__Maquinaria
        {
            get { return nombre_maquinaria; }
            set { nombre_maquinaria = value; }
        }
        public string Numero_Maquinaria
        {
            get { return numero_maquinaria; }
            set { numero_maquinaria = value; }
        }
        public string Cantidad_Maquinaria
        {
            get { return cantidad_maquinaria; }
            set { cantidad_maquinaria = value; }       
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
        public string ESTADO_MAQUINA
        {
            get { return estado_maquina; }
            set { estado_maquina = value; }
        }
    }
}
