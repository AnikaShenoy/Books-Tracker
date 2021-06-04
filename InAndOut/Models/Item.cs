using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5!")]
        public float Rating { get; set; }
        [Required]
        public string Genre { get; set; }
        [DisplayName("Title")]
        [Required]
        public string Title{ get; set; }

    }
}
