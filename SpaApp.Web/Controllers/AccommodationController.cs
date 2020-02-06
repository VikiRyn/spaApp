using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SpaApp.Web.ViewModels;

namespace SpaApp.Web.Controllers
{
    [Route("api/accommodations")]
    public class AccommodationController : ApiControllerBase
    {
        private List<AccommodationViewModel> viewModels;

        public AccommodationController(IMapper mapper) : base(mapper)
        {
            viewModels = new List<AccommodationViewModel>
            {
                new AccommodationViewModel
                {
                    Id = new Guid("36d26980-1692-4a06-a50d-b50ee5cbd400"),
                    Name = "Nice and spacious 3 room apartment",
                    Location = "Italy Rome Guseppe Str",
                    NumberOfGuests = 3,
                    Price = 75,
                    Type = "Whole Apartment"
                }
            };
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(viewModels);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var viewModel = viewModels.Find(vm => vm.Id == id);
            return Ok(viewModel);
        }
    }
}