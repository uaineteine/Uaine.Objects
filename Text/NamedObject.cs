namespace Uaine.Objects.Text
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
