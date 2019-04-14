using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace RecipesBlog.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Calories { get
            {
                return (this.Carbs * 4) + (this.Proteins * 4) + (this.Fats * 9); 
            }
        }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddDate { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}