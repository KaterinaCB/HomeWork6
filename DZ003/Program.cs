//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонний.

void CheckTriangle()
{
    Console.Write("Введите длинну стороны а: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длинну стороны b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длинну стороны c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    if (a < b + c 
        && b < a + c 
        && c < a + b)
    {
        Console.WriteLine("Введенные данные являются сторонами треугольника");
        double p = (a + b + c)/2;
        double S = Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
        Console.WriteLine($"Площадь треугольника равна: {S}");
        double alfa = (Math.Round((Math.Asin((2*S/(a*b))))*180/Math.PI))-1; // без (- 1) выдает погрешность в большую сторону на 1 градус
        double beta = (Math.Round((Math.Asin((2*S/(c*b))))*180/Math.PI))-1;
        double gamma = 180 - alfa - beta;
        Console.WriteLine($"Углы треугольника равны: {alfa} градусов, {beta} градусов, {gamma} градусов");
        if (alfa == 90 || beta == 90 || gamma == 90) Console.WriteLine("Треугольник прямоугольный");
        else if (a==b && b==c && c==a) Console.WriteLine("Треугольник равносторонний");
        else if (a==b || b==c || c==a) Console.WriteLine("Треугольник равнобедренный");
    }
    else Console.WriteLine("Введенные данные не являются сторонами треугольника");
}
CheckTriangle();

