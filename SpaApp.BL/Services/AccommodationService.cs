using ApsApp.DAL;
using ApsApp.DAL.Entities;
using SpaApp.BL.Contracts;
using SpaApp.Domain.PocoEntities;

namespace SpaApp.BL.Services
{
    public class AccommodationService : EntitiyService<AccommodationDal, Accommodation>, IAccommodationService
    {
        public AccommodationService(
            IEntityRepository<AccommodationDal> accommodationRepository) 
            : base(accommodationRepository)
        {

        }
    }
}
