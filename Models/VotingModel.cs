using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoAwards.Models
{
    public class VotingModel : BaseModel
    {

        public string Name { get; set; }

        [Required]
        public Guid UserID { get; set; }

        [Required]
        public Guid? ContestID { get; set; }

        [ForeignKey("ContestID")]
        public ContestModel Contests { get; set; }


    }
}