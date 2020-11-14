using System;
using System.Collections.Generic;
using System.Text;

namespace Withinnan
{
    class PlayerStats
    {
        protected bool _passCheck = false;

        //Initialize the player's stats
        protected int _playerStrength = 0;
        protected int _playerIntelligence = 0;
        protected int _playerCharisma = 0;

        Random random = new Random();

        //Get and set functions for each stat
        public int GetStrength()
        {
            return _playerStrength;
        }

        public void SetStrength(int strength)
        {
            _playerStrength = (_playerStrength + strength);
        }

        public int GetIntelligence()
        {
            return _playerIntelligence;
        }

        public void SetIntelligence(int intelligence)
        {
            _playerIntelligence = (_playerIntelligence + intelligence);
        }

        public int GetCharisma()
        {
            return _playerCharisma;
        }

        public void SetCharisma(int charisma)
        {
            _playerCharisma = (_playerCharisma + charisma);
        }

        public bool GetPassCheck()
        {
            return _passCheck;
        }

        public void CheckStrength()
        {
            //If the player has no bonus added to their strength score
            if (_playerStrength == 0)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 1
                if (randomNumber == 1)
                {
                    //Player passes the check
                    _passCheck = true;
                }

                //Otherwise
                else
                {
                    //Player fails check
                    _passCheck = false;
                }
            }

            //If the player has a bonus of 30 added to their strength score
            else if (_playerStrength == 30)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 1, 2, or 3
                if (randomNumber == 1 || randomNumber == 2 || randomNumber == 3)
                {
                    //Player passes the check
                    _passCheck = true;
                }

                //Otherwise
                else
                {
                    //Player fails check
                    _passCheck = false;
                }
            }

            //If the player has a bonus of 30 added to their strength score
            else if (_playerStrength == 60)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 7, 8, 9, or 10
                if (randomNumber == 7 || randomNumber == 8 || randomNumber == 9 || randomNumber == 10)
                {
                    //Player fails check
                    _passCheck = false;
                }

                //Otherwise
                else
                {
                    //Player passes the check
                    _passCheck = true;
                }
            }

            //If the player has a bonus of 90 added to their strength score
            else if (_playerStrength == 90)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the random number is 10
                if (randomNumber == 10)
                {
                    //Player fails the check
                    _passCheck = false;
                }

                //Otherwise
                else
                {
                    //Player passes check
                    _passCheck = true;
                }
            }

            //If the player has a bonus of 100 or more added to their strength score
            else if (_playerStrength >= 100)
            {
                //Player passes the check
                _passCheck = true;
            }
        }

        public void CheckIntelligence()
        {
            //If the player has no bonus added to their intelligence score
            if (_playerIntelligence == 0)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 1
                if (randomNumber == 1)
                {
                    //Player passes the check
                    _passCheck = true;
                }

                //Otherwise
                else
                {
                    //Player fails check
                    _passCheck = false;
                }
            }

            //If the player has a bonus of 30 added to their intelligence score
            else if (_playerIntelligence == 30)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 1, 2, or 3
                if (randomNumber == 1 || randomNumber == 2 || randomNumber == 3)
                {
                    //Player passes the check
                    _passCheck = true;
                }

                //Otherwise
                else
                {
                    //Player fails check
                    _passCheck = false;
                }
            }

            //If the player has a bonus of 30 added to their intelligence score
            else if (_playerIntelligence == 60)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 7, 8, 9, or 10
                if (randomNumber == 7 || randomNumber == 8 || randomNumber == 9 || randomNumber == 10)
                {
                    //Player fails check
                    _passCheck = false;
                }

                //Otherwise
                else
                {
                    //Player passes the check
                    _passCheck = true;
                }
            }

            //If the player has a bonus of 90 added to their intelligence score
            else if (_playerIntelligence == 90)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the random number is 10
                if (randomNumber == 10)
                {
                    //Player fails the check
                    _passCheck = false;
                }

                //Otherwise
                else
                {
                    //Player passes check
                    _passCheck = true;
                }
            }

            //If the player has a bonus of 100 or more added to their intelligence score
            else if (_playerIntelligence >= 100)
            {
                //Player passes the check
                _passCheck = true;
            }
        }

        public void CheckCharisma()
        {
            //If the player has no bonus added to their charisma score
            if (_playerCharisma == 0)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 1
                if (randomNumber == 1)
                {
                    //Player passes the check
                    _passCheck = true;
                }

                //Otherwise
                else
                {
                    //Player fails check
                    _passCheck = false;
                }
            }

            //If the player has a bonus of 30 added to their charisma score
            else if (_playerCharisma == 30)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 1, 2, or 3
                if (randomNumber == 1 || randomNumber == 2 || randomNumber == 3)
                {
                    //Player passes the check
                    _passCheck = true;
                }

                //Otherwise
                else
                {
                    //Player fails check
                    _passCheck = false;
                }
            }

            //If the player has a bonus of 30 added to their charisma score
            else if (_playerCharisma == 60)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the generated number is 7, 8, 9, or 10
                if (randomNumber == 7 || randomNumber == 8 || randomNumber == 9 || randomNumber == 10)
                {
                    //Player fails check
                    _passCheck = false;
                }

                //Otherwise
                else
                {
                    //Player passes the check
                    _passCheck = true;
                }
            }

            //If the player has a bonus of 90 added to their charisma score
            else if (_playerCharisma == 90)
            {
                //Produce a random number between 1 and 10
                int randomNumber = random.Next(1, 11);

                //If the random number is 10
                if (randomNumber == 10)
                {
                    //Player fails the check
                    _passCheck = false;
                }

                //Otherwise
                else
                {
                    //Player passes check
                    _passCheck = true;
                }
            }

            //If the player has a bonus of 100 or more added to their charisma score
            else if (_playerCharisma >= 100)
            {
                //Player passes the check
                _passCheck = true;
            }
        }
    }
}
