using System;
using System.ComponentModel.DataAnnotations;

namespace DW.MW.Entities
{
    public class Dealer
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Dealer Name")]
        public string Name { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Year of Establishment")]
        public DateTime YearOfEstablishment { get; set; }
    }
}
