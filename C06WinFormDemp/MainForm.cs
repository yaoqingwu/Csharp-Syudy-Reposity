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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("我被点了...");

            //if (cBoxLanQiu.Checked)
            //{
            //    Console.WriteLine("你喜欢篮球么?我也是呢!");
            //}

            ColorDialog cd = new ColorDialog();
            DialogResult res = cd.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                Color c = cd.Color;

            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cBoxLanQiu.Checked = true;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //为下拉框动态的绑定数据
            this.comboBox1.Items.Add("123");
            this.comboBox1.Items.Add("456");

           // this.pictureBox1.im

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            t.Start();


            //MessageBox.Show( this.comboBox1.Text);
        }

        void t_Tick(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-DD hh:mm:ss");
            label1.Text = now;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
