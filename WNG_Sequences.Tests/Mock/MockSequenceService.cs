using System;
using System.Collections.Generic;
using WNG_Sequences.Service;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Tests.Mock
{
    public class MockSequenceService : ISequenceService
    {
        public List<Sequence> GenerateSequence(string strNumber)
        {
            return new List<Sequence>();
        }
    }
}
