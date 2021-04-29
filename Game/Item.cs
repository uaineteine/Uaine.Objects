using Uaine.Objects.Primitives;

namespace Uaine.Objects.Game
{
    public class Item : NamedObject
    {
        public TextObject Description;
        public BaseStats Stats;
        public Item(string Name, TextObject description, CharacterStats stats) : base(Name)
        {
            Description = description;
            Stats = stats;
        }
    }
}
