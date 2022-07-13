Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine("Координаты точки пересечения: x = {0}; y = {1})", x, y);
}
else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
else Console.WriteLine("Прямые параллельны. Точек пересечения нет.");

// y = k1*x + b1;
// y = k2*x + b2;

// y - y = k1*x - k2*x + b1 - b2;
// y = k2*x + b2;

// 0 = x*(k1 - k2) + b1 - b2;
// y = k2*x + b2;

// x*(k1 - k2) = b2 - b1;
// y = k2*x + b2;

// x = (b2 - b1)/(k1 - k2);
// y = k2*(b2 - b1)/(k1 - k2) + b2;
