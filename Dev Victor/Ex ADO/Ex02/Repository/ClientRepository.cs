using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Repository
{
    internal class ClientRepository
    {

        string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public void CreateTableClient()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                CREATE TABLE IF NOT EXISTS Client (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nom VARCHAR(255),
                    prenom VARCHAR(255),
                    adresse VARCHAR(255),
                    code_postal VARCHAR(255),
                    ville VARCHAR(255),
                    telephone VARCHAR(255)

                );
                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }


        }
    }
    }
}
