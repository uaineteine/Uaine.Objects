using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Game.Card
{
    public class Card
    {
        public IValue cardValue;
        public IValue cardClass;

        public Card(int value, int cardclass)
        {
            cardValue = value;
            cardClass = cardclass;
        }
    }
}
