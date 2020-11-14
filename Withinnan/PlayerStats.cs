using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class PlayerStats
    {
        protected int _playerStrength = 0;
        protected int _playerIntelligence = 0;
        protected int _playerCharisma = 0;

        public int GetStrength()
        {
            return _playerStrength;
        }

        public void SetStrength(int strength)
        {
            _playerStrength += strength;
        }

        public int GetIntelligence()
        {
            return _playerIntelligence;
        }

        public void SetIntelligence(int intelligence)
        {
            _playerIntelligence += intelligence;
        }

        public int GetCharisma()
        {
            return _playerCharisma;
        }

        public void SetCharisma(int charisma)
        {
            _playerCharisma += charisma;
        }
    }
}
