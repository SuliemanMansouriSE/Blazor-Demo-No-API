using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SM.Demo.Domain.Entities;
using SM.Demo.Services;

namespace SM.Demo.WebBlazor.Pages.AuthorComponents
{
    public class AuthorsListBase : ComponentBase
    {

        [Inject]
        public IAuthorService AuthorService { get; set; }


        IEnumerable<Author> Authors { get; set; }
        public string Id { get; set; }

        protected override void OnInitialized()
        {
            Authors = AuthorService.GetAll();
        }

    }
}
