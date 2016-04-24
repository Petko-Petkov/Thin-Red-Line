namespace TRL.Data.Migrations
{
    using Models.Beverage;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            // TODO Remove in production
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.AlcoholBeverages.Add(new AlcoholBeverage(3.00m, 0.500, "Zagorka", AlcholType.BottledBeer));
            context.AlcoholBeverages.Add(new AlcoholBeverage(3.00m, 0.500, "Stolichno", AlcholType.DraftBeer));
            context.AlcoholBeverages.Add(new AlcoholBeverage(2.00m, 0.300, "Zagorka", AlcholType.DraftBeer));
            context.AlcoholBeverages.Add(new AlcoholBeverage(3.00m, 0.500, "Amstel", AlcholType.BottledBeer));
        }
    }
}
