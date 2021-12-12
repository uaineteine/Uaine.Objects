
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

        //overrides
        public override string ToString()
        {
            return _id.ToString();
        }
    }
}
