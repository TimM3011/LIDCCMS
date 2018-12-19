using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class Provider
    {
        public Provider()
        {
            this.TelephoneNumbers = new HashSet<TelephoneNumbers>();
        }
        [Key]
        public int ProId { get; set; }
        public string Name { get; set; }
        public string PersonInCharge { get; set; }
        public Nullable<int> NumEmp { get; set; }
      
        public int fk1_AddressID { get; set; }
       
        public int fk2_OpenTID { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual OpeningTimes OpeningTime { get; set; }
       
        public virtual ICollection<TelephoneNumbers> TelephoneNumbers { get; set; }
    }
}