using NUnit.Framework;

using NAIKE.DomainEntities.Extensions;

namespace NAIKE.Test
{
    public class ValidSequenceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NullIsNotAValidSequence()
        {
            string s = null;

            Assert.IsFalse(s.IsValidDnaSequence());
        }
        [Test]
        public void EmptyIsNotAValidSequence()
        {
            string s = "";

            Assert.IsFalse(s.IsValidDnaSequence());
        }
        [Test]
        public void DifferentSizeIsNotAValidSequence()
        {
            string s = "123";

            Assert.IsFalse(s.IsValidDnaSequence());
        }

        [Test]
        public void InvalidCharIsInvalid()
        {
            Assert.IsFalse('0'.IsValidDnaChar());
        }
        [Test]
        public void ValidCharIsValid()
        {
            Assert.IsTrue('A'.IsValidDnaChar());
        }
        [Test]
        public void LowercaseValidCharIsValid()
        {
            Assert.IsTrue('t'.IsValidDnaChar());
        }



        [Test]
        public void InvaldCharsIsNotAValidSequence()
        {
            string s = "0TGCGGGTAAATCGCC_INVALID_CCGCAGAACTTAGGAGCCAGGGGGA"
                     + "GGTCTAATTAGGTTAAGGGAGTAAGTCCTCGGATGGTTCAGTTGTAACCA"
                     + "TATACTTACGCTGGAACTTCTCCGGCGAATTTTTACTGTCACCAACCACG"
                     + "AGATTTGAGGTAAACCAATTGAGCACATAGTCGCGCTATCCGACAATCTC"
                     + "CAAATTATAACATACCGTTCCATGAAGGCCAGAGTTACTTACCGGCCCTT"
                     + "TCCATGCGCGCGCCATACCCCCCCAGTTCCCCGGTTATCTCTCCGAGGAG"
                     + "AGAGTGAGCGATCCTCCGTTAACATATTCTTACGTATGACGTAGCTATGT"
                     + "ATTTTGCAGAGGTAGCGAACGGGTTTGACACTTCACAGATAGTGGGGATC"
                     + "CGGGCAAAGGGCGTATAATTGCGGTCCAACATAGGCGTAAACTACGATGG"
                     + "CACCAACTCAGTCGCAGCTCGTGCGCCGTGAATAACGTACTCATCCCAAC"
                     + "TGATTCTCGGCAATCTACGGAGCGACATGATTATCAACAGCTGTCTAGCA"
                     + "GTTCTAATCTTTTGCCATCGTCGTAAAAGCCTCCAAGAGATTGATCATAC"
                     + "CTATCGGCACAGAAGTGACACGACGCCGATGGGTAGCGGACTTTTGGTCA"
                     + "ACCACAATTCGCTAGGGGACAGGTCCTGCGGCGTACATCACTTTGTATGT"
                     + "GCAACCAGCCCAAGTGGGGCCAGGCAAGACTCAGCTGGTTCCTGTGTTAG"
                     + "CTCGAGGCTAGGGATGACAGCTCTTTAAACATAGGCTGGGGGCGTCGAAC"
                     + "GGTCGAGAAGCTCATAGTACCTCGGGTACCAACTTACTCAGGCTATTGCT"
                     + "TGAAGCTGTACTATTTCAGGGGGGGAGCGCTGATGGTCTCTTCTTCTGAT"
                     + "GACTCAACTCGCAAGGGTCGTGAAGTCGGTTCCTTCAATGGTTAAAAATC"
                     + "AAAGGCTCACTGTGCAGACTGGAGCGCCCATCTAGCGGCTCGCGTCTCGA";


            Assert.IsFalse(s.IsValidDnaSequence());
        }

