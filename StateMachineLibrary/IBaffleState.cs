
namespace StateMachineLibrary
{
    public interface IBaffleState
    {
        IBaffleState Push();
        IBaffleState Pay();
    }       
}
