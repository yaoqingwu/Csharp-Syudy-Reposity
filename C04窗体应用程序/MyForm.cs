using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04窗体应用程序
{
    class MyForm:Form
    {
        Button btn = new Button();

        public MyForm()
        {
            Label.CheckForIllegalCrossThreadCalls = false;
            btn.Location = new Point(10,10);
            btn.Text = "按钮";
            btn.Visible = true;
            btn.Click += btn_Click;
            this.Controls.Add(btn);
        }

        void btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("A");
        }
    }
}
