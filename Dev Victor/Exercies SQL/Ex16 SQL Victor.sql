SELECT clients.*, achats.*
FROM clients
INNER JOIN achats
ON clients.id = achats.client_id;

SELECT clients.*, achats.*
FROM clients
LEFT JOIN achats
ON clients.id = achats.client_id;

SELECT clients.*, achats.*
FROM clients
RIGHT JOIN achats
ON clients.id = achats.client_id;

SELECT clients.*, achats.*
FROM clients
LEFT JOIN achats
ON clients.id = achats.client_id
UNION
SELECT clients.*, achats.*
FROM clients
RIGHT JOIN achats
ON clients.id = achats.client_id;