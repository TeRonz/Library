// See https://aka.ms/new-console-template for more information
using Library;

Librarian librarian = new Librarian();

Console.WriteLine("Nau mai haere mai i roto te library!" +
    " Press 'A' to add a book. " +
    "Press 'R' to remove a book. " +
    "Press 'I' to check in a book." +
    "Press 'O' to check out a book" +
    "Press 'S' to see all books" +
    "Press 'L' to see all overdue books");


var input = Convert.ToChar(Console.ReadKey());
switch (Char.ToLower(input))
{
    //case A:
    //    break;

    //case R:
    //    break;
    //case I:
    //    break;

    //case O:
    //    break;
    case 's':
        foreach (Book book in librarian.Books)
        {
            Console.WriteLine(book);
        }
        break;

    //case L:
    //    break;

    default: Console.WriteLine("Please Select a valid option");
        break;
}



