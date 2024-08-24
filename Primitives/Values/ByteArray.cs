
using Newtonsoft.Json;
using System.Collections;
using System;

namespace Uaine.Objects.Primitives.Values
{
    public class ByteArray
    {
        public byte[] bytes { get; }


        public ByteArray(byte[] byts)
        {
            bytes = byts;
        }

        public bool Equals(ByteArray obj)
        {
            return bytes.Equals(obj.bytes);
        }

        public static bool operator ==(ByteArray left, ByteArray right)
        {
            if (ReferenceEquals(left, null))
                return ReferenceEquals(right, null);

            return left.Equals(right);
        }

        public static bool operator !=(ByteArray left, ByteArray right)
        {
            return !(left == right);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ByteArray FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ByteArray>(json);
        }
    }
}
