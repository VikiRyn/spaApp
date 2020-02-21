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
                },
                new AccommodationViewModel
                {
                    Id = new Guid("61a66928-4b16-4c7f-9434-ee9f3c3fa301"),
                    Name = "2 room apartment with a great garden view",
                    Location = "Oderbruchstraße",
                    NumberOfGuests = 2,
                    Price = 50,
                    Type = "Apartment"
                },
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