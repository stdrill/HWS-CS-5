// Написать программу масштабирования фигуры 

Console.WriteLine("Задайте координаты фигуры ");
string coord = Console.ReadLine();
string[] figure = coord.Split(" ");
string result = "";
Console.WriteLine("Введите коэффициент масштабирования");
int k = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < figure.Length; i++)
{
    string[] num = figure[i].Split(",");
    for(int j = 0; j < figure.Length; j++)
    {
        num[j] = Convert.ToInt32(num[j].Replace("(","").Replace(")",""));
    }
}
