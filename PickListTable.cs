using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CHDWebApp.Models
{
    public class PickListTable
    {
        [Key]
        public int PickId { get; set; }
        public string PickType { get; set; }
        public string PickValue { get; set; }
        public string NationalCodes { get; set; }
    }
}