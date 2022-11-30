// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[4];
int sum = 0;
int [] GetArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    if (i% 2 == 0)
{
    sum += array[i];
}}
return array;}
GetArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна" +sum);
