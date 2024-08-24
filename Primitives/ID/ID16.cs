
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
        public static implicit operator ID16(short id) => new ID16(id);
        public static bool operator ==(ID16 left, ID16 right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (left is null || right is null)
            {
                return false;
            }
            return left._id == right._id;
        }
        public static bool operator !=(ID16 left, ID16 right)
        {
            return !(left == right);
        }
        public static bool operator ==(ID16 left, short right)
        {
            return left == new ID16(right);
        }
        public static bool operator !=(ID16 left, short right)
        {
            return left != new ID16(right);
        }
        public static bool operator ==(short left, ID16 right)
        {
            return right == new ID16(left);
        }
        public static bool operator !=(short left, ID16 right)
        {
            return right != new ID16(left);
        }

        //overrides
        public override string ToString()
        {
            return _id.ToString();
        }


        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
    }
}
