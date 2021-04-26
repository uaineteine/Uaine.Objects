using System;
using System.Collections.Generic;
using System.Text;

namespace Uaine.Objects.Primitives
{
    public class IDObject
    {
        protected int _id;
        public int ID { get => _id; }
        public IDObject(int id)
        {
            _id = id;
        }
    }
}
