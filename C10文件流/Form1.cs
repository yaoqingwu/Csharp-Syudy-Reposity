using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace C10文件流
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region  路径操作
        /// <summary>
        ///  路径操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //更改路径字符串的后缀名 不会更改实际的文件  
            string newPath = Path.ChangeExtension(@"d:\12\12\12\1.ttt", "avi");
            newPath = @"d:\12" + "12.txt";
            //合并多个字符串路径 如果没有\ 自动加.
            newPath = Path.Combine(@"d:\12", "12.txt");
            string path = @"E:\广州传智\20130228.Net训练营四期\20130309集合_文件操作\Code\20130309\12.avi ";
            //得到文件路径所在的目录. 如果本身就是1个目录路径 就直接返回这个目录.
            newPath = Path.GetDirectoryName(path);
            //得到指定文件路径的后缀名 如果不是1个文件路径 返回空串.
            newPath = Path.GetExtension(path);
            //得到指定路径的文件名(带后缀的)
            newPath = Path.GetFileName(path);
            //只得到文件名 不要后缀
            newPath = Path.GetFileNameWithoutExtension(path);
            //相对路径 绝对路径.
            string p = "1.txt";
            newPath = Path.GetFullPath(p);
            //得到系统的临时目录.
            newPath = Path.GetTempPath();
            //得到1个随机的系统文件名  这个文件已经创建好了
            newPath = Path.GetTempFileName();
            MessageBox.Show("成功!" + newPath);
        } 
        #endregion

        #region 目录操作
        /// <summary>
        ///  目录操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //创建目录 如果目录存在则没有效果.如果是1个文件路径 会创建1个以这个文件名为文件夹
            //Directory.CreateDirectory(@"d:\哈哈哈\1.txt"); 
            //删除目录 如果不是空目录 报错
            //Directory.Delete(@"D:\哈哈哈"); 
            //删除目录(包括目录下的所有文件)
            //Directory.Delete(@"D:\哈哈哈", true);
            //判断指定的目录是否存在.
            //bool b = Directory.Exists(@"D:\1.txt"); 
            string newPath = Directory.GetCurrentDirectory();
            string path = @"d:\传智播客";
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog(); 
            //得到指定路径下的文件夹路径.
            string[] dirs = Directory.GetDirectories(path);
            //返回根目录
            newPath = Directory.GetDirectoryRoot(path);
            //得到指定目录下的所有的文件路径.
            dirs = Directory.GetFiles(path);
            //移动文件 (改名)
            //Directory.Move(@"d:\Test\A\1.txt", @"d:\test\B\2.txt");
            //Directory.Move(@"d:\test\B\2.txt", @"d:\test\B\3.txt");  
            MessageBox.Show("ok     :   " + newPath);
        } 
        #endregion

        #region 文件操作
        /// <summary>
        ///  文件操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //创建指定的文件  如果文件已存在 则覆盖
            //File.Create(@"d:\2.txt");
            //List<string> list = new List<string>();
            //File.AppendAllLines(@"d:\2.txt",list);  
            //向已有的文本文件中追加字符. 如果文件不存在 则创建1个新的文件.
            //  File.AppendAllText(@"d:\21.txt", "哈哈哈哈"); 
            //File.AppendText(@"d:\21.txt"); 
            //复制文件.
            // File.Copy(@"d:\test\b\2.txt", @"d:\test\a\3.txt"); 
            //删除文件.
            File.Delete(@"d:\test\b\2.txt"); 
            //判断指定路径的文件是否存在.
            File.Exists(@"d:\fan.txt"); 
            //文件移动.
            // File.Move(); 

            //Encoding.GetEncoding("gb2312")GB2312编码 
            string str = File.ReadAllText(@"d:\jian.txt",Encoding.Default);

            //读取文本文档 返回字符串数组.
            string[] lines = File.ReadAllLines(@"d:\fan.txt",Encoding.Default);

            MessageBox.Show("ok");
        } 
        #endregion


    }
}
