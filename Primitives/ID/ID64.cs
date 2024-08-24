
namespace Uaine.Objects.Primitives.ID
{
    public class ID64
    {
        protected long _id;
        public long ID { get => _id; }
        public ID64(long id)
        {
            _id = id;
        }

        //operators
        public static implicit operator long(ID64 obj) => obj.ID;
        public static implicit operator ID64(long id) => new ID64(id);
        public static bool operator ==(ID64 left, ID64 right)
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
        public static bool operator !=(ID64 left, ID64 right)
        {
            return !(left == right);
        }
        public static bool operator ==(ID64 left, long right)
        {
            return left == new ID64(right);
        }
        public static bool operator !=(ID64 left, long right)
        {
            return left != new ID64(right);
        }
        public static bool operator ==(long left, ID64 right)
        {
            return right == new ID64(left);
        }
        public static bool operator !=(long left, ID64 right)
        {
            return right != new ID64(left);
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
