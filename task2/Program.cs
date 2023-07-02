/*
Число на вход, число цифр на выходе
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountDigits(int number)
{
    number = Math.Abs(number);
    int count = 0;
    int i = 10;
    if(number == 0) return 1;
    while (number > 0)
    {
        number = number - number%i;
        count = count + 1;
        i=i*10;
    }
    return count;
}

int N = ReadInt("Введите число:");
System.Console.WriteLine(CountDigits(N));

