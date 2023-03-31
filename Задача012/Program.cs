//Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число ");
int nummer = int.Parse(Console.ReadLine());
int length = nummer;
if (length >= 100)
{
    while (nummer>999)
    {
      nummer = nummer/10;
    }
      int result = nummer % 10;  

    Console.WriteLine($"Третье число - {result}");
}
else
{
    Console.WriteLine($"Нет третьего числа");
}