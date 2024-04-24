using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public  class Librarian
    {

        public Collection<Book> Books { get; set; }
        public Librarian()
        {
            Books = [
                new Book(1, "Harry Potter and the Philosopher's Stone", "J.K.Rowling", true, DateTime.Now),
                new Book(2, "Harry Potter and the Chamber of Secrets", "J.K.Rowling", true, DateTime.Now),
                new Book(3, "Harry Potter and the Prisoner of Azkaban", "J.K.Rowling", true, DateTime.Now),
                new Book(4, "Harry Potter and the Goblet of Fire", "J.K.Rowling", true, DateTime.Now),
                new Book(5, "Harry Potter and the Order of the Phoenix", "J.K.Rowling", true, DateTime.Now),
                new Book(6, "Harry Potter and the Half Blood Prince", "J.K.Rowling", true, DateTime.Now),
                new Book(7, "Harry Potter and the Deathly Hallows", "J.K.Rowling", true, DateTime.Now)
                ];

        }

        //public void AddBook(Book book)
        //{
        //    Books.Add(book);
        //}

        //public void RemoveBook(int id)
        //{
        //    Books.Remove(Books.Remove());
        //}

        public void CheckOut(int id)
        {

        }

        public void Checkin(int id)
        {

        }

        //public Collection<Book> CalculateOverdueBooks()
        //{

        //}

    }
}
