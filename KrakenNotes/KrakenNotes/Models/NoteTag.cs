using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrakenNotes.Models
{
    public class NoteTag
    {
        public string NoteId { get; set; }
        public Note Note { get; set; }
        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
