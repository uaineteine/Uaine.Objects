using System;
using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Primitives
{
    public class HashCode : ByteArray
    {
        public HashCode(byte[] hashBytes) : base(hashBytes)
        {

        }

        public override string ToString()
        {
            return BitConverter.ToString(bytes).Replace("-", string.Empty);
        }

        public string MakePrintString()
        {
            return $"HashCode: {ToString()}";
        }
    }
}
