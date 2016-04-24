namespace TRL.Models.Beverage
{
    using System.ComponentModel.DataAnnotations;
    using TRL.Contracts.Models;

    public class NonAlcoholBeverage : BaseModel, IBeverage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public double Size { get; set; }

        public BeverageType Type
        {
            get
            {
                return BeverageType.NonAlcohol;
            }
        }

        public NonAlcoholType NonAlcoholType { get; set; }

        public string ProducerName { get; set; }

        public bool IsInPromo { get; set; }

        public decimal PromoPrice { get; set; }
    }
}
