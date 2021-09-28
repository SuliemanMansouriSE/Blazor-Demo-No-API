using Microsoft.EntityFrameworkCore;
using SM.Demo.Domain.Entities;
using SM.Demo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Demo.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Delete(Guid id)
        {
            var tmp = _dbContext.Authors.FirstOrDefault(x => x.Id == id);
            if (tmp != null)
            {
                _dbContext.Authors.Remove(tmp);
                await _dbContext.SaveChangesAsync();
            }
        }



        public async Task<ICollection<Author>> GetAll()
        {
            return await _dbContext.Authors.ToListAsync();
        }

        public async Task<Author> GetById(Guid guid)
        {
            return await _dbContext.Authors.Where(x => x.Id == guid).FirstOrDefaultAsync();
        }

        public async Task<ICollection<Author>> GetByName(string name)
        {
            return await _dbContext.Authors.Where(x => x.Name.Contains(name)).ToListAsync();
        }

        public async Task<Author> Save(Author book)
        {
            _dbContext.Authors.Add(book);
            await _dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<Author> Update(Author book)
        {
            var tmp = _dbContext.Authors.FirstOrDefault(x => x.Id == book.Id);
            if (tmp != null)
            {
                _dbContext.Entry(tmp).CurrentValues.SetValues(book);
                await _dbContext.SaveChangesAsync();
                return book;
            }
            return null;
        }
    }
}

