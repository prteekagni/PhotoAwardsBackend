using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoAwards.Models
{
    public class ContestModel : BaseModel
    {
        public string Title {get;set;}
        public string Description {get;set;}
        public int Prize {get;set;}
        public bool isActive {get;set;}
        public DateTime EndsOn {get;set;}

    }
}