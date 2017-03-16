using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool cont = true;
            while(cont)
            {                
                Menu menu = new Menu();
                menu.displaymenu();
                Console.WriteLine("Do You Want To Continue ? (True / False )");
                cont = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }
}
