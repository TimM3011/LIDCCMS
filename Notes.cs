using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CHDWebApp.Models
{
    public class Notes
    {
        public Notes()
        {
            this.Messages = new HashSet<Messages>();
        }
        [Key]
        public int NotesId { get; set; }
        public string C_NotesSummary { get; set; }
        public byte[] timesaved { get; set; }
        public System.DateTime DateRecorded { get; set; }
        
        public int fk1_ClientID { get; set; }
       
        public int fk2_UserID { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Users User { get; set; }
        
        public virtual ICollection<Messages> Messages { get; set; }
    }
}