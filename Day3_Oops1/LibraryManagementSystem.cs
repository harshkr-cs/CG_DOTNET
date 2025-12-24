using System;
class Library
{
    // PART 1: Internal Data Storage (PRIVATE)
    private Dictionary<int, string> books = new Dictionary<int, string>();

    // PART 2: Integer-Based Indexer (Read + Write)
    public string this[int bookId]
    {
        get
        {
            if (books.ContainsKey(bookId))
                return books[bookId];
            else
                return "Book ID not found";
        }
        set
        {
            books[bookId] = value;
        }
    }

    // PART 3: String-Based Indexer (Read-Only)
    public string this[string title]
    {
        get
        {
            foreach (var book in books)
            {
                if (book.Value.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book.Value;
                }
            }
            return "Book title not found";
        }
    }
}