using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhotoAwards.Models
{
    public class UserModel : BaseModel
    {
        [Required]
        public string Name { get; set; }
        
        public string Logo { get; set; }
        public bool? isFav { get; set; }

        public string Url { get; set; }

        public string BrandType {get;set;}

    }
}