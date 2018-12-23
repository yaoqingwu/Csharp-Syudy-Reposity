using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01复习
{
    /// <summary>
    ///  我们自己的集合. //int类型的数.
    /// </summary>
    class MyArrayList : IEnumerable,IEnumerator
    {
        /// <summary>
        ///  数组字段.  这个数组用来存储整型数据。
        /// </summary>
        private int[] arr; //10.10

        /// <summary>
        ///  保存着1次往arr里存储数据的索引
        /// </summary>
        int index = 0;//1   2 

        /// <summary>
        ///  元素的个数
        /// </summary>
        public int Count
        {
            get
            {
                return index;
            }
        }


        /// <summary>
        ///  构造函数用来初始化数组的长度
        /// </summary>
        /// <param name="capcity"></param>
        public MyArrayList(int capcity)
        {
            this.arr = new int[capcity];
        }

        public MyArrayList() { }

        public void Add(int value) //1  index  2   3
        {
            //当新增1个元素的时候.
            //我判断一下 arr 有没有存满  如果没有存满就继续往里存
            if (index >= arr.Length)  //
            {
                //我重新创建1个数组 数组的长度是原来的2倍
                int[] newArr = new int[arr.Length * 2];
                //将原来的数组中的数据拷贝到新数组中.
                Array.Copy(arr, newArr, arr.Length);
                //然后将旧数组的变量指向新数组
                arr = newArr;
            }
            arr[index++] = value;
        }

        /// <summary>
        ///  索引器 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }


        /// <summary>
        ///  新增1个范围.
        /// </summary>
        /// <param name="arr"></param>
        public void AddRange(int[] arr)
        {
            foreach (int item in arr)
            {
                this.Add(item);
            }
        }

        //实现IEnumerable成员 
        public IEnumerator GetEnumerator()
        {
            return this;
        }

    }

    class MyIEnumerator : IEnumerator
    { 
        private int[] arr;

        /// <summary>
        ///  保存的是当前读到第几个元素 默认-1
        /// </summary>
        int index = -1;

        int count;

        public MyIEnumerator(int[] arr,int count)
        {
            this.arr = arr;
            this.count = count;
        }

        /// <summary>
        ///  返回当前指针指向的元素的值
        /// </summary>
        public object Current
        {
            get
            {
               return  this.arr[index];
            }
        }

        /// <summary>
        ///  是将指针向前移动1位，并判断当前位有没有元素.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            index++;
            if (index < this.count)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
