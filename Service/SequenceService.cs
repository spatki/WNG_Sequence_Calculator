using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Service
{
    public class SequenceService : ISequenceService
    {
        protected string _modelNamespace = "WNG_Sequences.Core.Model";

        public List<Sequence> GenerateSequence(string strNumber)
        {
            ValidateNumber(strNumber);
            List<Sequence> returnValue = new List<Sequence>();
            var theList = Assembly.GetAssembly(typeof(WNG_Sequences.Core.Model.Sequence)).GetTypes()
                                  .Where(t => t.Namespace == _modelNamespace)
                                  .ToList();
            foreach (var cls in theList)
            {
                if (cls.Name != "Sequence")
                {
                    Sequence objSequence = (Sequence)Activator.CreateInstance(cls);
                    objSequence.GenerateSequence(strNumber);
                    returnValue.Add(objSequence);
                }
            }
            return returnValue;
        }

        protected void ValidateNumber(string strNumber)
        {
            if (!Sequence.IsANumber(strNumber))
            {
                throw new FormatException("Input is not a Number");
            }
            ulong num;
            if (!ulong.TryParse(strNumber, out num))
            {
                throw new IndexOutOfRangeException("Please enter a number within range 1 to 5000");
            }
            if (num < 1 || num > 5000)
            {
                throw new IndexOutOfRangeException("Please enter a number within range 1 to 5000");
            }
        }

    }
}
