using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission10
{
    class Program
    {
        static void Main(string[] args)
        {
          List< string > authors1 = new List< string >() { "Hemingway" };
          Book myFavoriteBook1 = new Book( "The Old Man and The Sea" , authors1, "123456789" , "English" , "Fiction" , 1952, 160, 19.99, 3, 3);
          Console.WriteLine(myFavoriteBook1);
          List< string > authors2 = new List< string >() { "Alan Moore" , "Dave Gibbons" };
          Book myFavoriteBook2 = new Book( "Watchmen" , authors2, "223456789" , "English" , "Mystery" , 2019, 416, 29.99, 3, 3);
          Console.WriteLine(myFavoriteBook2);
          Console.ReadKey();
        }
    }
}
