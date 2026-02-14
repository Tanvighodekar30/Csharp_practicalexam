using System;

class printpattern5
{
    public static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if ((i == 1 && j == 3) ||
                    (i == 2 && (j == 2 || j == 4)) ||
                    (i == 3 && (j == 1 || j == 3 || j == 5)) ||
                    (i == 4 && (j == 2 || j == 4)) ||
                    (i == 5 && j == 3))
                {
                    if (i % 2 == 1)
                        Console.Write("@ ");
                    else
                        Console.Write("O ");
                }
            }
        }
    }
}