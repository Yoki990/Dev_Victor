using Ex02.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Repository
{
    internal class CommandesRepository
    {

        string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public void CreateTableCommandes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                CREATE TABLE IF NOT EXISTS Commandes (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    id_client INT,
                    date_commande DATE,
                    total DOUBLE

                );
                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Client> AfficherTousLesClients()
        {
            List<Client> Clients = new List<Client>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Client;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Clients.Add(new Client(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("dateNaissance"),
                            reader.GetString("email")
                         ));
                    }
                }
            }
            return Clients;
        }
}
