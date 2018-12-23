using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09子窗体
{
    public partial class FormAdd : Form
    {
        private static FormAdd f;

        public static FormAdd GetSingle()
        {
            if (f == null||f.IsDisposed)
            {
                f = new FormAdd();
            }
            return f;
        }


        private FormAdd()
        {
            InitializeComponent();
        }
    }
}
