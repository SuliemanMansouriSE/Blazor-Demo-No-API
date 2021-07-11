using Microsoft.AspNetCore.Components;
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

        


        
    }
}
