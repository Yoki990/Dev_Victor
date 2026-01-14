SELECT first_name, location, age
FROM Users
WHERE location = (SELECT location FROM Users ORDER BY age DESC LIMIT 1);

SELECT first_name, salary
FROM Users
WHERE salary < (SELECT AVG(salary) FROM Users WHERE job IN ('Developer'));

SELECT *
FROM Users
WHERE salary > (SELECT AVG(salary) FROM Users) AND location = (SELECT location FROM Users WHERE (first_name = 'John') AND (last_name = 'Doe'));