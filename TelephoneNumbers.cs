using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CHDWebApp.Models
{
    public class TelephoneNumbers
    {
        [Key]
        public int TeleId { get; set; }
        public string TeleNumber { get; set; }
        public string TeleType { get; set; }
       
        public int fk1_ProID { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual Clients Client { get; set; }
        public virtual Users User { get; set; }
    }
}