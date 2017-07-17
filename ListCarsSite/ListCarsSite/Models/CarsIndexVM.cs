using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ListCarsSite.Models
{
    public class CarsIndexVM
    {
        [Display(Name = "Car Brand")]
        public string Brand { get; set; }

        //If true, vissa top speed i blå text
        public bool ShowAsFast { get; set; }


    }
}
