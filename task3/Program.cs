/*
На вход число N, на выходе произведение от 1 до N
*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ProductFromOne(int endNumber)
{
    int product = 1;
    if (endNumber > 0)
    {
        for (int i = 1; i <= endNumber; i++)
        {
            product = product *i;
        }
        return product;
    }
    else 
    {
        Console.WriteLine("Число слишком маленькое");
        return 0;
    }
    
};

int N = ReadInt("Введите число:");
Console.WriteLine(ProductFromOne(N));