using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Demo.Domain.Entities
{
    public class Author : BaseEntity
    {
        public Author() : base()
        {
            Books = new HashSet<Book>();
        }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
