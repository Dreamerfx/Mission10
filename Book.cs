using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission10
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int CopyrightYear { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }

        public Book ( string title, List< string > authors , string isbn,
        string language, string genre, int copyrightYear, int pages, double price, int totalCopies, int availableCopies)
        {
          Title = title;
          Authors = authors;
          ISBN = isbn;
          Language = language;
          Genre = genre;
          CopyrightYear = copyrightYear;
          Pages = pages;
          Price = price;
          TotalCopies = totalCopies;
          AvailableCopies = availableCopies;
        }
        public override string ToString()
        {
            string str;
            str = $"Title: {Title} " ;
            foreach ( string author in Authors)
        {
            str += string .Format( $"\nAuthor: {author} " );
        }
            str += $"\nISBN: {ISBN} " ;
            str += $"\nLanguage: { Language} \nGenre: { Genre} " ;
            str += $"\nYear: { CopyrightYear} \nPages: { Pages} " ;
            str += $"\nPrice: { Price} \nTotal Copies: { TotalCopies} " ;
            str += $"\nAvailable Copies: { AvailableCopies} " ;
            return str;
        }
    }
}
