using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class Locations
    {
        public Locations()
        {
            this.Addresses = new HashSet<Addresses>();
        }
        [Key]
        public int LocId { get; set; }
        public string locName { get; set; }
        public string locCode { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}