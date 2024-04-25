using System.Collections.ObjectModel;
namespace Library
{
    public class Librarian
    {
        public Collection<Book> Books { get; set; }
        public Librarian()
        {
            Books = [
                new Book(0, "Harry Potter and the Philosopher's Stone", "J.K.Rowling", true, DateTime.Now),
                new Book(1, "Harry Potter and the Chamber of Secrets", "J.K.Rowling", true, DateTime.Now),
                new Book(2, "Harry Potter and the Prisoner of Azkaban", "J.K.Rowling", true, DateTime.Now),
                new Book(3, "Harry Potter and the Goblet of Fire", "J.K.Rowling", true, DateTime.Now),
                new Book(4, "Harry Potter and the Order of the Phoenix", "J.K.Rowling", true, DateTime.Now),
                new Book(5, "Harry Potter and the Half Blood Prince", "J.K.Rowling", true, DateTime.Now),
                new Book(6, "Harry Potter and the Deathly Hallows", "J.K.Rowling", true, DateTime.Now)
                ];
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine("You have successfully added " + book.Title + " by " + book.Author + " to the library.");
        }

        public bool RemoveBook(int id)
        {
            if (IsIdValid(id))
            {
                var title = Books[id].Title;
                var author = Books[id].Author;
                Books.Remove(Books[id]);
                ReassignIds();
                Console.WriteLine("You have successfully removed " + title + " by " + author + " from the library.");

                return true;
            }
            return false;
        }

        public bool CheckOut(int id)
        {
            if (IsIdValid(id) && Books[id].Available)
            {
                Books[id].Available = false;
                Books[id].CheckInOutTime = DateTime.Now;
                Console.WriteLine("You have successfully checked out " + Books[id].Title + " by " + Books[id].Author + ".");
                return true;
            }
            return false;
        }

        public bool CheckIn(int id)
        {
            if (IsIdValid(id) && !Books[id].Available)
            {
                Books[id].Available = true;
                Books[id].CheckInOutTime = DateTime.Now;
                Console.WriteLine("You have successfully checked in " + Books[id].Title + " by " + Books[id].Author + ".");
                return true;
            }
            return false;
        }

        public Collection<Book> CalculateOverdueBooks()
        {
             return [.. Books.Where(book => !book.Available && ((DateTime.Now - book.CheckInOutTime).TotalMinutes > 1)).OrderBy(x => x.CheckInOutTime)];  
        }
        public bool IsIdValid(int id)
        {
            return id >= 0 && id < Books.Count;
        }

        public void ReassignIds()
        {
            foreach(Book book in Books)
            {
                book.Id = Books.IndexOf(book);
            }
        }
    }
}