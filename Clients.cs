using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class Clients
    {
        public Clients()
        {
            this.Addresses = new HashSet<Addresses>();
            this.Notes = new HashSet<Notes>();
            this.TelephoneNumbers = new HashSet<TelephoneNumbers>();
        }
        [Key]
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public string Ethinic { get; set; }


        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Notes> Notes { get; set; }    
        public virtual ICollection<TelephoneNumbers> TelephoneNumbers { get; set; }
    }
}