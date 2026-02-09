using Ex01.Classes.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Classes.Repository
{
    internal class EtudiantRepository
    {

        string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public void CreateTableEtudiant()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                CREATE TABLE IF NOT EXISTS Etudiant (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nom VARCHAR(255),
                    prenom VARCHAR(255),
                    dateNaissance DATE,
                    email VARCHAR(255) UNIQUE

                );
                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Etudiant> AfficherTousLesEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        etudiants.Add(new Etudiant(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("dateNaissance"),
                            reader.GetString("email")
                         ));
                    }
                }
            }
            return etudiants;
        }

        public void AjouterUnEtudiant(Etudiant p)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Etudiant (nom, prenom, dateNaissance, email) " +
                    $"VALUES (@nom,@prenom,@dateNaissance,@email)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", p.Nom);
                    command.Parameters.AddWithValue("@prenom", p.Prenom);
                    command.Parameters.AddWithValue("@dateNaissance", p.DateNaissance);
                    command.Parameters.AddWithValue("@email", p.Email);
                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été inséré : " + nbInsertion);
                }
            }
        }

        public void EditerUnEtudiant(Etudiant e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Etudiant SET nom=@nom, prenom=@prenom, dateNaissance=@dateNaissance, email=@email WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", e.Id);
                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@dateNaissance", e.DateNaissance);
                    command.Parameters.AddWithValue("@email", e.Email);
                    int nbModification = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été modifié : " + nbModification);
                }
            }
        }

        public void SupprimerUnEtudiant(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Etudiant WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été supprimé : " + nbSuppression);
                }
            }
        }

        public void SupprimerLeTableau()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"TRUNCATE TABLE Etudiant;";
                Console.WriteLine("Tableau supprimé");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Tableau(x) ayant été supprimé : " + nbSuppression);
                }
            }
        }

        public Etudiant AfficherUnePersonneParSonNom(string nom)
        {
            Etudiant etudiant;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant WHERE nom=@nom;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    etudiant = new Etudiant(
                        reader.GetInt32("id"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetDateTime("dateNaissance"),
                        reader.GetString("email")
                        );
                }
            }
            return etudiant;
        }

        public Etudiant AfficherUnePersonneParSonPrenom(string prenom)
        {
            Etudiant etudiant;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant WHERE prenom=@prenom;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@prenom", prenom);
                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    etudiant = new Etudiant(
                        reader.GetInt32("id"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetDateTime("dateNaissance"),
                        reader.GetString("email")
                        );
                }
            }
            return etudiant;
        }
    }
}