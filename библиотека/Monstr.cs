using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using монстр;

namespace монстр
{
    public class Monstr
    {
        static Random rnd = new Random();
        static string[] haract = new string[5] { "добрый", "славный", "кусачий", "злой", "бешеный" };
        static string[] names = new string[5] { "гоблин", "рыцарь", "злыдень", "водяной", "воин" };

        public string name;
        int hp;
        int damage;
        int prom;

       public Monstr()
        {
            name = names[rnd.Next(5)] + " " + haract[rnd.Next(5)];
        }

        public int get_pr()
        {
            return prom;
        }
        public int set_pr()
        {
            prom = rnd.Next(0, 4);
            return prom;
        }
        public int get_hp()
        {
            return hp;
        }
        public int set_hp()
        {
            hp = rnd.Next(75, 101);
            return hp;
        }
        public int get_dm()
        {
            return damage;
        }
        public int set_dm()
        {
            damage = rnd.Next(10, 21);
            return damage;
        }
        public int set_hp(int dmg)
        {
            hp = hp - dmg;
            if (hp < 0)
            {
                hp = 0;
            }
            return hp;
        }
        public void DrawMonstr()
        {
            Console.WriteLine("+-------" + name);
            Console.WriteLine("| здоровье:" + hp);
            Console.WriteLine("| урон:" + damage);
            Console.WriteLine("+-------");
        }
    }
}
