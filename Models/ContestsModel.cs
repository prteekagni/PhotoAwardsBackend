using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhotoAwards.Models
{
    public class ContestsModel : BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        
    }
}