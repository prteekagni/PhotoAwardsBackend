using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        [Required]
        public Guid? EntryID { get; set; }

        public int Count {get;set;}

        [ForeignKey("ContestID")]
        public ContestModel Contests { get; set; }


    }
}