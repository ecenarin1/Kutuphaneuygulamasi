using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi
{
    internal class StackNode
    {
        public string Data;    // Log metni
        public StackNode Next; // Sonraki node

        public StackNode(string data)
        {
            Data = data;
            Next = null;
        }
    }
}