        [Test]
        public void ValidSequenceIsValid()
        {
            string s = "TTGCGGGTAAATCGCCGACCGCAGAACTTAGGAGCCAGGGGGAACAGATA"
                     + "GGTCTAATTAGGTTAAGGGAGTAAGTCCTCGGATGGTTCAGTTGTAACCA"
                     + "TATACTTACGCTGGAACTTCTCCGGCGAATTTTTACTGTCACCAACCACG"
                     + "AGATTTGAGGTAAACCAATTGAGCACATAGTCGCGCTATCCGACAATCTC"
                     + "CAAATTATAACATACCGTTCCATGAAGGCCAGAGTTACTTACCGGCCCTT"
                     + "TCCATGCGCGCGCCATACCCCCCCAGTTCCCCGGTTATCTCTCCGAGGAG"
                     + "AGAGTGAGCGATCCTCCGTTAACATATTCTTACGTATGACGTAGCTATGT"
                     + "ATTTTGCAGAGGTAGCGAACGGGTTTGACACTTCACAGATAGTGGGGATC"
                     + "CGGGCAAAGGGCGTATAATTGCGGTCCAACATAGGCGTAAACTACGATGG"
                     + "CACCAACTCAGTCGCAGCTCGTGCGCCGTGAATAACGTACTCATCCCAAC"
                     + "TGATTCTCGGCAATCTACGGAGCGACATGATTATCAACAGCTGTCTAGCA"
                     + "GTTCTAATCTTTTGCCATCGTCGTAAAAGCCTCCAAGAGATTGATCATAC"
                     + "CTATCGGCACAGAAGTGACACGACGCCGATGGGTAGCGGACTTTTGGTCA"
                     + "ACCACAATTCGCTAGGGGACAGGTCCTGCGGCGTACATCACTTTGTATGT"
                     + "GCAACCAGCCCAAGTGGGGCCAGGCAAGACTCAGCTGGTTCCTGTGTTAG"
                     + "CTCGAGGCTAGGGATGACAGCTCTTTAAACATAGGCTGGGGGCGTCGAAC"
                     + "GGTCGAGAAGCTCATAGTACCTCGGGTACCAACTTACTCAGGCTATTGCT"
                     + "TGAAGCTGTACTATTTCAGGGGGGGAGCGCTGATGGTCTCTTCTTCTGAT"
                     + "GACTCAACTCGCAAGGGTCGTGAAGTCGGTTCCTTCAATGGTTAAAAATC"
                     + "AAAGGCTCACTGTGCAGACTGGAGCGCCCATCTAGCGGCTCGCGTCTCGA";

            Assert.IsTrue(s.IsValidDnaSequence());
        }
        [Test]
        public void MixedCaseSequenceIsValid()
        {
            string s = "TTGCGGGTAaatcgcCGACCGCAGAACTTAGGAGCCAGGGGGAACAGATA"
                     + "GGTCTAATTAGGTTAAGGGAGTAAGTCCTCGGATGGTTCAGTTGTAACCA"
                     + "TATACTTACGCTGGAACTTCTCCGGCGAATTTTTACTGTCACCAACCACG"
                     + "AGATTTGAGGTAAACCAATtgagCACATAGTCGCGCTATCCGACAATCTC"
                     + "CAAATTATAACATACCGTTCCATGAAGGCCAGAGTTACTTACCGGCCCTT"
                     + "TCCATGCGCGCGCCATACCCCCCCAGTTCCCCGGTTATCTCTCCGAGGAG"
                     + "AGAGTGAGCGATCCTCCGTTAACATATTCTTACGTATGACGTAGCTATGT"
                     + "ATTTTGCAGAGGTAGCGAACGGGTTTGACACTTCACAGATAGTGGGGATC"
                     + "CGGGCAAAGGGCGTATAATTGCGGTCCAACATAGGCGTAAACTACGATGG"
                     + "CACCAACTCAGTCGCAGCTCGTGCGCCGTGAATAACGTACTCATCCCAAC"
                     + "TGATTCTCGGCAATCTACGGAGCGACATGATTATCAACAGCTGTCTAGCA"
                     + "GTTCTAATCTTTTGCCATCGTCGTAAAAGCCTCCAAGAGATTGATCATAC"
                     + "CTATCGGCACAGAAGTGACACGACGCCGATGGGTAGCGGACTTTTGGTCA"
                     + "ACCACAATTCGCTAGGGGACAGGTCCTGCGGCGTACATCACTTTGTATGT"
                     + "GCAACCAGCCCAAGTGGGGCCAGGCAAGACTCAGCTGGTTCCTGTGTTAG"
                     + "CTCGAGGCTAGGGATGACAGCTCTTTAAACATAGGCTGGGGGCGTCGAAC"
                     + "GGTCGAGAAGCTCATAGTACCTCGGGTACCAACTTACTCAGGCTATTGCT"
                     + "TGAAGCTGTACTATTTCAGGGGGGGAGCGCTGATGGTCTCTTCTTCTGAT"
                     + "GACTCAACTCGCAAGGGTCGTGAAGTCGGTTCCTTCAATGGTTAAAAATC"
                     + "AAAGGCTCACTGTGCAGACTGGAGCGCCCATCTAGCGGCTCGCGTCTCGA";

            Assert.IsTrue(s.IsValidDnaSequence());
        }
        [Test]
        public void LowerCaseSequenceIsValid()
        {
            string s = "ttgcgggtaaatcgccgaccgcagaacttaggagccagggggaacagata"
                     + "ggtctaattaggttaagggagtaagtcctcggatggttcagttgtaacca"
                     + "tatacttacgctggaacttctccggcgaatttttactgtcaccaaccacg"
                     + "agatttgaggtaaaccaattgagcacatagtcgcgctatccgacaatctc"
                     + "caaattataacataccgttccatgaaggccagagttacttaccggccctt"
                     + "tccatgcgcgcgccatacccccccagttccccggttatctctccgaggag"
                     + "agagtgagcgatcctccgttaacatattcttacgtatgacgtagctatgt"
                     + "attttgcagaggtagcgaacgggtttgacacttcacagatagtggggatc"
                     + "cgggcaaagggcgtataattgcggtccaacataggcgtaaactacgatgg"
                     + "caccaactcagtcgcagctcgtgcgccgtgaataacgtactcatcccaac"
                     + "tgattctcggcaatctacggagcgacatgattatcaacagctgtctagca"
                     + "gttctaatcttttgccatcgtcgtaaaagcctccaagagattgatcatac"
                     + "ctatcggcacagaagtgacacgacgccgatgggtagcggacttttggtca"
                     + "accacaattcgctaggggacaggtcctgcggcgtacatcactttgtatgt"
                     + "gcaaccagcccaagtggggccaggcaagactcagctggttcctgtgttag"
                     + "ctcgaggctagggatgacagctctttaaacataggctgggggcgtcgaac"
                     + "ggtcgagaagctcatagtacctcgggtaccaacttactcaggctattgct"
                     + "tgaagctgtactatttcagggggggagcgctgatggtctcttcttctgat"
                     + "gactcaactcgcaagggtcgtgaagtcggttccttcaatggttaaaaatc"
                     + "aaaggctcactgtgcagactggagcgcccatctagcggctcgcgtctcga";

            Assert.IsTrue(s.IsValidDnaSequence());
        }
    }
}
