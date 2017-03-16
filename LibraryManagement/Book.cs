using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Book
    {
        public static int bookid { get; set; }
        public static string bookname { get; set; }

      static Dictionary<int, string> books()
        {
            Dictionary<int, string> bookdetail = new Dictionary<int, string>();
            bookdetail.Add(001, "Physics");
            bookdetail.Add(002, "Chemistry");
            bookdetail.Add(003, "Maths");
            bookdetail.Add(004, "History");
            return bookdetail;
        }

        
        Dictionary<int, string> booklist = Book.books();

        internal void Search(string value)
        {

            try
            {
                int output;
                if (Int32.TryParse(value, out output))
                {
                    if (booklist.ContainsKey(output))
                    {
                        Console.WriteLine("Book Found");
                        Console.WriteLine("Name:" + booklist[output]);
                        Console.WriteLine("BookId:" + value);
                        Console.WriteLine("Total No Of Books:" + booklist.Count.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Book Not Found");
                    }
                } 
                else
                {
                    if (booklist.ContainsValue(value))
                    {
                        Console.WriteLine("Book Found");
                        Console.WriteLine("Name:" + booklist[output]);
                        Console.WriteLine("BookId" + value);
                        Console.WriteLine("Total No Of Books:" + booklist.Count.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Book Not Found");
                    }
                }
            }
            catch(Exception ex)
            {
                Environment.Exit(4);
            }
            
        }

        
        internal void Issue(int Id)
        {
           
            if (booklist.ContainsKey(Id))
            {
                Console.WriteLine("Book '{0}' Issued !!", booklist[Id]);
                booklist.Remove(Id);
                Console.WriteLine("Books Left:" + booklist.Count.ToString());
            }
        }

        internal void Submit(int Id)
        {
            
            if (booklist.ContainsKey(Id))
            {
                Console.WriteLine("Book '{0}' Submitted !!", booklist[Id]);
                Console.WriteLine("Total No Of Books:" + booklist.Count.ToString());
            }
        }

    }
}
