using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02Hashtable
{
    class Person
    {
        public void SayHI() { }
    }
    class Studen:Person
    {
        public void SayHello() { }
    }


    class Program
    {
        static void Main(string[] args)
        { 
           //MyArrayList<int> list = new MyArrayList<int>();   
           //MyArrayList<Person> list1 = new MyArrayList<Person>(); 

            List<Person> list = new List<Person>(); 
            list.Add(new Person());
            list.Add(new Person());
            list.Add(new Person());
            list.Add(new Person());
            list.Add(new Person());
            list.Add(new Studen());


            foreach (Person p in list)
            {
                p.SayHI();
            }



            Dictionary<string, Person> dic = new Dictionary<string, Person>();
            dic.Add("x", new Person());
            dic.Add("y", new Person()); 
            dic["x"].SayHI();

            foreach (string key in dic.Keys)
            {

            } 
            foreach (Person p in dic.Values)
            {

            } 
            foreach (KeyValuePair<string, Person> pair in dic)
            {
                Console.WriteLine(pair.Key+":"+pair.Value);
            } 

            Dog<Person> dog = new Dog<Person>();
            Dog<int> dog1 = new Dog<int>();





            Console.ReadKey();
            //ArrayList list = new ArrayList();
            //list.Add(new Person());
            //list.Add(new Studen()); 
            //foreach (object obj in list)
            //{
               
            //}


            //Hashtable table = new Hashtable();
            //table.Add("12", "1");
            //table.Add("112", "2");
            ////table.Add("2", "3");
            //table.Add("31", "4");
            //table.Add("41", "5");
            //table.Add("53", "5");

            //键值对 是以键的hash值算出其所对应的下标.  
            //for (int i = 0; i < table.Count; i++)
            //{
            //    Console.WriteLine(table[i]);
            //}
            // 1000   1000   999 
            //  return ArrayList[10]    


            Console.ReadKey();

        }
    }
}
