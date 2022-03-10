using BookStore.Models.Author;
using BookStore.Models.Book;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        DBContext context;
        IModelRepository<Book> bookRepo;
        IModelRepository<Author> authorRepo;
        public UnitOfWork(DBContext _context, IModelRepository<Book> _bookRepo, IModelRepository<Author> _authorRepo)
        {
            context = _context;
            bookRepo = _bookRepo;
            authorRepo = _authorRepo;
        }

        public IModelRepository<Book> GetBookRepo()
        {
            return bookRepo;
        }
        public IModelRepository<Author> GetAuthorRepo()
        {
            return authorRepo;
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
