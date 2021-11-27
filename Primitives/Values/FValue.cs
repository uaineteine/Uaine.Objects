namespace Uaine.Objects.Primitives.Values
{
    public class FValue
    {
        public float Value;
        protected float _def;
        public float def { get => _def; }

        public FValue(float val)
        {
            Value = val;
            _def = val;
        }
        public FValue(float val, float def)
        {
            Value = val;
            _def = def;
        }

        public void ResetToDefault()
        {
            Value = _def;
        }
        public void NewDefault(float defaul)
        {
            _def = defaul;
        }
        public void NewDefaultAndSet(float defaul)
        {
            NewDefault(defaul);
            ResetToDefault();
        }

        public static implicit operator FValue(float v)
        {
            return new FValue(v);
        }
    }
}
