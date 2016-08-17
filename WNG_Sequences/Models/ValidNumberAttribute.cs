using System;
using System.ComponentModel.DataAnnotations;

namespace WNG_Sequences.WebUI.Models
{
    [AttributeUsage(AttributeTargets.Property |   AttributeTargets.Field, AllowMultiple = false)]
    sealed public class ValidNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null || value == "")
            {
                return false;
            }
            foreach (char c in value.ToString())
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return (name + " is not a valid number");
        }
    }
}