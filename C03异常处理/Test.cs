using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03异常处理
{
    class Test
    {
        static void Main()
        {
            //int i = 12;
            //int j = 1;
            //int k = 0; 
            //try
            //{
            //    k = i / j;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally //不管有没有发生异常 finally里的代码都会被执行...
            //{
            //    Console.WriteLine("我是finally.....");
            //} 

            Console.WriteLine(Test1().Age); 
            Console.ReadKey(); 
        }


        static Person Test1()
        {
            int i = 1; 
            int j =1;
            Person p = new Person();
            p.Age = 1;
            try
            {
                int k = i / j;
                return p;
            } 
            finally
            {
                p.Age++;
            } 

        }
    }
}
