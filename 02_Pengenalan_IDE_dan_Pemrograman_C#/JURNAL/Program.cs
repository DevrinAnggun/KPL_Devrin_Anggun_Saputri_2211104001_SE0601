using System;

class Program
{
    static void Main()
    {
        // Menerima input nama praktikan
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!\n");

        // Membuat array dengan 50 elemen berisi nilai sesuai indeksnya
        int[] angkaArray = new int[50];
        for (int i = 0; i < angkaArray.Length; i++)
        {
            angkaArray[i] = i;
        }

        // Menampilkan elemen array sesuai aturan kelipatan
        for (int i = 0; i < angkaArray.Length; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{i} ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} $$");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine(); // Memberikan spasi sebelum input berikutnya

        // Menerima input angka dari user
        Console.Write("Masukkan angka (1 - 10000): ");
        string nilaiString = Console.ReadLine();
        int nilaiInt = Convert.ToInt32(nilaiString);

        // Mengecek apakah angka merupakan bilangan prima
        if (IsPrima(nilaiInt))
        {
            Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima.");
        }
        else
        {
            Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima.");
        }
    }

    // Fungsi untuk mengecek bilangan prima
    static bool IsPrima(int angka)
    {
        if (angka < 2) return false;
        for (int i = 2; i * i <= angka; i++)
        {
            if (angka % i == 0)
                return false;
        }
        return true;
    }
}
