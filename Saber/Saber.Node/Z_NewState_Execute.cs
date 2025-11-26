namespace Saber.Node;

public class ExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Execute();
        return true;
    }
}