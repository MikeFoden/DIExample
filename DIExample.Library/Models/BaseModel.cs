using System;

namespace DIExample.Library.Models
{
    public class BaseModel
    {
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual bool IsDeleted
        {
            get
            {
                // Return true if we have deleted this product
                return DateDeleted.HasValue;
            }
        }
    }
}
