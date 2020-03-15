using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhotoAwards.Models
{
    public class Contests
    {
       [Required]
       public string Title {get;set;}
       [Required]
       public string Description {get;set;}

       public bool isActive {get;set;}

       public DateTime? EndOn { get; set;}

       public DateTime? StartOn { get; set;}
    }
}