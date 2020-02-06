using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace SpaApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        protected IMapper Mapper { get; private set; }

        public ApiControllerBase(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}