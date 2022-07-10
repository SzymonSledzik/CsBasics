//Console.WriteLine("Hello, World!");
// 1 1 2 3 5 8 13 21 34

void GoldenRatio()
{
    int a = 0; int b = 1; int c;
    Console.WriteLine(b);
    for (int i =0; i< 10; i++)
    {
        c = a + b;
        a = b;
        b = c;
        Console.WriteLine(c);
    }


}
//GoldenRatio();
void CountSquare(int x)
{
    int wall = x;
    double count = 0, temp;
    for (int i = 0; i <wall; i++)
    {
        temp = Math.Pow(wall - i, 2);
        count = count + temp;
    }
    Console.WriteLine(count);
}

double CountRactangles()
{
    //int wall = 3;
    double count = 0;
    double temp = 0;
    for (int i = 1; i < 3; i++)
    {
        for(int j = 1; i <= 3; j++)
        {
            temp = j * i;
            count = temp + count;
        }
    }
    return count;
}
//Console.Write("Podaj dlugosc scianki: ");
//int x = int.Parse(Console.ReadLine());

//CountSquare(x);
Console.WriteLine(CountRactangles());


Console.ReadLine();