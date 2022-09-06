// Написать программу копирования массива

void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,100);
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+" ");
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int[] copy = new int[arr.Length];
arr.CopyTo(copy, 0);
Console.WriteLine("Копия массива: ");
Console.WriteLine(String.Join(" ", copy));