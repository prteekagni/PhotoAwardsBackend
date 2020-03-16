using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhotoAwards.Models
{
    public class VotingsModel : BaseModel
    {
        
        public string Name { get; set; }
    
         [Required]
        public Guid UserID {get;set;}
    
         [Required]
        public Guid? ContestsID { get; set; }

        [ForeignKey("ContestsID")]
        public ContestsModel Contests { get; set; }


    }
}