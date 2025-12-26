using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi
{
    internal class Queue
    {
        private QueueNode front; // Kuyruğun başı
        private QueueNode rear;  // Kuyruğun sonu
        private int count;       // Eleman sayısı

        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public void Enqueue(Student data)
        {
            QueueNode newNode = new QueueNode(data);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            count++;
        }

        public Student Dequeue()
        {
            if (front == null)
                return null;

            Student temp = front.Data;
            front = front.Next;
            if (front == null)
                rear = null;

            count--;
            return temp;
        }

        public Student Peek()
        {
            return front != null ? front.Data : null;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Count()
        {
            return count;
        }

    }
}
