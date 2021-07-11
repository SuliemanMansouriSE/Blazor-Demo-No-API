using SM.Demo.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Demo.Services
{
    public interface IBookService
    {
        public Book Save(Book book);
        public void Delete(Book book);
        public Book Update(Book book);
        public Book GetByISBN(string isbn);
        public ICollection<Book> GetByTitle(string title);
        public ICollection<Book> GetAll();
    }
}
