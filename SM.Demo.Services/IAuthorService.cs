using SM.Demo.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Demo.Services
{
    public interface IAuthorService
    {
        public Author Save(Author author);
        public void Delete(Author author);
        public Author Update(Author author);
        public ICollection<Author> GetByName(string name);
        public ICollection<Author> GetAll();
        
    }
}
