using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            string input=Console.ReadLine();
            string[] parts=input.Split(' ');
            string id = parts[0];
            string title = parts[1];
            string author = parts[2];
            int price = int.Parse(parts[3]);
            int stock = int.Parse(parts[4]);

            Book book = new Book()
            {
                Id = id,
                Title = title,
                Author = author,
                Price = price,
                Stock = stock
            };

            BookUtility utility = new BookUtility(book);
            bool flag=true;
            while (flag)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                        // TODO:
                        int newPrice = int.Parse(Console.ReadLine()!);
                        utility.UpdateBookPrice(newPrice);
                        // Read new price
                        // Call UpdateBookPrice()
                        break;

                    case 3:
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        int newStock = int.Parse(Console.ReadLine()!);
                        utility.UpdateBookStock(newStock);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        flag=false;
                        break;

                    default:
                        // TODO: Handle invalid choice
                        Console.WriteLine("Enter Valid choice");
                        break;
                }
            }
        }
    }
}
