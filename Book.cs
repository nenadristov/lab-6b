using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public enum Genre
    {
        Children,
        Fiction,
        NonFiction
    }

    class Book : Item
    {
        public string author { get; set; }
        public string ISBN { get; set; }
        public Genre genre { get; set; }


        public Book( string title, string author, string ISBN, Genre genre)
            : base(title)
        {
            this.author = author;
            this.ISBN = ISBN;
            this.genre = genre;

        }

        public bool Can_be_borrowed(Member name)
        {
            if (genre == Genre.Children && name.age <= 16)
            {
                Console.WriteLine("The book can be borrowed");
                return true;
            }
            else if (genre != Genre.Children)
            {

                Console.WriteLine("The book can be borrowed");
                return true;
            }
            else
                return true;

        }

        public override string ToString()
        {
            return $"  Additional book details: {author} {ISBN} {genre}.";
        }

    }
}
