using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphaneuygulamasi
{
    internal class Student
    {
        public string Name;       // Öğrenci adı
        public string StudentID;  // Öğrenci numarası

        // Constructor
        public Student(string name, string studentID)
        {
            Name = name;
            StudentID = studentID;
        }
    }
}
