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
        public string displayName { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string city { get; set; }

        public string gender { get; set; }
        
        public string profileImage { get; set; }

        public int credits { get; set; }

        public string loggedVia { get; set; }

        public bool isprofileCompleted {get;set;}

    }
}