using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string NIM { get; set; }
}

public class Team
{
    public List<Member> Members { get; set; }
}

public class TeamMembers2211104001
{
    public static void ReadJSON()
    {
        string path = @"C:\Users\LENOVO\source\repos\jurnal_modul7\jurnal_modul7\jurnal7_2_2211104001.json";

        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            Team team = JsonConvert.DeserializeObject<Team>(jsonData);

            Console.WriteLine("=== Daftar Anggota Tim ===");
            foreach (var member in team.Members)
            {
                Console.WriteLine($"NIM: {member.NIM}");
                Console.WriteLine($"Nama: {member.FirstName} {member.LastName}");
                Console.WriteLine($"Gender: {member.Gender}");
                Console.WriteLine($"Umur: {member.Age} tahun");
                Console.WriteLine("--------------------------");
            }
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan!");
        }
    }
}
