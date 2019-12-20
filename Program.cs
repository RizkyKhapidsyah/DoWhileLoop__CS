using System;

namespace DoWhileLoop__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, A, B, C;
            string D;

            X = 1;

            Console.Write("Masukkan Jumlah Perulangan : "); A = Convert.ToInt32(D = Console.ReadLine());
            Console.Write("Masukkan Kelipatan         : "); B = Convert.ToInt32(D = Console.ReadLine());

            Console.WriteLine();

            do
            {
                Console.WriteLine(X);
                X += B;
            } while (X <= A);

            C = A / B;

            Console.WriteLine();
            Console.Write("Jumlah Angka Diulang Sebanyak : {0}x", C);
            Console.ReadLine();
        }
    }
}
