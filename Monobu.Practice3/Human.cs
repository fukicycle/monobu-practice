using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobu.Practice3
{
    public class Human
    {
        public Human(DateOnly birthDate, string fullname, int height, int weight)
        {
            BirthDate = birthDate;
            Fullname = fullname;
            Height = height;
            Weight = weight;
        }
        public DateOnly BirthDate { get; }
        public string Fullname { get; }
        public int Height { get; }
        public int Weight { get; }
        public Human? LoveHuman { get; set; }

        public void Walk()
        {
            Console.WriteLine("Walk");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }
}
