using BookStore.Models.Book;
using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Present.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        IModelRepository<Book> bookRepo;
        IUnitOfWork unitOfWork;

        public BookController(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            bookRepo = unitOfWork.GetBookRepo();
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<Book>> Get()
        {

            IEnumerable<Book> books = await bookRepo.GetAsync();
            return books;
        }

        [HttpPost("Create")]
        public async Task<IEnumerable<Book>> Post(Book book)
        {
            await bookRepo.Add(book);
            await unitOfWork.Save();
            return await bookRepo.GetAsync();
        }

        [HttpPut("")]
        public async Task<Book> Update(Book book)
        {
            Book temp = await bookRepo.Update(book);
            await unitOfWork.Save();
            return temp;
        }

        [HttpDelete("{id}")]
        public async Task<Book> Remove(int Id)
        {
            Book bookdeleted = await bookRepo.GetByIdAsync(Id);
            Book temp = await bookRepo.Remove(bookdeleted);
            await unitOfWork.Save();
            return temp;
        }

        [HttpGet("GetByID/{id}")]
        public async Task<Book> GetByID(int Id)
        {
            Book temp = await bookRepo.GetByIdAsync(Id);
            return temp;
        }
    }
}
