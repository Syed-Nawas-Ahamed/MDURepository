using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Added...
using System.ComponentModel.DataAnnotations;

namespace MDUSampleWebAPI.Models
{
    public class Trainee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Technology { get; set; }
    }
}