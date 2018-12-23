using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07窗体案例
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private bool gender; 
        public string Gender
        {
            get { return gender == true ? "男" : "女"; }
            set { gender = value == "男" ? true : false; }
        }
        public string ClassName { get; set; }
    }
}
