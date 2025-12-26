using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi
{
    internal class QueueNode
    {
        public Student Data;    // Kuyruğa eklenen öğrenci
        public QueueNode Next;  // Sonraki node

        public QueueNode(Student data)
        {
            Data = data;
            Next = null;
        }
    }
}
