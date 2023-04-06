//  Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Write your number");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);

if (number % 2 == 0)
{
    System.Console.WriteLine("paired");
}
else
{
    System.Console.WriteLine("unpaired");
}