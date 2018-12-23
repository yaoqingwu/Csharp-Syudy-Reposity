using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05窗体应用程序
{
    class Program
    {
        static Form f;

        static void Main(string[] args)
        { 

            f = new Form();
            Button b = new Button();
            b.Text = "按钮";
            TextBox t = new TextBox();
            t.Size = new System.Drawing.Size(100,80);
            t.Location = new System.Drawing.Point(40,50);
            f.Controls.Add(b);
            f.Controls.Add(t);



            f.StartPosition = FormStartPosition.CenterScreen;
            f.Size = new System.Drawing.Size(800, 600);
            //要让窗体显示在桌面上 要调用这个窗体对象的Show方法.



            Thread thread = new Thread(Test);
            thread.IsBackground = true;
            thread.Start();

            Console.ReadKey();
        }

        static void Test()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }

    }
}
