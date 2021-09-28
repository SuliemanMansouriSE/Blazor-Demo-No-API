using Microsoft.AspNetCore.Components;
using SM.Demo.Domain.Entities;
using SM.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Demo.WebBlazor.Pages.AuthorComponents
{
    public partial class AuthorComponentBase : ComponentBase
    {
        [Inject]
        public IAuthorService AuthorService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }
        public string PageHeaderText { get; set; }

        public Author Author { get; set; }

        protected override async Task OnInitializedAsync()
        {
            

            if (Id == null)
            {
                PageHeaderText = "Create Author";
                Author = new Author();

            }
            else
            {
                PageHeaderText = "Edit Author";
                Author = await AuthorService.GetById(Guid.Parse(Id));
                
            }
            

        }

        protected async Task HandleSubmitAsync()
        {
           
            if (Id == null)
            {
                Author = await AuthorService.Save(Author);
            }
            else
            {
                Author = await AuthorService.Update(Author);
            }
            if (Author != null)
            {
                
                NavigationManager.NavigateTo("/AuthorComponents/Author");
            }
        }

        protected async Task HandleDeleteAsync()
        {
            await AuthorService.Delete(Guid.Parse(Id));
            NavigationManager.NavigateTo("/AuthorComponents/AuthorsList", true);
        }

    }
}
