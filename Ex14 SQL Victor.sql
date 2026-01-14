SELECT COUNT(location), location
FROM Users
GROUP BY location
HAVING COUNT(location) > 1;

SELECT job, ROUND(AVG(salary)) AS salaire_moyen
FROM Users
GROUP BY job
HAVING AVG(salary) > 2500;

SELECT location, SUM(salary) AS salaire_total
FROM Users
GROUP BY location
HAVING SUM(salary) > 5000;

SELECT birth_date, COUNT(birth_date)
FROM Users
GROUP BY birth_date
HAVING COUNT(birth_date) > 1;

SELECT job, location, SUM(salary) AS salaire_maximum
FROM Users
GROUP BY job
HAVING SUM(salary) > 3000;