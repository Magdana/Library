using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int PublicationYear { get; set; }
        public string GetBookInfo()
        {
            return $"Title: {Title}, by {Author}, ({PublicationYear})";
        }
    }

}
