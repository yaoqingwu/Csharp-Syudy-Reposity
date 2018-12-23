using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08单例模式
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = Person.GetSingle();
            Person p2 = Person.GetSingle();
            Person p3 = Person.GetSingle();
        }
    }
}
