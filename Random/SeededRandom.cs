using System;

namespace Uaine.Objects.Random
{
    public class SeededRandom : System.Random
    {
        protected string seedString;
        public string getSeed => seedString;
        protected int seedInt;
        public int getSeedAsInt => seedInt;

        public SeededRandom(string seed) : base(seed.GetHashCode())
        {
            seedString = seed;
            seedInt = seed.GetHashCode();
        }
    }
}