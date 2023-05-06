// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int i = 1;
int number = Prompt("Введите число: ");
int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

FindCoobTable(number);

void FindCoobTable(int x)
{
    while(i <= x)
    {
        Console.WriteLine("Таблица кубов заданного числа: " + i * i * i);
        i++;
    }
}

