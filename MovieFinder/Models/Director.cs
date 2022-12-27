using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public class Director
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String SurName { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
