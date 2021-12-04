using System;
using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Game
{
    public class Die
    {
        protected IValue Min;
        protected IValue Max;
        protected System.Random rand;

        public Die(IValue min, IValue max)
        {
            Min = min;
            Max = max;
            rand = new System.Random();
        }

        public int Roll(int modifier)
        {
            int roll = rand.Next(Min.Value, Max.Value) + modifier;
            return Math.Max(0, roll);
        }
        public int Roll() { return Roll(0); } //assume 0 mod 

        public int PolyRoll(int nrolls, int modifier)
        {
            int s = 0;
            for (int i = 0; i < nrolls; i++)
            {
                s += Roll(modifier);
            }
            return s;
        }
        public int PolyRoll(int nrolls) { return PolyRoll(nrolls, 0); } //assume 0 mod 
    }
}
