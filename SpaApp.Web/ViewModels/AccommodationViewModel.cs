using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaApp.Web.ViewModels
{
    public class AccommodationViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int NumberOfGuests { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
