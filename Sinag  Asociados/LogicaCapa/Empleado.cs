using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeCapa;
namespace LogicaCapa
{
    public class Empleado : Conexion
    {
        private string codigo_empleado;
        private string nombre;
        private string genero;
     
        private string direccion;
        private string correo;
        private string telefono;
        private string usuario;
        private string contraseña;
        private string estado_empleado;
        private string rolempleado;

        public string Codigo_Empleado
        {
            get
            { return codigo_empleado; }
            set
            { codigo_empleado = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DataSet ConsultarEmpleado(object text)
        {
            throw new NotImplementedException();
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
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
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string SP_Login()
        {
            string RolEmpleado = SP_Login(this.usuario, this.contraseña);
            return RolEmpleado;
        }
        public string Estado_Empleado
        {
            get { return estado_empleado; }
            set { estado_empleado = value; }
        }
        public string ROLEMPLEADO
        {
            get { return rolempleado; }
            set { rolempleado = value; }
        }

        public bool Procedimiento_Registrar_Empleado()

        {
            string Registrar_Empleado =
            "EXEC SP_INEMPLEADO @COD_Empleado = '" + this.codigo_empleado +
            "', @Nom_Empleado = '" + this.nombre + "', @Gen_Empleado = '" + this.genero +
            "', @Dire_Empleado = '" + this.direccion +
            "', @Corre_Empleado = '" + this.correo + "', @Tele_Empleado = '" + this.telefono + "', @Est_Empleado = '"
            + this.estado_empleado + "', @ROL_Empleado = '" + this.rolempleado + "', @Usuario = '" + this.usuario + "', @Contraseña = '" + this.contraseña + "'";
            bool respuestaSQL = EjecutarSQL(Registrar_Empleado);
            return respuestaSQL;
        }
        public bool Procedimiento_ActualizarEmpleado()

        {
            string Actualizar_Empleado =
            "EXEC SP_ACTEMPLEADO @COD_Empleado  = '" + this.codigo_empleado +
            "', @Nom_Empleado = '" + this.nombre + "', @Gen_Empleado = '" + this.genero +
            "', @Dire_Empleado = '" + this.direccion
            + "', @Corre_Empleado = '" + this.correo + "', @Tele_Empleado = '" + this.telefono + "', @Est_Empleado = '"
            + this.estado_empleado + "', @ROL_Empleado = '" + this.rolempleado + "', @Usuario = '" + this.usuario + "', @Contraseña = '" + this.contraseña + "'";
            bool respuestaSQL = EjecutarSQL(Actualizar_Empleado);
            return respuestaSQL;
        }
        public bool Procedimiento_Eliminar_Empleado(string INFORMACION_BUSCADA)
        {
            string Eliminar_Empleado = "EXEC SP_DELEEMPLEADO @INFORMACION_BUSCADA = '" + INFORMACION_BUSCADA + "'";
            bool respuestaSQL = EjecutarSQL(Eliminar_Empleado);
            return respuestaSQL;
        }
        public DataSet Procedimiento_Consultar_Empleado(string INFORMACION_BUSCADA, string OPCION_BUSCADA)
        {
            string Consultar_Empleado = "EXEC SP_SELEMPLEADO @INFORMACION_BUSCADA = '" + INFORMACION_BUSCADA + "', @OPCION_BUSCADA = '" + OPCION_BUSCADA + "'";
            DataSet Consultar_Total_Empleado = ConsultarSQL(Consultar_Empleado);
            return Consultar_Total_Empleado;
        }
    }
}
