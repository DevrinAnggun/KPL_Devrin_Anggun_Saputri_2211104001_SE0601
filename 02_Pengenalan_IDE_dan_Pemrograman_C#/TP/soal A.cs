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
    }
}