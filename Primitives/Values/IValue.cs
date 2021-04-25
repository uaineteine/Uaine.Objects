namespace Uaine.Objects.Primitives.Values
{
    public class IValue
    {
        public int Value;
        private int _def;
        public int def { get => _def; }

        public IValue(int val)
        {
            Value = val;
            _def = val;
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
    }
}
