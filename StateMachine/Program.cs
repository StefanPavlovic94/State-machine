using StateMachineLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var baffleMachineService = new BaffleGateService();

            var baffleGateStateMachine = new BaffleStateMachine(baffleMachineService);

            baffleGateStateMachine.Push();
            baffleGateStateMachine.Pay();
            baffleGateStateMachine.Pay();
            baffleGateStateMachine.Pay();
            baffleGateStateMachine.Pay();
            baffleGateStateMachine.Pay();
            baffleGateStateMachine.Pay();
            baffleGateStateMachine.Push();
            baffleGateStateMachine.Push();

            Console.ReadKey();
        }
    }
}
