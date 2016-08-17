using System;
using System.Collections.Generic;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Service
{
    public interface ISequenceService
    {
         List<Sequence> GenerateSequence(string strNumber);
    }
}
