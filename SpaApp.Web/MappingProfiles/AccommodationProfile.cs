using ApsApp.DAL.Entities;
using AutoMapper;
using SpaApp.Domain.PocoEntities;
using SpaApp.Web.ViewModels;

namespace SpaApp.Web.MappingProfiles
{
    public class AccommodationProfile : Profile
    {
        public AccommodationProfile()
        {
            CreateMap<AccommodationViewModel, Accommodation>();
            CreateMap<Accommodation, AccommodationDal>();
        }
    }
}
