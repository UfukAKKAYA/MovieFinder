using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Logo { get; set; }

        public String Trailer { get; set; }

        public DateTime ProductionTime { get; set; }

        public float Score { get; set; }

        public ICollection<MovieCategory> Categories { get; set; }

        public ICollection<Director> Directors { get; set; }

    }
}
