/*Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается
 при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная. 
5 12 16 q [STOP] 
3 45 342 15 [STOP]*/

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