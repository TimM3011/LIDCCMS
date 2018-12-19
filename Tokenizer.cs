using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CHDWebApp.Models
{
    public class Tokenizer
    {
        public Tokenizer()
        {
            this.AccessGenTokens = new HashSet<AccessGenTokens>();
        }
        [Key]
        public int TokenID { get; set; }
        public string token { get; set; }
        public System.DateTime timeGen { get; set; }
        public System.DateTime timeExp { get; set; }
        public bool Used { get; set; }

        
        public virtual ICollection<AccessGenTokens> AccessGenTokens { get; set; }
   
    }
}