using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCapa
{


    public class Servicio
    {

        private string id_servicio;
        private string nombre_pedido;
        private string fecha_de_despacho;
        private string fecha_de_solicitud;
        private string estadoservicio;




        public string Id_Servicio
        {
            get
            { return id_servicio; }
            set
            { id_servicio = value; }
        }

        public string Nombre_Pedido
        {
            get
            { return nombre_pedido; }
            set
            { nombre_pedido = value; }
        }

        public string Fecha_De_Despacho
        {
            get
            { return fecha_de_despacho; }
            set
            { fecha_de_despacho = value; }
        }

        public string Fecha_De_Solicitud
        {
            get
            { return fecha_de_solicitud; }
            set
            { fecha_de_solicitud = value; }
        }

        public string EstadoServicio
        {
            get
            { return estadoservicio; }
            set
            {estadoservicio = value; }
        }








    }

}
