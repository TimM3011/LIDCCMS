using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class Messages
    {
        [Key]
        public int MesId { get; set; }
        public string Address_ { get; set; }
        public string MesBody { get; set; }
        public string MessageFrom { get; set; }
       
        public int fk1_PrioID { get; set; }

        public virtual Priority Priority { get; set; }
        public virtual Notes Note { get; set; }
    }
}