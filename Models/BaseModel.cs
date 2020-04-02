using System;
using System.ComponentModel.DataAnnotations;

namespace PhotoAwards.Models
{
    public class BaseModel
    {
        public Guid ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }
}