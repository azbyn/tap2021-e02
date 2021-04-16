using System;
using System.Linq;

namespace NAIKE.DomainEntities.Extensions
{
    public static class SampleExtensions
    {
        public static int ValidDnaSize = 1000;
        public static bool HasValidDnaSequence(this Sample sample)
        {
            return IsValidDnaSequence(sample.DnaSequence);
        }
        public static bool IsValidDnaSequence(this string dnaSequence)
        {
            if (dnaSequence == null) return false;
            if (dnaSequence.Length != ValidDnaSize) return false;

            return dnaSequence.Any(c => "ACGT".Contains(char.ToUpper(c)));
        }
    }
}
