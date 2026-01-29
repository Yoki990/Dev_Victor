using Ex10.Classes;

Rectangle rectangle = new Rectangle("rectangle",2, 5);
rectangle.CalculerPerimetre();
rectangle.CalculerAire();

Cercle cercle = new Cercle("cercle", 5);
cercle.CalculerPerimetre();
cercle.CalculerAire();

Console.WriteLine("-------------------------");

cercle.infos();
Console.WriteLine();
rectangle.infos();