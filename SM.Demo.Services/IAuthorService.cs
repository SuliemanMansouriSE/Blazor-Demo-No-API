using SM.Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Demo.Services
{
    public interface IAuthorService
    {
         Task<Author> Save(Author author);
         Task Delete(Guid Id);
         Task<Author> Update(Author author);
         Task<ICollection<Author>> GetByName(string name);
         Task<ICollection<Author>> GetAll();
         Task<Author> GetById(Guid guid);
    }
}
