using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class AccessTable
    {
        [Key]
        public int AccessId { get; set; }
        public bool allowed { get; set; }
        public string Module { get; set; }
        
        public int fk1_UserID { get; set; }

        public virtual Users User { get; set; }
    }
}