﻿
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

        //overrides
        public override string ToString()
        {
            return _id.ToString();
        }
    }
}
