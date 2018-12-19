using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHDWebApp.Models
{
    public class AccessGenTokens
    {
        [Key]
        public int Id { get; set; }
        public int fk1_UserID { get; set; }
        [ForeignKey("Tokenizer")]
        public int TokenID { get; set; }

        public virtual Users User { get; set; }
        public virtual Tokenizer Tokenizer { get; set; }
    }
}