namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = " Aplikasi Calculator";

            int a;
            int b;
            int c;

            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine(" 1. penambahan\n 2. pengurangan\n 3. perkalian\n 4. pembagian");

            Console.Write(" input nomor menu [1..4]: ");
            c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if (c == 2)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            }

            else if (c == 3)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil perkalian " + a + " * " + b + " = " + Perkalian(a, b));
            }

            else if (c == 4)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil pembagian " + a + " / " + b + " = " + Pembagian(a, b));
            }

            else
            {
                Console.WriteLine("tidak tersedia");
            }
            Console.WriteLine("\nTekan sembarangan key untuk keluar");
            Console.ReadKey();
        }




        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
