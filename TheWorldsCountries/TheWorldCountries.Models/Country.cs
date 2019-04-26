using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldCountries.Models
{
    public class Country:Entity
    {
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }
    }
}
