using DatosDeCapa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCapa
{
   public class Cliente : Conexion
    {
        private string id_cliente;
        private string nombre;
        private string genero;
        private string identificacion;
        private string direccion;
        private string correo;
        private string telefono;
        private string estadocliente;
       

        public string Id_Cliente
        {
            get
            { return id_cliente; }
            set
            { id_cliente = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string EstadoCliente
        {
            get { return estadocliente; }
            set { estadocliente = value; }
        }

        public bool Procedimineto_Registrar_Cliente()
        {
            string Registrar_Cliente = "EXEC SP_INCLIENTE @COD_Cliente = '" + this.id_cliente + "', @NombreCliente = '" + this.nombre +
                "', @GeneroCliente = '" + this.genero + "', @NumeroDeidentificacion_Cliente = '" + this.identificacion +
                "', @Correo_Cliente = '" + this.correo + "', @DireccionCliente = '" + this.direccion + "', @TelefonoCliente = '" + this.telefono +
                "', @EstadoCliente = '" + this.estadocliente + "'";
            bool respuestasQL = EjecutarSQL(Registrar_Cliente);
            return respuestasQL;
        }

        public DataSet Procedimiento_Consultar_Cliente(string INFORMACION_BUSCADA,string OPCION_BUSCADA)
        {
            string Consultar_Cliente = "EXEC SP_SELECLIENTE @INFORMACION_BUSCADA = '" + INFORMACION_BUSCADA + "', @OPCION_BUSCADA = '" + OPCION_BUSCADA + "'";
            DataSet Consultar_Total_Cliente = ConsultarSQL(Consultar_Cliente);
            return Consultar_Total_Cliente;
        }

        public bool Procedimiento_Actualizar_Cliente()
        {
            string Actualizar_Cliente = "EXEC SP_ACCLIENTE @COD_Cliente = '" + this.id_cliente + "', @NombreCliente = '" + this.nombre +
                "', @GeneroCliente = '" + this.genero + "', @NumeroDeidentificacion_Cliente = '" + this.identificacion +
                "', @DireccionCliente = '" + this.direccion + "', @TelefonoCliente = '" + this.telefono + "', @EstadoCliente = '" + this.estadocliente + "'";
            bool respuestasQL = EjecutarSQL(Actualizar_Cliente);
            return respuestasQL;
        }

        public bool Procedimiento_Eliminar_Cliente(string INFORMACION_BUSCADA)
        {
            string Eliminar_Cliente = "EXEC SP_DELECLIENTE @INFORMACION_BUSCADA = '" + INFORMACION_BUSCADA + "'";
            bool respuestasQL = EjecutarSQL(Eliminar_Cliente);
            return respuestasQL;
        }

    }
}