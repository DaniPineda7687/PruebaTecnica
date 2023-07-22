using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUsuarios
{
    public class DServiceUsuario
    {
        PruebaTecnicaEntities db = new PruebaTecnicaEntities();
        string connectionString = "Data Source=Daniel;initial catalog=PruebaTecnica;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        public void AgregarUsuario(string nombre, DateTime fechaNacimiento, string sexo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("spUsuarios_CRUD", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", DBNull.Value);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@Action", "Insert");

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    
    
        public List<Usuarios> GetUsuarios()
        {
            List<Usuarios> users = db.Usuarios.ToList();
            
            return users;
        }


        public Usuarios GetUsuarioById(int id)
        {
            Usuarios user = db.Usuarios.Find(id);
            return user;
        }

        public void ActualizarUsuario(int id, string nombre, DateTime fechaNacimiento, string sexo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("spUsuarios_CRUD", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@Action", "Update");

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("spUsuarios_CRUD", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Action", "Delete");

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
