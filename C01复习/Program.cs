using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01复习
{
    class Person
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //1. 字符串. 只读的字符数组.
            //2. ArrayList
            // ArrayList list = new ArrayList();
            // Person p = new Person();
            // list.Add(p);
            // list.Add(p);
            // list.Add(1);
            // //list.Add(1);
            // //list.AddRange();
            // //list.Remove(p);
            // //list.RemoveAt(1);
            //// list.RemoveRange();

            // list[0] = new object(); //0  -  Count-1

            // for (int i = 0; i < list.Count; i++)
            // {
            //     Console.WriteLine(list[i]);
            // }

            // foreach (object o in list)
            // {
            //     if (o is Person)
            //     {
            //         (o as Person).ToString();
            //     }
            // } 

            //Hashtable table = new Hashtable();
            //// "\r\n" string.Empty;
            ////table.Add("xiaoMing", new Person());
            //////删除
            ////table.Remove("xiaoMing");
            //////如果Key存在 就会修改 如果key不存在就新增.
            //table["xiaoMing"] = new object();
            ////遍历.
            ////table.Keys;
            ////table.Values; 

            //string jian = File.ReadAllText(@"d:\Jian.txt",Encoding.Default);
            //string fan = File.ReadAllText(@"d:\Fan.txt", Encoding.Default);
            //jian = jian.Replace("\r\n", string.Empty);
            //fan = fan.Replace("\r\n", string.Empty);
            //Hashtable table = new Hashtable();
            //for (int i = 0; i < jian.Length; i++)
            //{
            //    table.Add(jian[i], fan[i]);
            //}
            ////Console.WriteLine("曾经沧海难为水,除却巫山不是云.");
            //string str = "曾经沧海难为水,除却巫山不是云.";
            //string str1 = string.Empty;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (table.ContainsKey(str[i]))
            //    {
            //        str1 += table[str[i]];
            //    }
            //    else
            //    {
            //        str1 += str[i];
            //    }
            //}
            //Console.WriteLine(str1);


            string content = File.ReadAllText(@"d:\1.txt",Encoding.Default); //"我我我我爱爱啊i啊背景天安门"
            Hashtable table = new Hashtable();
            foreach (char c in content)
            {
                if (table.ContainsKey(c))
                {
                    int num = (int)table[c];
                    num++;
                    table[c] = num;
                }
                else
                {
                    table.Add(c, 1);
                }
            }
            foreach (char c in table.Keys)
            {
                Console.WriteLine(c+":"+table[c]);
            }



            Console.ReadKey();
        }
    }
}
