//string[,] table = new string[2, 5];

//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}
int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1;10)
        }

    }

}

int[,] matr = new int[3, 4];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
PrintArray(matr);


double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i =1; i<40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");

}