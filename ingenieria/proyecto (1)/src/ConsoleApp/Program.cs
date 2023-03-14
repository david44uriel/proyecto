double altura = 5;
double A = 10;
double B= 20;
double base1= 10;
double centro= 30;
double perimetro = Application.Paralelogramo.Perimetro(A,B);
double area = Application.Paralelogramo.Area(base1, centro);
double volumen = Application.Paralelolipedo.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Paralelolipedo de {altura}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Paralelolipedo de {altura}cm por lado es {area}cm2");
Console.WriteLine($"El volumen un Prisma Paralelolipedocon un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");