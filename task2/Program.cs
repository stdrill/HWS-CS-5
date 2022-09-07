// Написать программу масштабирования фигуры 

Console.WriteLine("Задайте координаты фигуры в формате: (0,0) (1,0)...");
string coord = Console.ReadLine();
string[] figure = coord.Split(" ");
string result = "";
Console.WriteLine("Введите коэффициент масштабирования");
int k = Convert.ToInt32(Console.ReadLine()); 
for(int i = 0; i < figure.Length; i++)
{
    // Console.WriteLine(figure[i]);
    string[] num = figure[i].Split(",");
    result = result + "(";
    for(int j = 0; j < num.Length; j++)
    {
        int newCoordinate = Convert.ToInt32(num[j].Replace("(","").Replace(")","")) * k;
        if(j == 0) result = result + $"{newCoordinate},";
        else result = result + $"{newCoordinate}";
    }
    result = result + ") ";
}
Console.WriteLine(result);
