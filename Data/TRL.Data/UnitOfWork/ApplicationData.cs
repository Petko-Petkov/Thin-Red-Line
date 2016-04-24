namespace TRL.Data.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using TRL.Contracts.Repository;
    using TRL.Models;
    using TRL.Models.Event;
    using TRL.Models.Beverage;

    public class ApplicationData : IApplicationData
    {
        private DbContext context;
        private IDictionary<Type, object> repostitoris;

        public ApplicationData()
            :this(new ApplicationDbContext())
        {

        }

        public ApplicationData(DbContext context)
        {
            this.context = context;
            this.repostitoris = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<AlcoholBeverage> AlcoholBeverages
        {
            get
            {
                return this.GetRepository<AlcoholBeverage>();
            }
        }

        public IRepository<NonAlcoholBeverage> NonAlcoholBeverages
        {
            get
            {
                return this.GetRepository<NonAlcoholBeverage>();
            }
        }

        public IRepository<Coctail> Coctails
        {
            get
            {
                return this.GetRepository<Coctail>();
            }
        }


        public IRepository<Event> NonAlcoholBeverage
        {
            get
            {
                return this.GetRepository<Event>();
            }
        }


        private IRepository<T> GetRepository<T>() where T : class
        {
            var typofRepository = typeof(T);

            if (!this.repostitoris.ContainsKey(typofRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(Repository<T>), context);
                this.repostitoris.Add(typofRepository, newRepository);
            }

            return (IRepository<T>)this.repostitoris[typofRepository];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
