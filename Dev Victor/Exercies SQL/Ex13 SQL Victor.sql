SELECT MIN(salary) as salaire_minimal
FROM Users;

SELECT MAX(age) AS max_age
FROM Users
WHERE job IN ('Engineer');

SELECT AVG(salary) AS salaire_moyen
FROM Users
WHERE job IN ('Teacher');

SELECT SUM(salary) AS salaire_total
FROM Users;