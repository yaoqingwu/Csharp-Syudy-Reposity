using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05窗体应用程序
{
    class MyForm:Form
    {
        private Button btn;


        public MyForm()
        {
            btn = new Button();
            btn.Text = "按钮";
            btn.Location = new System.Drawing.Point(40,40);
            this.Controls.Add(btn); 
        }




    }
}
