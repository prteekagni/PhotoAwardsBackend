using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoAwards.Models
{
    public class EntryModel : BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public Guid? ContestsID { get; set; }

        public bool? isBoosted {get;set;}

        [ForeignKey("ContestsID")]
        public ContestModel Contests { get; set; }

    }
}