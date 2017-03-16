using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Menu
    {
        Book book = new Book();
        public void displaymenu()
        {
            Console.WriteLine("\nMenu\n" +
                        "1)Search book\n" +
                        "2)Issue book\n" +
                        "3)Submit book\n" +
                        "4)Exit\n\n");
            Console.Write("Choose your option :");
            chooseoption(Convert.ToInt32(Console.ReadLine()));
            
        }

         public void chooseoption(int option)
        {
            try
            {


                if (option == 1)
                {
                    search();
                }
                else if (option == 2)
                {
                    Issue();
                }
                else if (option == 3)
                {
                    Submit();
                }
                else if (option == 4)
                {
                    Console.WriteLine("Thank you");
                    Environment.Exit(4);
                }
                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }
            }
            catch(Exception ex)
            {
                Environment.Exit(4);
            }
        }

        public void search()
        {
            
            Console.WriteLine("Enter BookId to search.");
            book.Search(Console.ReadLine());
        }
        public void Issue()
        {
            Console.WriteLine("Enter BookId to be issued");
            book.Issue(Convert.ToInt32(Console.ReadLine()));
        }
        public void Submit()
        {
            Console.WriteLine("Enter the Book ID to be Submitted");
            book.Submit(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
