using System;

namespace NAIKE.DomainEntities
{
    public class Sample
    {
        public Guid Id { get; }
        public string DnaSequence { get; }
        public DateTime AnalysisTime { get; }

        public Sample(Guid id, string dnaSequence, DateTime analysisTime)
        {
            Id = id;
            DnaSequence = dnaSequence;
            AnalysisTime = analysisTime;
        }
    }
}
