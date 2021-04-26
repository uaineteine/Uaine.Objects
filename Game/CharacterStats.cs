using System;
using System.Collections.Generic;
using System.Text;

namespace Uaine.Objects.Game
{
    public class CharacterStats : BaseStats
    {
        float XP;
        int Level;

        public void LevelUp()
        {
            Level += 1;
        }
    }
}
