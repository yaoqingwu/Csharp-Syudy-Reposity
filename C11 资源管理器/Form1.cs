using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C11_资源管理器
{
    public partial class Form1 : Form
    {

        string path = @"d:\广州传智";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //得到根目录下的所有的子目录的路径
            string[] dirs = Directory.GetDirectories(path);
            //TreeView下的根节点在TreeView对象的Nodes集合中.
            foreach (string dir in dirs)
            {
                //每1个节点的类型是1个TreeNode类型
                //TreeNode对象的Text属性就是 节点上面显示的文本.
                TreeNode node = new TreeNode();
                //将全路径保存在node对象的tag属性中.
                node.Tag = dir;
                node.Text = Path.GetFileName(dir);
                tvMain.Nodes.Add(node);
                //tvMain.Nodes.Add(Path.GetFileName(dir));
            }

        }

        /// <summary>
        ///  在选中1个节点之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //0. 清空ListView中的所有的项目
            lvData.Items.Clear();
            //1. 得到选中的节点
            string path = tvMain.SelectedNode.Tag.ToString();
            //2.得到选中的节点所代表的文件夹的路径 
            //3. 将这个路径下的所有的文件的信息读出. 
            //将路径下面的所有的文件的信息返回.
            string[] files = Directory.GetFiles(path);
            ListViewItem item = null;
            //遍历files数组 将每1个元素封装为1个ListViewItem对象 并添加到ListView中
            FileInfo info = null;
            foreach (string file in files)
            {
                info = new FileInfo(file);
                item = new ListViewItem();
                item.Text = Path.GetFileName(file);
                item.Tag = file;
                item.SubItems.Add(info.Length.ToString());
                item.SubItems.Add(info.CreationTime.ToString());
                lvData.Items.Add(item);
            }
            //加载当前目录下的子文件夹为当前节点的子节点.
            string[] dirs = Directory.GetDirectories(path);
            foreach (string str in dirs)
            {
                TreeNode node = new TreeNode();
                node.Text = Path.GetFileName(str);
                node.Tag = str;
                tvMain.SelectedNode.Nodes.Add(node);
            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 得到我们选中的那1项吧
            string path = lvData.SelectedItems[0].Tag.ToString();
            //2. 得到选中的那1项的文件的全路径
            if (MessageBox.Show("你真的要删除吗?删除以后就找不到了哦!", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
            {
                // //3.删除文件.
                File.Delete(path);
                lvData.SelectedItems[0].Remove();
            }  
        }
    }
}
