using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobu.Practice3
{
    public class PrivateHuman
    {
        //コンストラクタ
        public PrivateHuman(DateOnly birthDate, string fullname, int height, int weight)
        {
            BirthDate = birthDate;
            Fullname = fullname;
            Height = height;
            Weight = weight;
        }

        //プロパティ
        public DateOnly BirthDate { get; }
        public string Fullname { get; }
        public int Height { get; }
        public int Weight { get; }
        //public Human? LoveHuman { private get; set; }

        //フィールド
        private Human? _loveHuman;

        public void SetLoveHuman(Human loveHuman)
        {
            _loveHuman = loveHuman;
        }

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
