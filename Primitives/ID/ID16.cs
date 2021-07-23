
namespace Uaine.Objects.Primitives.ID
{
    public class ID16
    {
        protected short _id;
        public short ID { get => _id; }
        public ID16(short id)
        {
            _id = id;
        }

        //operators
        public static implicit operator ID32(ID16 obj) => new ID32(obj);
        public static implicit operator short(ID16 obj) => obj.ID;
    }
}
