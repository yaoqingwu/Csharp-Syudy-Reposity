using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03异常处理
{
    class Program
    {
        static void Main1(string[] args)
        {
            //1.错误
            //不符合语法规范.
            //2.异常 一旦发生  程序就会立即停止.
            //在运行的时候发生的.

            //只把有可能发生异常的代码用try包围起来. 
            //try里的代码如果发生异常 就会立即跳到catch里面去执行 执行完成之后 继续往下执行.
            //try里的代码如果没有发生异常 catch里的代码不会被执行  继续往下.
            //try里代码如果有1句发生异常. 立即跳到catch try后面的代码不会被执行.
            //catch后面可以用括弧写1个Exception变量用来接收发生异常的具体信息.

            int i = 1;
            int j = 2;

            int k = 0;
            try
            {
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"";
                //conn.Open();
                if (j == 2 || j == 0)
                {
                    throw new Exception("除数不能为2");
                }
                Console.WriteLine("BBBBB");
                k = i / j;
            }
            catch (MyException ex)
            {
                Console.WriteLine("这是特殊的处理....");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生异常了...." + ex.Message);
            }

            Console.WriteLine(k);
            Console.WriteLine("AAAA");


            Console.ReadKey();
        }
    }
}
