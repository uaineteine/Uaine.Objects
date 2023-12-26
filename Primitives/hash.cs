using System;
using System.Collections;
using Newtonsoft.Json;

namespace Uaine.Objects.Primitives
{
    public class HashCode
    {
        public byte[] HashBytes { get; }

        public HashCode(byte[] hashBytes)
        {
            HashBytes = hashBytes ?? throw new ArgumentNullException(nameof(hashBytes));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            HashCode otherHash = (HashCode)obj;
            return StructuralComparisons.StructuralEqualityComparer.Equals(HashBytes, otherHash.HashBytes);
        }

        public override int GetHashCode()
        {
            // Use XOR to create a hash code from the byte array
            return BitConverter.ToInt32(HashBytes, 0) ^ BitConverter.ToInt32(HashBytes, 4) ^ BitConverter.ToInt32(HashBytes, 8);
        }

        public override string ToString()
        {
            return $"HashCode: {BitConverter.ToString(HashBytes).Replace("-", string.Empty)}";
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static HashCode FromJson(string json)
        {
            return JsonConvert.DeserializeObject<HashCode>(json);
        }

        public static bool operator ==(HashCode left, HashCode right)
        {
            if (ReferenceEquals(left, null))
                return ReferenceEquals(right, null);

            return left.Equals(right);
        }

        public static bool operator !=(HashCode left, HashCode right)
        {
            return !(left == right);
        }
    }
}
