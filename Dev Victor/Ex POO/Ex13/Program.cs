using Ex13.Classes;

Carre carre = new Carre(new Point(5,8),5);
Rectangle rectangle = new Rectangle(new Point(5, 8), 5,6);
Triangle triangle = new Triangle(new Point(5, 8), 5, 3);


carre.Deplacement(5,-4);
Console.WriteLine(carre.Origine);

rectangle.Deplacement(5,-4);
Console.WriteLine(rectangle.Origine);

triangle.Deplacement(-2.5,-5);
Console.WriteLine(triangle.Origine);