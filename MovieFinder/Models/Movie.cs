using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public String NameTr { get; set; }

        public String NameEN { get; set; }

        public String LogoUrl { get; set; }

        public String TrailerUrl { get; set; }

        [Range(1800, 2099)]
        public int ProductionYear { get; set; }

        [Range(0, 10)]
        public Single Score { get; set; }

        public String DescriptionTR { get; set; }

        public String DescriptionEN { get; set; }

        public Director Director { get; set; }

        public ICollection<MovieCategory> Categories { get; set; }

    }
}
