using System;
using System.Collections.Generic;
using WNG_Sequences.WebUI.Models;
using System.ComponentModel.DataAnnotations;

namespace WNG_Sequences.WebUI.Models
{
    public class UserInput
    {
        [Required(ErrorMessage="Pl. enter a number")]
        [Display(Name="Number")]
        [ValidNumberAttribute]
        public string InputNumber { get; set; }
        public bool CustomValidation { get; set; }
        public string CustomValidationMessage { get; set; }
    }

    public class Sequences
    {
        public string SequenceName { get; set; }
        public string HelpText { get; set; }
        public List<string> OutputSequence { get; set; }
    }

    public class NumberSequencesOutput
    {
        public UserInput InputNumber { get; set; }
        public List<Sequences> NumberSequence { get; set; }
    }
}
