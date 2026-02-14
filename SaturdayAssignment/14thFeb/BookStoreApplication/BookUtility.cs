using System;

namespace BookStoreApplication
{
    public class BookUtility
    {
        private Book book;

        public BookUtility(Book bk)
        {
            // TODO: Assign book object
            book = bk;
        }

        public void GetBookDetails()
        {
            // TODO:
            // Print format:
            // Details: <BookId> <Title> <Price> <Stock>
            Console.WriteLine($"Details: {book.Id} {book.Title} {book.Price} {book.Stock}");
        }

        public void UpdateBookPrice(int newPrice)
        {
            // TODO:
            // Validate new price
            // Update price
            // Print: Updated Price: <newPrice>
            if(newPrice < 0){    
                Console.WriteLine("negative amt not allowed");
                return;
            }
            
            book.Price = newPrice;
            Console.WriteLine($"Updated Price: {book.Price}");
        }

        public void UpdateBookStock(int newStock)
        {
            // TODO:
            // Validate new stock
            // Update stock
            // Print: Updated Stock: <newStock>
            if(newStock < 0){
                Console.WriteLine("negative stock not allowed");
                return;
            }
            
            book.Stock = newStock;
            Console.WriteLine($"Updated Stock: {book.Stock}");
        }
    }
}
