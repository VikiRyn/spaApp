using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SpaApp.BL.Contracts;
using SpaApp.Domain.PocoEntities;
using SpaApp.Web.ViewModels;

namespace SpaApp.Web.Controllers
{
    [Route("api/accommodations")]
    public class AccommodationController : ApiControllerBase
    {
        private IAccommodationService _accommodationService;

        public AccommodationController(
            IMapper mapper,
            IAccommodationService accommodationService) 
            : base(mapper)
        {
            _accommodationService = accommodationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var models = await _accommodationService.GetAllAsync();
            var viewModels = Mapper.Map<IEnumerable<AccommodationViewModel>>(models);

            return Ok(viewModels);
        }

        [HttpGet("id:Guid", Name = nameof(AccommodationController.GetById))]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var model = await _accommodationService.GetByIdAsync(id);
            var viewModel = Mapper.Map<AccommodationViewModel>(model);

            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AccommodationViewModel viewModel)
        {
            var model = Mapper.Map<Accommodation>(viewModel);
            var createdModel = await _accommodationService.AddAsync(model);
            var createdViewModel = Mapper.Map<AccommodationViewModel>(createdModel);

            return CreatedAtRoute(
                nameof(AccommodationController.GetById),
                new { id = createdViewModel.Id },
                createdViewModel);
        }

        [HttpPut("id:Guid")]
        public async Task<IActionResult> Update([FromBody] AccommodationViewModel viewModel)
        {
            var model = Mapper.Map<Accommodation>(viewModel);
            var updatedModel = await _accommodationService.UpdateAsync(model);
            var updatedViewModel = Mapper.Map<AccommodationViewModel>(updatedModel);

            return Ok(updatedViewModel);
        }

        [HttpDelete("id:Guid")]
        public async Task<IActionResult> Delete([FromRoute]Guid id)
        {
            await _accommodationService.DeleteAsync(id);

            return NoContent();
        }
    }
}