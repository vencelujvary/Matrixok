namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] matrix = new int[sorokSzama, oszlopokSzama];
        static Random r = new Random();
        static int[,] negyzetesMatrix = new int[5, 5];
        static void F01(int[,]matrix) 
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = r.Next(-100,101);
                }
            }
        }
        static void F02(int[,]matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

         static void F03()
        {
            int ossz = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += matrix[i, j];
                }
            }
            Console.WriteLine("A mátrixban lévő elemek összege: " + ossz);
            
        }
        static void F04()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sorOsszeg = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sorOsszeg += matrix[i, j];
                }
                Console.WriteLine($"{i+1}. sor összege: {sorOsszeg}");

            }
        }

        static void F05()
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int oszlopOsszeg = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    oszlopOsszeg += matrix[i, j];
                }
                Console.WriteLine($"{j + 1}. oszlop összege: {oszlopOsszeg}");
            }
        }
        static void F06()
        {
            int ossz = 0;
            for(int i = 0; i < negyzetesMatrix.GetLength(0); i++)
            {
                ossz += negyzetesMatrix[i, i];
            }
            Console.WriteLine("A bal átló összege: " + ossz);
            int index = negyzetesMatrix.GetLength(0)-1;
            ossz = 0;
            for (int i = 0; i < negyzetesMatrix.GetLength(0); i++)
            {
                ossz += negyzetesMatrix[i, index--];
                
            }
            Console.WriteLine("A jobb átló összege: " + ossz);
        }
        
        static void F07(int[,] matrix)
        {
            int db = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        db++;
                    }
                }
            }
            Console.WriteLine("A mátrixban a negatív számok száma: " + db);
        }
        static void Main(string[] args)
        {
            
           F01(matrix);
           F02(matrix);
           //F03();
           //F04();
           //F05();
           F01(negyzetesMatrix);
           F02(negyzetesMatrix);
            int[,] masolat = negyzetesMatrix;
            F02(masolat);
            masolat[0,0] = 50;
            Console.WriteLine("__________________________");
            Console.WriteLine("Eredeti: ");
            F02(negyzetesMatrix);
            negyzetesMatrix[0, 0] = 99;
            Console.WriteLine("--------------------------");    
            Console.WriteLine("Másolat: ");
            F02(masolat);
            F06();
            F07(matrix);

        }
    }
}
