using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using монстр;

namespace монстр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Monstr m1 = new Monstr();
                Monstr m2 = new Monstr();

                m1.set_hp();
                m1.set_dm();
                m2.set_hp();
                m2.set_dm();
                m1.DrawMonstr();
                m2.DrawMonstr();

                while (true)
                {
                    if (m1.get_hp() <= 0)
                    {
                        Console.WriteLine("win: " + m2.name);
                        break;
                    }
                    else if (m2.get_hp() <= 0)
                    {
                        Console.WriteLine("win: " + m1.name);
                        break;
                    }
                    Console.WriteLine();
                    m1.set_pr();
                    m2.set_pr();

                    if (m1.get_pr() < 3)
                    {
                         Console.ReadKey();
                        m2.set_hp(m1.get_hp()); 
                    }
                    else
                    {
                        Console.WriteLine(m1.name + " промахнулся");
                      
                    }
                  m2.DrawMonstr();
                    if (m2.get_pr() < 3)
                    {
                       
                        m1.set_hp(m2.get_hp());
                    }
                    else
                    {
                        Console.WriteLine(m2.name + " промахнулся");

                    }
                   m1.DrawMonstr();

                }
                

                Console.WriteLine("вы хотите закончить игру?");
                string otv = Console.ReadLine();
                if (otv == "да" || otv == "yes") break;
            }
            
        }
    }
}
