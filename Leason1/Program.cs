// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int number = Prompt("Введите пятизначное число: ");

int numberA = number / 10000;
int numberB = number % 10;
int numberC = number / 1000 % 10;
int numberD = number / 10 % 10;

if (ValidNumbers(number))
{
    FindPalindrom(number);
}

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool ValidNumbers(int x)
{
    if (x < 10000 || x > 99999)
    {
        Console.WriteLine("Введено не пятизначное число");
        return false;
    }
    return true;
}

void FindPalindrom(int x)
{
    if (numberA == numberB && numberC == numberD)
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}