using System;
using System.Collections.Generic;
using System.Text;

namespace Uaine.Objects.Primitives
{
    public class NamedObject
    {
        protected string _name;
        public string Name { get => _name; }

        public NamedObject(string name)
        {
            _name = name;
        }
    }
}
