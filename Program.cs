/*Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается
 при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная. 
5 12 16 q [STOP] 
3 45 342 15 [STOP]*/
/*
int NumberSum(int n)
{
    int sum=0;
    while (n>0)
    {
        sum=sum + n%10;
        n=n/10;
    }
    return sum;
}
void GetNumber()
{
int i=0;
while (i<1)
{
int n;
Console.Write("Введите целое число:");
string s = Console.ReadLine();
if (s!="q")
{
    n=int.Parse(s);
    int sum=NumberSum(n);
    if (sum%2==0)
   {
    Console.WriteLine("[STOP]");
    i++;
   }
}
else
{
    Console.WriteLine("[STOP]");
    i++;
}
}
}
GetNumber();
*/

/*Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве. 
[344 452 341 125] => 2*/

/*
Console.Write("Введите размер массива: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];

void PrintArray()
{
    Console.Write("массив [");
    for (int i=0; i<array.Length; i++)
    {
         array[i] = new Random().Next(100,1000);  
        Console.Write(array[i] +" ");

    }
    Console.Write("]");
}

int GetNumbers()
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0) 
        {
            count++;
        }
    }
    return count;
} 

PrintArray();
Console.WriteLine(" => " + GetNumbers());
*/


/* Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
второй – предпоследним и т.д.)
[1 3 5 6 7 8] => [8 7 6 5 3 1]*/

Console.Write("Введите размер массива: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];

int[] CreateArray (int N)
{
    for (int i=0; i<array.Length; i++)
    {
         array[i] = new Random().Next(1,100);
    }
    return array;
}
void ArrayRevers(int [] array)
{
    for (int i=0; i<array.Length/2; i++)
    {
        int temp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=temp;
    }
}

void PrintArray (int[]array)
{
     Console.Write("массив [");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
}

array=CreateArray(N);
PrintArray(array);
Console.Write(" => ");
ArrayRevers(array);
PrintArray(array);