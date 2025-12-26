using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi
{
    internal class Book
    {
        public string Name;
        public string Author;
        public string ISBN;
        public string Category;
        public bool IsAvailable;

        // Rezervasyon kuyruğu
        public System.Collections.Queue ReservationQueue;

        // Constructor
        public Book(string name, string author, string isbn, string category)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
            Category = category;
            IsAvailable = true;
            ReservationQueue = new System.Collections.Queue(); // kendi Queue sınıfımız olacak
        }
    }
}
