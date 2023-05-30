using System;
class HelloWorld {
static void Main()
{

int[] array = {0, 3, 0, 2, 4, 5, 7, 9, 0, 0 };
int nul = 0;
for (int i = 0; i < 10; i++)
{
    if ((i+1) % 2 == 1 && array[i] == 0)
    {
        nul = nul+1;
    }
}


Console.WriteLine("Нулевых элементов на нечётных позициях - " + nul);
}
}