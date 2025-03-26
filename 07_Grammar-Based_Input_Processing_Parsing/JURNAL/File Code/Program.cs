using System;

namespace jurnal_modul7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Data Mahasiswa===\n");

            // Memanggil method ReadJSON() dari class DataMahasiswa2211104001
            DataMahasiswa2211104001.ReadJSON();

            Console.WriteLine("=== Data Anggota Tim  ===\n");

            // Memanggil method ReadJSON() dari class TeamMahasiswa2211104001
            TeamMembers2211104001.ReadJSON();

            Console.WriteLine("=== Glosarry Item ===\n");
            // Memanggil method ReadJSON() dari class TeamMahasiswa2211104001
            GlossaryItem2211104001.ReadJSON();
        }
    }
}