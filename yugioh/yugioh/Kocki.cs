using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yugioh
{
    
    class Kocki
    {
        public enum kockavalue
        {
            Summon2,
            Summon3,
            Summon4,
            Move,
            Move2,
            Attack,
            Attack2,
            Deffend,
            Deffend2,
            Magic,
            Magic2,
        }
        static string generateValue(kockavalue kockaValue) {
            int Seed = (int)DateTime.Now.Ticks;
            Random random = new Random(Seed);
            int broj1 = random.Next(1, 11);
            if(broj1 == 1)
            {
                kockaValue = kockavalue.Summon2;
            }
            if (broj1 == 2)
            {
                kockaValue = kockavalue.Summon3;
            }
            if (broj1 == 3)
            {
                kockaValue = kockavalue.Summon4;
            }
            if (broj1 == 4)
            {
                kockaValue = kockavalue.Move;
            }
            if (broj1 == 5)
            {
                kockaValue = kockavalue.Move2;
            }
            if (broj1 == 6)
            {
                kockaValue = kockavalue.Attack;
            }
            if (broj1 == 7)
            {
                kockaValue = kockavalue.Attack2;
            }
            if (broj1 == 8)
            {
                kockaValue = kockavalue.Deffend;
            }
            if (broj1 == 9)
            {
                kockaValue = kockavalue.Deffend2;
            }
            if (broj1 == 10)
            {
                kockaValue = kockavalue.Magic;
            }
            if (broj1 == 11)
            {
                kockaValue = kockavalue.Magic2;
            }
            return kockaValue.ToString();
        }
    }
}
