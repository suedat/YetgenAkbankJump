using System;
using YetGenAkbankJump.OOPConsole.Common;
namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Teacher : PersonBase
    {
        public DateTimeOffset RegistrationDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public void SayMyName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
    //explicit bire bir değer kaybı olmadan aktarır
    //implicit değer kaybı olacağı anlamına gerli
}

