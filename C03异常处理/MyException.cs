﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03异常处理
{
    class MyException : Exception
    {
        public MyException(string msg)
            : base(msg)
        {
        }
    }
}
