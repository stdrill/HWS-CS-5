// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

(double, double) Tochka(double k1, double b1, double k2, double b2){
    double x = (b2 - b1) / (k1 - k2);
    //Console.WriteLine($"({b2} - {b1}) / ({k1} - {k2}) = {x}");
    double y = k1 * x + b1;
    //Console.WriteLine($"{k1} * {x} + {b1} = {y}");

    return (x , y);
}

double GetParam(string param){
    Console.Write($"Введите {param}: "); 
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = GetParam("k1");
double b1 = GetParam("b1");
double k2 = GetParam("k2");
double b2 = GetParam("b2");

(double x, double y)  = Tochka(k1,b1,k2,b2);
Console.WriteLine($"Точка пересечения x={x} и y={y}");