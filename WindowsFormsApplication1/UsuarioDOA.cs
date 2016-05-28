using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class UsuarioDOA
    {
        private DataBase db;
        public UsuarioDOA()
        {
            db = DataBase.GetInstance();
        }

        public Usuario Login(string username, string password)
        {
            

            //especifico que SP voy a ejecutar
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Usuario_Login", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //seteo los parametros que recibe el stored procedure
            cmd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
            //ejecuto la consulta y traigo el resultado
            Usuario usuarioResultado = null;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                usuarioResultado = LoadObject(sdr);
            }
            sdr.Close();
            return usuarioResultado;
        }

        private Usuario LoadObject(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            //lo que va entre parentesis son los nombres de las columnas que devuelve el SP
            usuario.Username = reader["username"].ToString();
            usuario.Password = reader["password"].ToString();
            usuario.Habilitado = Convert.ToBoolean(reader["habilitado"].ToString());
            usuario.Id_rol = (int)reader["rol"];
            System.Console.Write(usuario.Username);
            System.Console.Write(usuario.Password);
            System.Console.Write(usuario.Habilitado);
            System.Console.Write(usuario.Id_rol);
            return usuario;
        }

        /*public void Bloquear(string username)
        {
            //especifico que SP voy a ejecutar
            SqlCommand cmd = new SqlCommand("SANTI_EL_LIDER.Usuario_Bloquear", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //seteo los parametros que recibe el stored procedure
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            cmd.ExecuteNonQuery();
        }*/
    }
}
