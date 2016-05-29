using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PublicacionDOA 
    {
        private DataBase db;
        public PublicacionDOA()
        {
            db = DataBase.GetInstance();
        }

       /* public void crearSubasta(string cliente, string usuario, string password, string mail, string apellido, string nombre, int DOC, int telefono, string tipoDOC, string codPos, string Dpto, string localidad, int piso, int numero, string calle, DateTime nacimiento)
        {
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Alta_Cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RolAsignado", SqlDbType.NVarChar).Value = cliente;
           
            cmd.ExecuteNonQuery();

        }*/

    } 

  
}
