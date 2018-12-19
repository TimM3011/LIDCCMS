using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class Addresses
    {
        public Addresses()
        {
            this.Providers = new HashSet<Provider>();
        }
        [Key]
        public int AddressId { get; set; }
        public string firstLine { get; set; }
        public string secondLine { get; set; }
        public int City { get; set; }
        public Nullable<int> Town { get; set; }
        public string postCode { get; set; }
        
        public int fk1_UserID { get; set; }
        
        public int LocId { get; set; }
      
        public int fk3_ClientID { get; set; }

        public virtual Users User { get; set; }
        
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Clients Client { get; set; }
    }
}