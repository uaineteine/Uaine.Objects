
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
    }
}
