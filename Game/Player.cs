using Uaine.Objects.Primitives;

namespace Uaine.Objects.Game
{
    public class Player : IDObject
    {
        Character playerChar;
        public Player(Character playercharacter, int id) : base(id)
        {
            playerChar = playercharacter;
        }
    }
}
