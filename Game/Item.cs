using Uaine.Objects.Primitives;

namespace Uaine.Objects.Game
{
    public class Item : NamedObject
    {
        public TextObject Description;
        public BaseStats Stats;
        private int stack;
        public int Stack { get => stack; }
        public void addStack(int number)
        {
            stack += number;
        }
        public Item(string Name, TextObject description, CharacterStats stats) : base(Name)
        {
            Description = description;
            Stats = stats;
        }
    }
}
