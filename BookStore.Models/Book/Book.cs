using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Book
{
    public class Book : BaseModel
    {
        public string Title { get; set; } = string.Empty;
        public DateTime DateOfPublication { get; set; }
        //public byte Cover { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<Author.Author> Authors { get; set; }
    }
}
