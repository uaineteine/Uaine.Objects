using System;

namespace Uaine.Objects.Primitives.Values
{
    public class IValue
    {
        public int Value;
        protected int _def;
        public int def { get => _def; }

        public IValue(int val)
        {
            Value = val;
            _def = val;
        }
        public IValue(int val, int def)
        {
            Value = val;
            _def = def;
        }

        public void ResetToDefault()
        {
            Value = _def;
        }
        public void NewDefault(int defaul)
        {
            _def = defaul;
        }
        public void NewDefaultAndSet(int defaul)
        {
            NewDefault(defaul);
            ResetToDefault();
        }

        public static implicit operator IValue(int v)
        {
            return new IValue(v);
        }
    }
}
