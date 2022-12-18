Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y1 = (k1*x +b1);
// double y2 = (k2*x +b2);
Console.WriteLine(x);
Console.WriteLine(y1);