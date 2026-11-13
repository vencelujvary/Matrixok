namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] matrix = new int[sorokSzama, oszlopokSzama];
        static Random r = new Random();
        static void F01() 
        {
            for(int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    matrix[i,j] = r.Next(10,100);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
