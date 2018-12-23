using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C07窗体案例
{
    public partial class Form1 : Form
    {

        List<Person> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<Person>();
            list.Add(new Person() { Age = 18, ClassName = "广州.NET四期", Gender = "男", Name = "建红" });
            list.Add(new Person() { Age = 11, ClassName = "广州.NET四期", Gender = "男", Name = "小明" });
            list.Add(new Person() { Age = 12, ClassName = "广州.NET四期", Gender = "男", Name = "小红" });
            list.Add(new Person() { Age = 15, ClassName = "广州.NET四期", Gender = "男", Name = "小健" });
            list.Add(new Person() { Age = 17, ClassName = "广州.NET四期", Gender = "男", Name = "小六" });
            list.Add(new Person() { Age = 19, ClassName = "广州.NET四期", Gender = "女", Name = "花花" });
            list.Add(new Person() { Age = 10, ClassName = "广州.NET四期", Gender = "男", Name = "建红2" });
            list.Add(new Person() { Age = 8, ClassName = "广州.NET四期", Gender = "男", Name = "建红3" });
            list.Add(new Person() { Age = 28, ClassName = "广州.NET四期", Gender = "男", Name = "建红4" });
            list.Add(new Person() { Age = 38, ClassName = "广州.NET四期", Gender = "男", Name = "建红5" });
            list.Add(new Person() { Age = 48, ClassName = "广州.NET四期", Gender = "男", Name = "建红6" });
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dgvData.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            string className = txtClassName.Text;
            string gender;
            if (radBoy.Checked)
            {
                gender = "男";
            }
            else
            {
                gender = "女";
            }

            Person p = new Person() { Age = age, ClassName = className, Gender = gender, Name = name };
            list.Add(p);


            BindingSource bs = new BindingSource();
            bs.DataSource = list;

            dgvData.DataSource = bs;
            MessageBox.Show("新增成功");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string value = dgvData.SelectedRows[0].Cells[0].Value.ToString();

        }


    }
}
