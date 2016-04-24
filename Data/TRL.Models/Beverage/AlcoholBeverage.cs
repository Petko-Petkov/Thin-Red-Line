namespace TRL.Models.Beverage
{
    using System.ComponentModel.DataAnnotations;
    using TRL.Contracts.Models;
    public class AlcoholBeverage : BaseModel, IBeverage
    {
        public AlcoholBeverage(decimal price, double size, string producerName, AlcholType type)
        {
            this.Price = price;
            this.Size = size;
            this.ProducerName = producerName;
            this.AlcoholType = type;
            this.IsInPromo = false;
        }

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
                return BeverageType.Alcohol;
            }
        }

        [Required]
        public AlcholType AlcoholType { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProducerName { get; set; }
        
        public bool IsInPromo { get; set; }

        public decimal PromoPrice { get; set; }
    }
}
