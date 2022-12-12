using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public enum CategoryType    
    {
        Adventure,
        Comedy,
        Drama,
        Horror,
        Romance,
        ScienceFiction
    }
    public class Category
    {
        public int Id { get; set; }

        public CategoryType Type { get; set; }

        public ICollection<MovieCategory> MovieCategories { get; set; }

    }
}
