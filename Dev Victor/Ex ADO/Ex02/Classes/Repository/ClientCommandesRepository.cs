using Ex02.Classes.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Classes.Repository
{
    internal class ClientCommandesRepository
    {
        string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public void CreateTableClient()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                CREATE TABLE IF NOT EXISTS Client (
                    id_client INT AUTO_INCREMENT PRIMARY KEY,
                    nom VARCHAR(255),
                    prenom VARCHAR(255),
                    adresse VARCHAR(255),
                    code_Postal VARCHAR(255),
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
                    total DECIMAL
                );
                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public void CreateTableProduits()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                CREATE TABLE IF NOT EXISTS Produits (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nom_produit VARCHAR(255),
                    client_id INT NOT NULL,
                    commandes_id INT,
                    CONSTRAINT fk_client_id FOREIGN KEY (client_id) REFERENCES Client(id_client),
                    CONSTRAINT fk_commandes_id FOREIGN KEY (commandes_id) REFERENCES Produits(id)
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
                            reader.GetInt32("id_client"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetString("adresse"),
                            reader.GetString("code_postal"),
                            reader.GetString("ville"),
                            reader.GetString("telephone")
                         ));
                    }
                }
            }
            return Clients;
        }
        public void AjouterUnClient(Client c)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Client (nom, prenom, adresse, code_postal, ville, telephone) " +
                    $"VALUES (@nom, @prenom, @adresse, @codePostal, @ville, @telephone)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", c.Nom);
                    command.Parameters.AddWithValue("@prenom", c.Prenom);
                    command.Parameters.AddWithValue("@adresse", c.Adresse);
                    command.Parameters.AddWithValue("@codePostal", c.CodePostal);
                    command.Parameters.AddWithValue("@ville", c.Ville);
                    command.Parameters.AddWithValue("@telephone", c.Telephone);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditerUnClient(Client c)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Client SET nom=@nom, prenom=@prenom, adresse=@adresse, codePostal=@codePostal, ville=@ville, telephone=@telephone, WHERE id_client=@id_client;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", c.Nom);
                    command.Parameters.AddWithValue("@prenom", c.Prenom);
                    command.Parameters.AddWithValue("@adresse", c.Adresse);
                    command.Parameters.AddWithValue("@codePostal", c.CodePostal);
                    command.Parameters.AddWithValue("@ville", c.Ville);
                    command.Parameters.AddWithValue("@telephone", c.Telephone);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Commandes> AfficherTousLesProduits()
        {
            List<Commandes> Produits = new List<Commandes>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Commandes;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Produits.Add(new Commandes(
                            reader.GetInt32("id_client"),
                            reader.GetString("nom")
                         ));
                    }
                }
            }
            return Produits;
        }
        public void AjouterUnProduit(Commandes p)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Produits (nom_produit) " + $"VALUES (@nom)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", p.Nom);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditerUnProduit(Commandes p)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Commandes SET nom=@nom, WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", p.Nom);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void SupprimerUnProduit(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Commandes WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void LierTablesClientsCommandes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT Clients.*, Commandes.* FROM Clients INNER JOIN Commandes ON Clients.id = Commandes.id_client;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AjouterUneCommandeAUnClient(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Commandes (nom, prenom, id_client);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                }
            }
        }
        public void SupprimerUnClientEtSesCommandes(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Client WHERE id_client=@id_client;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_client", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AfficherDetailClientCommandes(int id)
        {

            List<Client> clients = new List<Client>();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM Clients WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clients.Add(new Client(
                            reader.GetInt32("id_client"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetString("adresse"),
                            reader.GetString("codePostal"),
                            reader.GetString("ville"),
                            reader.GetString("telephone")

                            ));

                    }
                }
            }
        }
    }
}




