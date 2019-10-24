using System;
using System.Collections.Generic;
using System.Linq;

namespace StateMachineLibrary.BaffleGateStates
{
    public class OpenedBaffleGate : IBaffleState
    {
        private IBaffleGateService _baffleService { get; }

        public OpenedBaffleGate(IBaffleGateService baffleService)
        {
            _baffleService = baffleService;
        }

        public IBaffleState Pay() 
        {
            Console.WriteLine("You already payed for this, not charged");
            return this;
        }

        public IBaffleState Push()
        {
            _baffleService.Push();
            Console.WriteLine("Pushed, gate closed");
            return new ClosedBaffleGate(_baffleService);
        }
    }
}
