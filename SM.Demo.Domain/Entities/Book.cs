using System.Collections.Generic;

namespace SM.Demo.Domain.Entities
{
    public class Book : BaseEntity
    {
        public Book() : base()
        {
            Authors = new HashSet<Author>();
        }

        public string Title { get; set; }
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public ICollection<Author> Authors { get; set; }

    }
}