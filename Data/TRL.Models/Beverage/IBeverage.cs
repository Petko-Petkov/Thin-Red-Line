namespace TRL.Models.Beverage
{
    public interface IBeverage
    {
        double Size { get; set; }

        decimal Price { get; set; }

        BeverageType Type { get; }

        string ProducerName { get; set; }

        bool IsInPromo { get; set; }

        decimal PromoPrice { get; set; }
    }
}
