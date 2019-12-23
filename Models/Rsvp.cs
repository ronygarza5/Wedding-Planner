using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlaner.Models
{
    public class Rsvp
    {
        [Key]
        public int RsvpId {get;set;}
        public int UserId {get; set;}
        public int WeddingId {get; set;}
        public User Guest {get; set;}
        public Wedding Attending {get; set;}
    }
}