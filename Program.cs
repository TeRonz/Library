// See https://aka.ms/new-console-template for more information
using Library;

Librarian librarian = new Librarian();
Console.WriteLine("Nau mai haere mai i roto te library!");
InstructUser();
ServeUser();

void ServeUser()
{
    Console.WriteLine();
    var input = Convert.ToChar(Console.ReadKey().Key);
    Console.WriteLine();
    switch (Char.ToLower(input))
    {
         case 'a':
            AddBook();
            ServeUser();
            break;

        case 'r':
            RemoveBook();
            ServeUser();
            break;

        case 'i':
            ServeCheckIn();
            break;

        case 'o':
            ServeCheckout();
            break;

        case 's':
            ListBooks();
            ServeUser();
            break;

        case 'l':
            ListOverdueBooks();
            ServeUser();
            break;

        default:
            InstructUser();
            ServeUser();
            break;
    }
}
void InstructUser()
{
    Console.WriteLine("Press 'A' to add a book. ");
    Console.WriteLine("Press 'R' to remove a book. ");
    Console.WriteLine("Press 'I' to check in a book.");
    Console.WriteLine("Press 'O' to check out a book");
    Console.WriteLine("Press 'S' to see all books");
    Console.WriteLine("Press 'L' to see all overdue books");
}

void ServeCheckout()
{
    Console.WriteLine("Select an Id to checkout a book:");
    var userInput = Console.ReadKey();
    var id = Char.IsDigit(userInput.KeyChar) ? int.Parse(userInput.KeyChar.ToString()) : -1;
    Console.WriteLine();
    if (librarian.CheckOut(id))
    {
        ServeUser();
    }
    else
    {
        Console.WriteLine("Please select a valid id and an available book.");
        ServeCheckout();
    }
}

void ServeCheckIn()
{
    Console.WriteLine("Select an Id to checkin a book:");
    var userInput = Console.ReadKey();
    var id = Char.IsDigit(userInput.KeyChar) ? int.Parse(userInput.KeyChar.ToString()) : -1;
    Console.WriteLine();
    if (librarian.CheckIn(id))
    {
        ServeUser();
    }
    else
    {
        Console.WriteLine("Please select a valid id and an unavailable book.");
        ServeCheckIn();
    }
}

void ListBooks()
{
    Console.WriteLine("Books:");
    foreach (Book book in librarian.Books)
    {
        Console.WriteLine("Id: " + book.Id + " Title: " + book.Title + ", Author: " + book.Author + ", Available: " + book.Available);
    }
}

void AddBook()
{
    librarian.AddBook(new Book(librarian.Books.Count, AddTitle(), AddAuthor(), true, DateTime.Now));
}

string AddTitle()
{
    Console.WriteLine("Enter the title of the book you would like to add to the library");
    var title = Console.ReadLine();
    Console.WriteLine("Press 'Y' to confirm the title and 'N' to rewrite the title.");
    var confirm = Convert.ToChar(Console.ReadKey().Key);
    Console.WriteLine();
    switch (Char.ToLower(confirm))
    {
        case 'y':
            return title;

        case 'n':
            return AddTitle();

        default: return AddTitle();
    }
}

string AddAuthor()
{
    Console.WriteLine("Enter the author of the book you would like to add to the library");
    var author = Console.ReadLine();
    Console.WriteLine("Press 'Y' to confirm the author and 'N' to rewrite the author.");
    var confirm = Convert.ToChar(Console.ReadKey().Key);
    Console.WriteLine();
    switch (Char.ToLower(confirm))
    {
        case 'y':
            return author;

        case 'n':
            return AddAuthor();
            break;

        default: return AddAuthor();
    }
}

void RemoveBook()
{
    Console.WriteLine("Select an Id to remove a book from the library:");
    var userInput = Console.ReadKey();
    var id = Char.IsDigit(userInput.KeyChar) ? int.Parse(userInput.KeyChar.ToString()) : -1;
    Console.WriteLine();
    if (librarian.RemoveBook(id))
    {
        ServeUser();
    }
    else
    {
        Console.WriteLine("Please select a valid id to remove a book from the library.");
        RemoveBook();
    }
}

void ListOverdueBooks()
{
    Console.WriteLine("Overdue Books:");
    foreach (Book book in librarian.CalculateOverdueBooks())
    {
        Console.WriteLine("Id: " + book.Id + "Title: " + book.Title + ", Author: " + book.Author + ", Available: " + book.Available + "Checkout: " + book.CheckInOutTime);

    }
}