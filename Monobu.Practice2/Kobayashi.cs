using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobu.Practice2
{
    public class Kobayashi : AbstractHuman
    {
        public Kobayashi() : base(DateOnly.Parse("2003-11-21"), "Shoma Kobayashi", 170, 60)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Mogu mogu eat.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Nyam nyam sleep.");
        }

        public override void Walk()
        {
            Console.WriteLine("Teku teku walk.");
        }
    }
}
