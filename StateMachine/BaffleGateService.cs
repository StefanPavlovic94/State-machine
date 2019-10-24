using StateMachineLibrary;
using System;

namespace StateMachine
{
    public class BaffleGateService : IBaffleGateService
    {
        public bool Pay()
        {
            Random randomNumberGenerator = new Random();

            var randomNumber = randomNumberGenerator.Next(0, 101);

            if (randomNumber % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public void Push()
        {
        }
    }
}
