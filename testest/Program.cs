using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] support = { "Furia", "Seris", "Grover", "Ying", "Jenos", "Mal'Damba", "Io", "Grohk", "Pip", "Corvus" };
            string[] flanker = { "Androxus", "Buck", "Evie", "Koga", "Lex", "Maeve", "Moji", "Skye", "Talus", "Zhin" };
            string[] tank = { "Ash", "Atlas", "Barik", "Fernando", "Inara", "Khan", "Makoa", "Raum", "Ruckus", "Terminus", "Torvald (I´m so sorry)" };
            string[] damage = { "Bomb king", "Cassie", "Dredge", "Drogoz", "Imani", "Kinessa", "Lian", "Shalin", "Strix", "Tiberius", "Tyra", "Viktor", "Vivian", "Willo" };
            string[] all = support.Concat(flanker.Concat(tank.Concat(damage))).ToArray();
            Random rnd = new Random();
            Console.WriteLine("Choose your class: Support (s), Flank(f), Tank(t), Damage(d) or all of them (all)");
            string Class = Console.ReadLine();
            if (Class.Contains("+"))
            {
                string[] Brambora = new string[(Math.Max(Math.Max(support.Length, flanker.Length), Math.Max (tank.Length, damage.Length)))*11];
                Brambora = ClassOne(Class, support, flanker, tank, damage, 0);
                int Loong = Class.Length;
                int Petr = 0;
                while (Petr != Loong-1)
                {
                    Brambora= Brambora.Concat(ClassOne(Class, support, flanker, tank, damage, Petr)).ToArray();
                    Petr += 2;
                }
                int cislo69 = rnd.Next(Brambora.Length);
                Console.WriteLine(Brambora[cislo69]);               

            }
            else
            {
                if (Class.ToLower().Contains("all"))
                {

                    int cislo = rnd.Next(all.Length);
                    Console.WriteLine(all[cislo]);
                }
                if (Class.ToLower().Contains("s"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(support.Length);
                    Console.WriteLine(support[cislo]);
                }
                if (Class.ToLower().Contains("f"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(flanker.Length);
                    Console.WriteLine(flanker[cislo]);
                }
                if (Class.ToLower().Contains("t") || Class.ToLower().Contains("tank") || Class.ToLower().Contains("front"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(tank.Length);
                    Console.WriteLine(tank[cislo]);
                }
                if (Class.ToLower().Contains("d") || Class.ToLower().Contains("dam") || Class.ToLower().Contains("dmg"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(damage.Length);
                    Console.WriteLine(damage[cislo]);
                }
            }


            Console.ReadKey();
        }
        static string[] ClassOne(string Class, string[] support, string[] flanker, string[] tank, string[] damage, int Lett)
        {
            string[] ClassJedna = new string[14];
            switch (Convert.ToString(Class[Lett]))
            {
                case "s":
                    ClassJedna = support;
                    break;
                case "f":
                    ClassJedna = flanker;
                    break;
                case "t":
                    ClassJedna = tank;
                    break;
                case "d":
                    ClassJedna = damage;
                    break;
                    }
            return ClassJedna;
        }
    }
}
