namespace Library
{
    public class Book
    {
       public Book(int id, string title, string author, bool available, DateTime checkInOutTime)
        {
            Id = id;
            Title = title;
            Author = author;  
            Available = available;
            CheckInOutTime = checkInOutTime;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public bool Available { get; set; }    
        
        public DateTime CheckInOutTime { get; set; }
    }
}
