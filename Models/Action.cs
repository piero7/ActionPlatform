using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActionPlatform.Models
{
    public class Action
    {
        [Key]
        public int ActionId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public User Owner { get; set; }


        public List<User> Participants { get; set; }

        public int MaxCount { get; set; }

        public int NowCount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public 

    }
}