using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobu.Practice2
{
    public class Human
    {
        public DateOnly BirthDate { get; set; }
        public string Fullname { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

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
