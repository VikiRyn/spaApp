using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SpaApp.Web.ViewModels;

namespace SpaApp.Web.Controllers
{
    [Route("api/search-requests/")]
    public class SearchRequestController : ApiControllerBase
    {
        private List<SearchRequestViewModel> viewModels;

        public SearchRequestController(IMapper mapper) : base(mapper)
        {
            viewModels = new List<SearchRequestViewModel>
            {
                new SearchRequestViewModel
                {
                    Id = new Guid("3a1c058f-f81b-4c3c-ba97-0cbff5268c15"),
                    CheckIn = new DateTime(2019, 10, 10),
                    CheckOut = new DateTime(2019, 10, 20),
                    Guests = 3
                }
            };
        }

        [HttpPost]
        public async Task<IActionResult> Create(SearchRequestViewModel model)
        {
            viewModels.Add(model);

            return CreatedAtRoute("SearchRequest", 
                new { searchRequestId = model.Id },
                model);
        }
    }
}