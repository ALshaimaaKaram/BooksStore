using BookStore.Models.Author;
using BookStore.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public interface IUnitOfWork
    {
        IModelRepository<Book> GetBookRepo();
        IModelRepository<Author> GetAuthorRepo();
        Task Save();
    }
}
