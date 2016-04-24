namespace TRL.Models.Beverage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TRL.Contracts.Models;
    public class Coctail : BaseModel, IBeverage
    {
        public Coctail()
        {
            this.Ingredients = new HashSet<IBeverage>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public BeverageType CoctailType { get; set; }

        [Required]
        public ICollection<IBeverage> Ingredients { get; set; }

        public double Size { get; set; }

        public decimal Price { get;  set;}

        public BeverageType Type { get; set; }

        public string ProducerName { get; set; }

        public bool IsInPromo { get; set; }

        public decimal PromoPrice { get; set; }
    }
}
