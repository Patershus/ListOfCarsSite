using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListCarsSite.Models
{
    public class CarsCreateVM
    {
        [Required]
        [Display(Name ="Make")]
        public string Brand { get; set; }

        [Required]
        [Range(3,5,ErrorMessage ="Your car needs to have between 3 and 5 doors")]
        public int  Doors { get; set; }

        [Required(ErrorMessage = "Insert top speed")]
       
        public int TopSpeed { get; set; }
    }
}
