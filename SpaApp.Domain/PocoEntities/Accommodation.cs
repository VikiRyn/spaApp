using System;
using System.Collections.Generic;
using System.Text;

namespace SpaApp.Domain.PocoEntities
{
    public class Accommodation : ModelBase
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int NumberOfGuests { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
