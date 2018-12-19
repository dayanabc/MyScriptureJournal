using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [Range(1, 170)]
        [Required]
        public int Chapter { get; set; }

        [Required]
        public int Verse { get; set; }

        public string Notes { get; set; }
    }
}
