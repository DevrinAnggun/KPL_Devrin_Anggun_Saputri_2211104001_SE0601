using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan satu huruf: ");
        char huruf = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (char.IsLetter(huruf) && char.IsUpper(huruf))
        {
            if ("AIUEO".Contains(huruf))
            {
                Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
            }
            else
            {
                Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
            }
        }
        else
        {
            Console.WriteLine("Input harus berupa satu huruf kapital!");
        }

        // Menambahkan array berisi 5 bilangan genap
        int[] angkaGenap = { 2, 4, 6, 8, 10 };

        // Iterasi untuk mencetak setiap elemen dalam array
        for (int i = 0; i < angkaGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {angkaGenap[i]}");
        }
    }
}
