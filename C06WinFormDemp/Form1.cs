using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06WinFormDemp
{
   // class Person { public string Name { get; set; } }
    public partial class Form1 : Form
    {
        private Button btn;  
        
        //事件... 


        public Form1()
        {
          
            InitializeComponent();

            //this.btnTest.Text = "哈哈哈";
            //btn = new Button();
            //btn.Text = "阿牛";
            //this.Controls.Add(btn);
            MessageBox.Show("构造函数执行"); 
            //this.btnTest.Click += btnTest_Click;
            //this.btnTest.MouseHover += btnTest_MouseHover;

        }

        //void btnTest_MouseHover(object sender, EventArgs e)
        //{
        //    Console.WriteLine("鼠标来了.....");
        //}

        //void btnTest_Click(object sender, EventArgs e)
        //{
        //    Console.WriteLine("A");
        //} 

        private void Test()
        {
           
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("你好,我是消息框");
            //DialogResult res=  MessageBox.Show("你真的要删除吗?", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (res == System.Windows.Forms.DialogResult.Yes)
            //{
            //    MessageBox.Show("删除了");
            //}
            //else
            //{
            //    Console.WriteLine("没有删除2");
            //}  

            Button b = new Button();
            b.Text = "123";
            this.Controls.Add(b);
        } 

        //窗体显示之前 构造函数执行完毕之后.
        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("窗体的加载事件.");
        }
 
 


    }
}
