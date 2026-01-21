int A = 10;
int B = 20;
int C;

C = A + B;
A = C - A;
B = C - A;

Console.WriteLine($"La valeur de A est {A} et la valeur de B est {B}");