using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldCountries.Models
{
    public class City:Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Street> Streets { get; set; }
        public City()
        {
            Streets = new List<Street>();
        }
    }
}
