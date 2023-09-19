int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long FactorialRec(int n)
{
    if(n == 1) return 1;
    return n * FactorialRec(n-1);
}

long FibbonaciRec(int n)
{
    if(n == 0) return 0;
    if(n == 1) return 1;
    return FibbonaciRec(n-1)+FibbonaciRec(n-2);
}

int n = ReadData("Input N");
Console.WriteLine($"Факториал числа {n} равен {FactorialRec(n)}.");
Console.WriteLine($"Число Фиббоначи от {n} равно {FibbonaciRec(n)}.");


