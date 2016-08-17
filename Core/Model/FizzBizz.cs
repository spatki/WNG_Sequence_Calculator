using System;
using System.Collections.Generic;

namespace WNG_Sequences.Core.Model
{
    public class FizzBizz : Sequence
    {
        public FizzBizz()
        {
            SequenceName = "Multiples of 3 & 5";
            HelpText = "All multiples of 3 will appear as C, multiples of 5 will appear as E and multiples of both 3 & 5 will appear as Z";
            OutputSequence = "";
        }

        protected override void GetSequence(ulong intNumber)
        {
            OutputSequence = "";
            for (ulong cnt = 1; cnt <= intNumber; cnt++)
            {
                if ((cnt % 3) == 0)
                {
                    if ((cnt % 5) == 0)
                    {
                        AddNumber("Z"); // Multiples of both 3 & 5 
                    }
                    else
                    {
                        AddNumber("C"); // Multiple of 3 
                    }
                }
                else
                {
                    if ((cnt % 5) == 0)
                    {
                        AddNumber("E"); // Multiple of 5 
                    }
                    else
                    {
                        AddNumber(cnt.ToString());
                    }
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
                    if ((cnt % 3) == 0)
                    {
                        if ((cnt % 5) == 0)
                        {
                            AddNumber("Z"); // Multiples of both 3 & 5 
                        }
                        else
                        {
                            AddNumber("C"); // Multiple of 3 
                        }
                    }
                    else
                    {
                        if ((cnt % 5) == 0)
                        {
                            AddNumber("E"); // Multiple of 5 
                        }
                        else
                        {
                            AddNumber(cnt.ToString());
                        }
                    }
                }
            }
        }

    }
}
