using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08单例模式
{
    class Person
    {
        public string Name { get; set; }
        //1. 私有化构造函数
        //2. 提供1个私有的静态的Person类型的变量
        //3. 提供1个公共的静态的方法 用于返回上面的变量. 
        private static Person p;

        public static Person GetSingle()
        {
            if (p == null)
            {
                p = new Person();
            }
            return p;
        } 
        private Person()
        {

        } 
    }
}
