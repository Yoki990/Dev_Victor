SELECT ville_nom_reel, ville_population_2012
FROM villes_france_free
ORDER BY ville_population_2012 DESC
LIMIT 10;

SELECT ville_nom_reel, ville_surface
FROM villes_france_free
ORDER BY ville_surface
LIMIT 50;

SELECT ville_nom_reel, ville_population_2012, ville_departement
FROM villes_france_free
ORDER BY ville_population_2012 DESC
LIMIT 10;

SELECT ville_departement, ville_code_postal, COUNT(ville_departement)
FROM villes_france_free
ORDER BY ville_departement DESC;

