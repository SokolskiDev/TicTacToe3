int[,] tablica = new int[3, 3];
bool end = false;
while (!end)
{
    Random rzad = new();
    Random kolumna = new();
    bool pc = false;
    bool player = false;
    do
    {
        int x = rzad.Next(0, 3);
        int y = kolumna.Next(0, 3);
        if (tablica[x, y] == 0)
        {
            tablica[x, y] = 1;
            pc = false;
        }
        else
        {
            pc = true;
        }
    }
    while (pc);//pc

    //wypisywanie tablicy
    for (int i = 0; i < 3; i++)
    {
        Console.Write(" ");
        for (int j = 0; j < 3; j++)
        {
            if (tablica[i, j] == 0)
            {
                Console.Write(" ");
            }
            if (tablica[i, j] == 1)
            {
                Console.Write("X");
            }
            if (tablica[i, j] == 2)
            {
                Console.Write("O");
            }
            if (j < 2)
            {
                Console.Write(" | ");
            }
        }
        if (i < 2)
        {
            Console.WriteLine("\n-----------");
        }
    }
    do
    {
        Console.WriteLine("\nPodaj x");
        if (int.TryParse(Console.ReadLine(), out int x) && x>=0 && x<=2)
        {
            Console.WriteLine("Podaj y");
            if (int.TryParse(Console.ReadLine(), out int y) && y >= 0 && y <= 2)
            {
                if (tablica[x, y] == 0)
                {
                    tablica[x, y] = 2;
                    player = false;
                }
                else
                {
                    player = true;
                }
            }
        }
        
    }
    while (player);//user
    Console.WriteLine("Sprawdzam");
   

    if ((tablica[0,0] == tablica[0,1] && tablica[0,1] == tablica[0,2] && tablica[0,2] == 2) ||
        (tablica[1,0] == tablica[1,1] && tablica[1,1] == tablica[1,2] && tablica[1,2] == 2) ||
        (tablica[2,0] == tablica[2,1] && tablica[2,1] == tablica[2,2] && tablica[2,2] == 2) ||
        (tablica[0,0] == tablica[1,0] && tablica[1,0] == tablica[2,0] && tablica[2,0] == 2) ||
        (tablica[0,1] == tablica[1,1] && tablica[1,1] == tablica[2,1] && tablica[2,1] == 2) ||
        (tablica[0,2] == tablica[1,2] && tablica[1,2] == tablica[2,2] && tablica[2,2] == 2) ||
        (tablica[0,0] == tablica[1,1] && tablica[1,1] == tablica[2,2] && tablica[2,2] == 2) ||
        (tablica[0,2] == tablica[1,1] && tablica[1,1] == tablica[2,0] && tablica[2,0] == 2))
    {
        Console.WriteLine("Gracz wygrywa!");
        end = true;
    }
    if ((tablica[0, 0] == tablica[0, 1] && tablica[0, 1] == tablica[0, 2] && tablica[0, 2] == 1) ||
        (tablica[1, 0] == tablica[1, 1] && tablica[1, 1] == tablica[1, 2] && tablica[1, 2] == 1) ||
        (tablica[2, 0] == tablica[2, 1] && tablica[2, 1] == tablica[2, 2] && tablica[2, 2] == 1) ||
        (tablica[0, 0] == tablica[1, 0] && tablica[1, 0] == tablica[2, 0] && tablica[2, 0] == 1) ||
        (tablica[0, 1] == tablica[1, 1] && tablica[1, 1] == tablica[2, 1] && tablica[2, 1] == 1) ||
        (tablica[0, 2] == tablica[1, 2] && tablica[1, 2] == tablica[2, 2] && tablica[2, 2] == 1) ||
        (tablica[0, 0] == tablica[1, 1] && tablica[1, 1] == tablica[2, 2] && tablica[2, 2] == 1) ||
        (tablica[0, 2] == tablica[1, 1] && tablica[1, 1] == tablica[2, 0] && tablica[2, 0] == 1))
    {
        Console.WriteLine("PC wygrywa!");
        end = true;
    }

}
