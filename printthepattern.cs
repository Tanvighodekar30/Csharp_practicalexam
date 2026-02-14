
////print following pattern
////1
////2 1
////3 2 1
////4 3 2 1
////5 4 3 2 1
class printthepattern
{
    public static void Main(String[] args)
    {
        //int n = 5; // Number of rows
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = i; j >= 1; j--)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}



        //*
        //* *
        //* * *
        //* *
        //*
        //int n = 3; // Number of rows
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}



        //A A A A
        //B B B B
        //C C C C
        //D D D D

        int n = 4; // Number of rows
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                char ch = (char)('A' + i); // Convert to character
                Console.Write(ch + " ");
            }
            Console.WriteLine();


        }

    }
}
