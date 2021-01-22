using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieProOfficial.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Founded Date")]
        public DateTime FoundedDate { get; set; }
        public decimal BoxOfficeRevenue { get; set; }

        //Children
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
