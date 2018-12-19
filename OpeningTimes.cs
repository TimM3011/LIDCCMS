using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CHDWebApp.Models
{
    public class OpeningTimes
    {
        
        public OpeningTimes()
        {
            this.Providers = new HashSet<Provider>();
        }
        [Key]
        public int OpenTId { get; set; }
        public string Opendays { get; set; }
        public string OpenStartTime { get; set; }
        public string OpenCloseTime { get; set; }

        public virtual ICollection<Provider> Providers { get; set; }
    }
}