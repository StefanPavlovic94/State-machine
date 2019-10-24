
using System;

namespace StateMachineLibrary.BaffleGateStates
{
    public class ClosedBaffleGate : IBaffleState
    {
        private IBaffleGateService _baffleService { get; }

        public ClosedBaffleGate(IBaffleGateService baffleService)
        {
            _baffleService = baffleService;
        }

        public IBaffleState Pay()
        {
            var paymentSucceded = _baffleService.Pay();
            
            if (!paymentSucceded)
            {
                Console.WriteLine("Payment failed, gate will be closed until you pay");
                return this;
            }

            Console.WriteLine("Payment succedded");
            return new OpenedBaffleGate(_baffleService);
        }

        public IBaffleState Push() 
        {
            Console.WriteLine("Can not pass until you pay");
            return this;
        }
    }

}
