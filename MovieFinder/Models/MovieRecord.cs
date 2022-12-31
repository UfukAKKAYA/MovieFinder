using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public class MovieRecord
    {
        public Movie Movie { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
