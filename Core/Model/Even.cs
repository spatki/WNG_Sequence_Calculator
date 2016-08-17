using System;
using System.Collections.Generic;

namespace WNG_Sequences.Core.Model
{
    public class Even : Sequence
    {
        public Even()
        {
            SequenceName = "Even Numbers";
            HelpText = "All even numbers from 1 to the given number";
            OutputSequence = "";
        }

        protected override void GetSequence(ulong intNumber)
        {
            OutputSequence = "";
            for (ulong cnt = 1; cnt <= intNumber; cnt++)
            {
                if ((cnt % 2) == 0)
                {
                    AddNumber(cnt.ToString());
                }
            }
        }

        protected override void GetSequenceBigNumber(string strNumber)
        {
            BigInteger bigNumber = new BigInteger(strNumber, 10);
            OutputSequence = "";

            // Use normal processing for the initial range
            GetSequence(ulong.MaxValue - 1);

            // For the rest use big number class
            for (BigInteger cnt = new BigInteger(ulong.MaxValue.ToString(), 10); cnt <= bigNumber; bigNumber++)
            {
                if ((cnt % 2) == 0)
                {
                    AddNumber(cnt.ToString());
                }
            }
        }

    }
}
