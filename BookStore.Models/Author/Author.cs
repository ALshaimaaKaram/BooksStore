using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.Book;

namespace BookStore.Models.Author
{
    public class Author : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string Bio { get; set; } = string.Empty ;
        public byte Image { get; set; }
        public ICollection<BookStore.Models.Book.Book> Books { get; set;}

    }
}
