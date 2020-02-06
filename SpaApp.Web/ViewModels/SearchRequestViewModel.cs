using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaApp.Web.ViewModels
{
    public class SearchRequestViewModel : ViewModelBase
    {
        public string Where { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Guests { get; set; }
    }
}
