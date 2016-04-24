namespace TRL.Contracts.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class BaseModel : IAuditInfo, IDeletableEntity
    {
        protected BaseModel()
        {
            this.CreatedOn = DateTime.Now;
        }

        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Specifies whether or not the CreatedOn property should be automatically set.
        /// </summary>
        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
