using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ScriptureId { get; set; }

        [Required]
        public string Book { get; set; }

        [Range(1, 140)]
        [Required]
        public int Chapter { get; set; }

        [Range(1, 140)]
        [Required]
        public int Verse { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Passage { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Comments { get; set; }
    }
}
