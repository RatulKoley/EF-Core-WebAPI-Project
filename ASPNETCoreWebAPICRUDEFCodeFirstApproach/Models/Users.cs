﻿using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreWebAPICRUDEFCodeFirstApproach.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
