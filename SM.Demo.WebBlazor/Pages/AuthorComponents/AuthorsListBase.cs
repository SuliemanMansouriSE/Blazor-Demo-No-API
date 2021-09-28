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

        [Inject]
        NavigationManager NavigationManager { get; set; }

        public Guid Id { get; set; }

        
        public IEnumerable<Author> Authors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Authors = await AuthorService.GetAll();
            
        }

        protected async Task HandleDeleteAsync(Guid Id)
        {
            await AuthorService.Delete(Id);
            NavigationManager.NavigateTo($"/AuthorComponents/AuthorsList", true);
        }

    }
}
