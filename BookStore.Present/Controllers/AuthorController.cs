using BookStore.Models.Author;
using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Present.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        IModelRepository<Author> authorRepo;
        IUnitOfWork unitOfWork;

        public AuthorController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            authorRepo = unitOfWork.GetAuthorRepo();
        }

        [HttpGet("")]
        public async Task<IEnumerable<Author>> Get()
        {
            IEnumerable<Author> authors = await authorRepo.GetAsync();
            return authors;
        }

        [HttpPost("Create")]
        public async Task<IEnumerable<Author>> Post(Author author)
        {
            await authorRepo.Add(author);
            await unitOfWork.Save();
            return await authorRepo.GetAsync();
        }

        [HttpPut("")]
        public async Task<Author> Update(Author author)
        {
            Author temp = await authorRepo.Update(author);
            await unitOfWork.Save();
            return temp;
        }

        [HttpDelete("{id}")]
        public async Task<Author> Remove(int Id)
        {
            Author authordeleted = await authorRepo.GetByIdAsync(Id);
            Author temp = await authorRepo.Remove(authordeleted);
            await unitOfWork.Save();
            return temp;
        }

        [HttpGet("GetByID/{id}")]
        public async Task<Author> GetByID(int Id)
        {
            Author temp = await authorRepo.GetByIdAsync(Id);
            return temp;
        }
    }
}
