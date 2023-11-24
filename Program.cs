namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1
            // a) Erzeugen Sie ein Array mit sieben
            // Einträgen aus Zahlen zwischen 1-99.
            // b) Geben Sie die Summe aller Einträge und
            // die größte und kleinste Zahl aus.
            // c) Geben Sie das Array in umgekehrter Reihen-
            // folge aus.

            // Aufgabe 2
            // a) Erzeugen Sie ein 2d-Array mit vier Zeilen
            // und vier Spalten. Die Einträge wie in Aufgabe 1.
            // b) Geben Sie das Array lesbar in der Konsole aus.
            // c) Geben Sie nur die Diagonale des Array aus.
            // Hinweis: int[,] Tabelle = new int[4,4];

            //Aufgabe 2:
            Console.WriteLine("2d Array:");

            int[,] Array2D = new int[4, 4];
            Random rnd = new Random();
            //Array erstellen:
            for (int i = 0; i < Array2D.GetLength(1); i++) 
            {
                for (int j = 0; j < Array2D.GetLength(0); j++)
                {
                    Array2D[i, j] = rnd.Next(2, 99);
                }
            }

            //Array ausgeben:
            for (int x = 0; x < Array2D.GetLength(1); x++)
            {
                for (int y = 0; y < Array2D.GetLength(0); y++)
                {
                    Console.Write(Array2D[y, x] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonale");
            for (int x = 0; x < Array2D.GetLength(1); x++)
            {
                for (int y = 0; y < Array2D.GetLength(0); y++)
                {
                    if(x==y)
                    {
                        Console.Write(Array2D[x, y]);
                    }
                    Console.Write("\t");
                }
                Console.Write("\n");
            }

        }
    }
}