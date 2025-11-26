namespace Saber.Node;

public class StateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new State();
        return true;
    }
}