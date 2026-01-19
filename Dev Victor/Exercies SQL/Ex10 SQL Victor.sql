SELECT *
FROM Users
WHERE job IN ('Engineer');

SELECT first_name, last_name
FROM Users
WHERE location IN ('London','Paris','Berlin');

SELECT *
FROM Users
WHERE age BETWEEN 25 AND 35;

SELECT *
FROM Users
WHERE job IN ('Developer') AND salary > 2500;

SELECT *
FROM Users
WHERE job NOT IN ('Lawyer','Designer');

SELECT *
FROM Users
WHERE age NOT BETWEEN 30 AND 40 AND location IN ('Tokyo', 'Los Angeles'); 