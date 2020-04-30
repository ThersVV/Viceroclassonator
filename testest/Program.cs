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
            string[] support = { "Furia", "Seris", "Grover", "Ying", "Jenos", "Mal'Damba", "Io", "Grohk", "Pip" };
            string[] flanker = { "Androxus", "Buck", "Evie", "Koga", "Lex", "Maeve", "Moji", "Skye", "Talus", "Zhin" };
            string[] tank = { "Ash", "Atlas", "Barik", "Fernando", "Inara", "Khan", "Makoa", "Raum", "Ruckus", "Terminus", "Torvald (I´m so sorry)" };
            string[] damage = { "Bomb king", "Cassie", "Dredge", "Drogoz", "Imani", "Kinessa", "Lian", "Shalin", "Strix", "Tiberius", "Tyra", "Viktor", "Vivian", "Willo" };
            string[] all = support.Concat(flanker.Concat(tank.Concat(damage))).ToArray();
            Random rnd = new Random();
            int SupLen = support.Length-1;
            int FlaLen = flanker.Length-1;
            int TanLen = tank.Length-1;
            int DamLen = damage.Length-1;
            int AllLen = all.Length-1;
            Console.WriteLine("Choose your class: Support (s), Flank(f), Tank(t), Damage(d) or all of them (all)");
            string Class = Console.ReadLine();
            if (Class.Contains("+"))
            {
                string[] Brambora = new string[100];
                int Loong = Class.Length;
                switch (Loong)
                {
                    case 3:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2)).ToArray();
                        break;
                    case 5:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4))).ToArray();
                        break;
                    case 7:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6))).ToArray();
                        break;
                    case 9:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8))).ToArray();
                        break;
                    case 11:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8)).Concat(ClassOne(Class, support, flanker, tank, damage, 10))).ToArray();
                        break;
                    case 13:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8)).Concat(ClassOne(Class, support, flanker, tank, damage, 10)).Concat(ClassOne(Class, support, flanker, tank, damage, 12))).ToArray();
                        break;
                    case 15:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8)).Concat(ClassOne(Class, support, flanker, tank, damage, 10)).Concat(ClassOne(Class, support, flanker, tank, damage, 12)).Concat(ClassOne(Class, support, flanker, tank, damage, 14))).ToArray();
                        break;
                    case 17:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8)).Concat(ClassOne(Class, support, flanker, tank, damage, 10)).Concat(ClassOne(Class, support, flanker, tank, damage, 12)).Concat(ClassOne(Class, support, flanker, tank, damage, 14)).Concat(ClassOne(Class, support, flanker, tank, damage, 16))).ToArray();
                        break;
                    case 19:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8)).Concat(ClassOne(Class, support, flanker, tank, damage, 10)).Concat(ClassOne(Class, support, flanker, tank, damage, 12)).Concat(ClassOne(Class, support, flanker, tank, damage, 14)).Concat(ClassOne(Class, support, flanker, tank, damage, 16)).Concat(ClassOne(Class, support, flanker, tank, damage, 18))).ToArray();
                        break;
                    case 21:
                        Brambora = ClassOne(Class, support, flanker, tank, damage, 0).Concat(ClassOne(Class, support, flanker, tank, damage, 2).Concat(ClassOne(Class, support, flanker, tank, damage, 4)).Concat(ClassOne(Class, support, flanker, tank, damage, 6)).Concat(ClassOne(Class, support, flanker, tank, damage, 8)).Concat(ClassOne(Class, support, flanker, tank, damage, 10)).Concat(ClassOne(Class, support, flanker, tank, damage, 12)).Concat(ClassOne(Class, support, flanker, tank, damage, 14)).Concat(ClassOne(Class, support, flanker, tank, damage, 16)).Concat(ClassOne(Class, support, flanker, tank, damage, 18)).Concat(ClassOne(Class, support, flanker, tank, damage, 18))).ToArray();
                        break;
                }
                int num69 = Brambora.Length-1;
                int cislo = rnd.Next(0, num69);
                Console.WriteLine(Brambora[cislo]);
            }
            else
            {
                if (Class.ToLower().Contains("all"))
                {

                    int cislo = rnd.Next(0, AllLen);
                    Console.WriteLine(all[cislo]);
                }
                if (Class.ToLower().Contains("s"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(0, SupLen);
                    Console.WriteLine(support[cislo]);
                }
                if (Class.ToLower().Contains("f"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(0, FlaLen);
                    Console.WriteLine(flanker[cislo]);
                }
                if (Class.ToLower().Contains("t") || Class.ToLower().Contains("tank") || Class.ToLower().Contains("front"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(0, TanLen);
                    Console.WriteLine(tank[cislo]);
                }
                if (Class.ToLower().Contains("d") || Class.ToLower().Contains("dam") || Class.ToLower().Contains("dmg"))
                {
                    Console.WriteLine("");
                    int cislo = rnd.Next(0, DamLen);
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
