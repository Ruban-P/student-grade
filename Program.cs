using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            find f = new find();
              Console.WriteLine("enter the name :");
              string name = Console.ReadLine();
              
              Console.WriteLine("enter the reg no:");
              int reg = Convert.ToInt32(Console.ReadLine());


              List<int> l = new List<int>();
              Console.WriteLine("enter the number of subject");
              int num = Convert.ToInt32(Console.ReadLine());
              grade1 g1 = new grade1(name, reg);
              for (int i = 0; i < num; i++)
              {
                  Console.WriteLine("enter the mark"+(i+1));
                  int mark = Convert.ToInt32(Console.ReadLine());
                  l.Add(mark);
                   
              }
              g1.add(l);
              Console.WriteLine(g1);

              f.maxi(g1.Lst);
              f.mini(g1.Lst);
              f.totl(g1.Lst);
              f.avgerage(num);
              f.Addstud(g1);
              Console.WriteLine("___________________________________________________");
              Console.WriteLine("___________________________________________________");
            Console.WriteLine(f);            
        }
    }
}
