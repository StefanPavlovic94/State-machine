
using StateMachineLibrary.BaffleGateStates;

namespace StateMachineLibrary
{
    public class BaffleStateMachine 
    {
        private IBaffleState _baffleState;

        public BaffleStateMachine(IBaffleGateService baffleService)
        {
            _baffleState = new ClosedBaffleGate(baffleService);
        }

        public void Push() 
        {
            _baffleState = _baffleState.Push();
        }

        public void Pay() 
        {
            _baffleState = _baffleState.Pay();
        }
    }
}
