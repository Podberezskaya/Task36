//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void Input_array (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array [i] = new Random().Next(100,1000);
}
int release(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
        sum = sum + array [i];
    return sum;
}
Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array =new int [n];
Input_array(array);
Console.WriteLine($"[{string.Join(" , " , array)}]");
Console.WriteLine(release(array));
