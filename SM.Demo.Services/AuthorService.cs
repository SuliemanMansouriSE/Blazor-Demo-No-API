using SM.Demo.Domain.Entities;
using SM.Demo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Demo.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(Author author)
        {
            var tmp = _dbContext.Authors.FirstOrDefault(x => x.Id == author.Id);
            if (tmp != null)
            {
                _dbContext.Authors.Remove(tmp);
                _dbContext.SaveChanges();
            }
        }

        

        public ICollection<Author> GetAll()
        {
            return _dbContext.Authors.ToList();
        }

        public ICollection<Author> GetByName(string name)
        {
            return _dbContext.Authors.Where(x => x.Name.Contains(name)).ToList();
        }

        public Author Save(Author book)
        {
            _dbContext.Authors.Add(book);
            _dbContext.SaveChanges();
            return book;
        }

        public Author Update(Author book)
        {
            var tmp = _dbContext.Authors.FirstOrDefault(x => x.Id == book.Id);
            if (tmp != null)
            {
                _dbContext.Entry(tmp).CurrentValues.SetValues(book);
                _dbContext.SaveChanges();
                return book;
            }
            return null;
        }
    }
}

