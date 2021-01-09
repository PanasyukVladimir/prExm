using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class LIFO
    {
        private int[] array;
        private int length;

        public LIFO(int size)
        {
            array = new int[size];
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public int Get()
        {
            lock (array)
            {
                var index = array.Length - length;
                var item = array[index];
                array[index] = 0;
                length--;
                return item;
            }
        }

        public void Push(int item)
        {
            lock (array)
            {
                array[array.Length - length - 1] = item;
                length++;
            }
        }
    }
}
