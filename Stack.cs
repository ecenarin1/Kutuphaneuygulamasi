using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphaneuygulamasi
{
    internal class Stack
    {
        private StackNode top; // Stack’in tepe noktası
        private int count;     // Eleman sayısı

        public Stack()
        {
            top = null;
            count = 0;
        }

        public void Push(string data)
        {
            StackNode newNode = new StackNode(data);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public string Pop()
        {
            if (top == null)
                return null;

            string temp = top.Data;
            top = top.Next;
            count--;
            return temp;
        }

        public string Peek()
        {
            return top != null ? top.Data : null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Count()
        {
            return count;
        }
    }
}
