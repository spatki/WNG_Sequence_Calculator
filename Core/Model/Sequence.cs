using System;
using System.Collections.Generic;

namespace WNG_Sequences.Core.Model
{
    public abstract class Sequence 
    {
        public string SequenceName { get; set; }        // Friendly name of this sequence
        public string HelpText { get; set; }    // Helptext, as additional information for the user
        public string OutputSequence { get; set; }
        
        public Sequence()
        {
            SequenceName = "Number Sequence";
            HelpText = "Defined sequences till the given number";
            OutputSequence = "";
        }

        // Method takes a string parameter as at this point we are not sure
        // whether the number is a big number or not
        public void GenerateSequence(string strNumber)      
        {
            ulong intNumber;

            // Check for valid number
            if (!IsANumber(strNumber))
            {
                // Return an empty string
                throw new FormatException("Input is not a Number");
            }

            if (ulong.TryParse(strNumber, out intNumber))
            {
                // This number is within the ulong range
                GetSequence(intNumber);
            }
            else
            {
                // This number is a big number
                GetSequenceBigNumber(strNumber);
            }
        }

        public static bool IsANumber(string strNumber)
        {
            foreach (char c in strNumber)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        protected void AddNumber(string number)
        {
            OutputSequence = OutputSequence + (OutputSequence != "" ? ", " : "") + number;
        }

        protected abstract void GetSequence(ulong intNumber);
        protected abstract void GetSequenceBigNumber(string strNumber);
    }
}
