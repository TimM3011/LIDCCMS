using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CHDWebApp.Models
{
    public class Priority
    {
        
        public Priority()
        {
            this.Messages = new HashSet<Messages>();
        }
        [Key]
        public int PrioId { get; set; }
        public string priCode { get; set; }
        public string Urgency { get; set; }

        
        public virtual ICollection<Messages> Messages { get; set; }
    }
}