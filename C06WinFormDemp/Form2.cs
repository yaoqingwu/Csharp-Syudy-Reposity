using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://gz.itcast.cn");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            Uri u = new Uri(url);
            webBrowser1.Url = u;
        }
    }
}
