using System;

namespace CleanCode
{
    // Kelas ini bertanggung jawab hanya untuk mengelola pengguna
    public class User
    {
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public User(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public int CalculateAgeInYears()
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age)) age--;

            return age;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {CalculateAgeInYears()} years");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Devrin Cantik", new DateTime(2004, 05, 02));
            user.DisplayUserInfo();
        }
    }
}