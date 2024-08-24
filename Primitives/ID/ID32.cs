
namespace Uaine.Objects.Primitives.ID
{
    public class ID32
    {
        protected int _id;
        public int ID { get => _id; }
        public ID32(int id)
        {
            _id = id;
        }
        public ID32(ID16 id)
        {
            _id = id.ID;
        }

        //operators
        public static implicit operator int(ID32 obj) => obj.ID;
        public static implicit operator ID32(int id) => new ID32(id);
        public static bool operator ==(ID32 left, ID32 right)
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
        public static bool operator !=(ID32 left, ID32 right)
        {
            return !(left == right);
        }
        public static bool operator ==(ID32 left, int right)
        {
            return left == new ID32(right);
        }
        public static bool operator !=(ID32 left, int right)
        {
            return left != new ID32(right);
        }
        public static bool operator ==(int left, ID32 right)
        {
            return right == new ID32(left);
        }
        public static bool operator !=(int left, ID32 right)
        {
            return right != new ID32(left);
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
