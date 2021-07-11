using SM.Demo.Domain.Entities;
using SM.Demo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Demo.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _dbContext;

        public BookService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(Book book)
        {
            var tmp = _dbContext.Books.FirstOrDefault(x=>x.Id == book.Id);
            if (tmp != null)
            {
                _dbContext.Books.Remove(tmp);
                _dbContext.SaveChanges();
            }
        }

        public Book Find(Guid Id)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Id == Id);
            
        }
               
        public ICollection<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }

        public ICollection<Book> GetByTitle(string title)
        {
            return _dbContext.Books.Where(x => x.Title.Contains(title)).ToList();
        }

        public Book Save(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return book;
        }

        public Book Update(Book book)
        {
            var tmp = _dbContext.Books.FirstOrDefault(x => x.Id == book.Id);
            if (tmp != null)
            {
                _dbContext.Entry(tmp).CurrentValues.SetValues(book);
                _dbContext.SaveChanges();
                return book;
            }
            return null;
        }

        Book IBookService.GetByISBN(string isbn)
        {
            return _dbContext.Books.FirstOrDefault(x => x.ISBN == isbn);
        }
    }
}
