using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04窗体应用程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(StartWinForm);
            thread.IsBackground = true;
            thread.Start();



            Console.ReadKey();
        }

        static void StartWinForm()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }
}
