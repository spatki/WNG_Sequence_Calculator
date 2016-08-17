using System;
using System.Collections.Generic;

namespace WNG_Sequences.Core.Model
{
    public class Fibonacci : Sequence
    {
        public Fibonacci()
        {
            SequenceName = "Fibonacci Sequence";
            HelpText = "Fibonacci sequence till the number";
            OutputSequence = "";
        }

        protected override void GetSequence(ulong intNumber)
        {
            OutputSequence = "";
            ulong firstNumber = 0;
            ulong secondNumber = 1;
            ulong currentNumber = 1;
            
            // Begin with adding first numbers
            AddNumber(secondNumber.ToString());
            
            while (currentNumber < intNumber)
            {
                currentNumber = firstNumber + secondNumber;
                if (currentNumber <= intNumber)
                {
                    AddNumber(currentNumber.ToString());
                }
                firstNumber = secondNumber;
                secondNumber = currentNumber;
            }
        }

        protected override void GetSequenceBigNumber(string strNumber)
        {
            BigInteger bigNumber = new BigInteger(strNumber, 10);
            OutputSequence = "";
            BigInteger firstNumber = new BigInteger("0",10);
            BigInteger secondNumber = new BigInteger("1",10);
            BigInteger currentNumber = new BigInteger("1",10);
            BigInteger TillNumber = new BigInteger(strNumber,10);

            // Begin with adding first numbers
            AddNumber(secondNumber.ToString());

            // For the rest use big number class
            while (currentNumber < TillNumber)
            {
                currentNumber = firstNumber + secondNumber;
                if (currentNumber <= TillNumber)
                {
                    AddNumber(currentNumber.ToString());
                }
                firstNumber = secondNumber;
                secondNumber = currentNumber;
            }
        }

    }
}
