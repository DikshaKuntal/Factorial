using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FactorialCalculation.Models
{
    public class Factorial
    {
        [Required(ErrorMessage ="Enter valid numbers")]
        [Range(0,int.MaxValue,ErrorMessage = "Only positive number allowed")]
        [Display(Name = "Number")]
        public int Number { get; set; }
        
        public double? Result { get; set; }
           
    }
}