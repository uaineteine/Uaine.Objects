using Newtonsoft.Json; // Assuming you're using Newtonsoft.Json for serialization

namespace Uaine.Objects.Primitives
{

    public class HashCode
    {
        public int KeyValue { get; }

        public HashCode(int keyValue)
        {
            KeyValue = keyValue;
        }

        public override int GetHashCode()
        {
            return KeyValue.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            HashCode otherKey = (HashCode)obj;
            return KeyValue == otherKey.KeyValue;
        }

        public override string ToString()
        {
            return $"HashCode: {KeyValue}";
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static HashCode FromJson(string json)
        {
            return JsonConvert.DeserializeObject<HashCode>(json);
        }
    }
}
