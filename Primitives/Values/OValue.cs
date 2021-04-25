using System;

namespace Uaine.Objects.Primitives.Values
{
    public class OValue
    {
        public Type type { get; set; }
        public object Value;
        private object _def;
        public object def { get => _def; }

        public OValue(Type t, object val)
        {
            type = t;
            Value = val;
            _def = val;
        }

        public OValue(object val)
        {
            Value = val;
            type = val.GetType();
            _def = val;
        }

        public void ResetToDefault()
        {
            Value = _def;
        }
        public void NewDefault(object defaul)
        {
            type = defaul.GetType();
            _def = defaul;
        }
        public void NewDefaultAndSet(object defaul)
        {
            NewDefault(defaul);
            ResetToDefault();
        }
    }
}
