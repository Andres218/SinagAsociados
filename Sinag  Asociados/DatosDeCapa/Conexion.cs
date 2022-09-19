using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeCapa

 {
    public class Conexion
    {


        private string texto; 
        public SqlConnection conneccion;

        public string TEXTO
        {
            get { return texto; }
            set { texto = value; }
        }

        public object Id_Empleado { get; private set; }

        public Conexion()
         {

            string rutaconexion = "Data source=(localdb)\\MSSQLlocalDB;initial catalog =PROYECTOESTAMPADOS;integrated security = true";
            conneccion = new SqlConnection(rutaconexion);
         }
        public DataSet ConsultarSQL(string SentenciaSQL)
        {
            try
            {
                conneccion.Open();
                SqlDataAdapter objRes = new SqlDataAdapter(SentenciaSQL, conneccion);
                DataSet datos = new DataSet();
                objRes.Fill(datos, "DatosConsultados");
                texto = "La consulta de datos fue exitosa";
                return datos;
            }
            catch (Exception MiExc)
            {
                DataSet datos2 = new DataSet();
                texto = "ERROR: " + MiExc.Message;
                return datos2;
            }
            finally { conneccion.Close(); }
        }
        public bool EjecutarSQL(String SentenciaSQL)
        {
            try
            {
                conneccion.Open();
                SqlCommand MiComando = new SqlCommand
                {
                    Connection = conneccion,
                    CommandText = SentenciaSQL
                };
                MiComando.ExecuteNonQuery();

                TEXTO = "proceso ejecutado con exito";
                return true;

            }
            catch (Exception e)
            {
                TEXTO = "se presento el siguiente error" + e.Message;
                return false;

            }
            finally
            {
                conneccion.Close();
            }
        }


        public string SP_Login(string usuario,string contraseña)
    {
        try
        {
            string rol = "";
            SqlDataReader respuesta;
                SqlCommand comand = new SqlCommand("SP_Login", conneccion);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario;
                comand.Parameters.Add("@contraseña", SqlDbType.VarChar, 20).Value = contraseña;
            conneccion.Open();
            respuesta = comand.ExecuteReader();
            if (respuesta.Read()== true)
            {
                rol = respuesta["RolEmpleado"].ToString();
            }
            return rol;
        }
        catch (Exception exc)
        {
                return texto + "Error:" + exc.Message;

        

        }
        finally
        {
                conneccion.Close();


   
        }


    }
         public void EMPLEADO(string NOMBRE, string USUARIO, string CONTRASEÑA, string ROL)
         {
            try
            {

                SqlCommand command = new SqlCommand("SP_INEMPLEADO", conneccion)
                {
                    CommandType =
                    CommandType.StoredProcedure
                };
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
                command.Parameters.Add("@COD_Empleado", SqlDbType.VarChar, 15).Value = Id_Empleado;
            }

            catch (SqlException)
            {


            }
         }
    }
}






