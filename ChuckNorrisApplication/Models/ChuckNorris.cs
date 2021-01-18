using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Models
{
    public class ChuckNorris
    {
        public string Id { get; set; }
        [Display(Name = "Chuck Norris Fact")]
        public string Value { get; set; }

        [Key]
        public int PkId { get; set; }
    }
}
