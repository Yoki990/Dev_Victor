  CREATE TABLE IF NOT EXISTS Livres (
	id_livre AUTO_INCREMENT PRIMARY KEY,
    titre VARCHAR(255),
    auteur VARCHAR(255),
    annee_publication DATE,
    genre VARCHAR(255),
    exemplaires_disponibles INT
)