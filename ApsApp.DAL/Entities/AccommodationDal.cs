using System;
using System.Collections.Generic;
using System.Text;

namespace ApsApp.DAL.Entities
{
    public class AccommodationDal : EntityBase
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int NumberOfGuests { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
