CREATE TABLE IF NOT EXISTS Services(
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(255) NOT NULL,
    date_creation DATETIME DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS Employes(
	employe_id INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    prenom VARCHAR(255),
    service_id INT,
    CONSTRAINT fk_service_id FOREIGN KEY (service_id) REFERENCES Services(service_id)
);

INSERT INTO Services (libelle)
VALUES ('Informatique');

INSERT INTO Services (libelle,date_creation)
VALUES ('Ressources Humaines','2024-01-01');

INSERT INTO Services (libelle)
VALUES ('Marketing');

UPDATE Services
SET libelle = 'IT'
WHERE libelle = 'Informatique';

UPDATE Services
SET date_creation = NOW()
WHERE libelle = 'Ressources Humaines';

DELETE FROM Services
WHERE libelle = 'Marketing';

DELETE FROM Services
WHERE date_creation < '2024-01-01';

INSERT INTO Employes (nom, prenom, service_id)
VALUES ('Martin', 'Paul',6),('Dupont','Claire',6),('Bernard','Sophie',7);

UPDATE Employes
SET nom = 'Martinez'
WHERE nom = 'Martin';

DELETE FROM Employes
WHERE prenom = 'Claire';