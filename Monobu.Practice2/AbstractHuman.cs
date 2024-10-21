using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobu.Practice2
{
    public abstract class AbstractHuman
    {
        public AbstractHuman(DateOnly birthDate, string fullname, int height, int weight)
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

        public abstract void Walk();

        public abstract void Sleep();

        public abstract void Eat();
    }
}
