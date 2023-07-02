/*
Принимаем на вход число А, выдаем сумму чмисел от 1 до А
*/


int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFromOne(int endNumber) 
{
    int sum = 0;
    if (endNumber > 0)
    {
        for (int i = 1; i <= endNumber; i++) 
        {
            sum = sum + i;
        }
    }
    else System.Console.WriteLine("Число слишком маленькое");
    return sum;
};

int A = ReadInt("Введите число, до которого будем считать  сумму");
int result = SumFromOne(A);
System.Console.WriteLine(result);
