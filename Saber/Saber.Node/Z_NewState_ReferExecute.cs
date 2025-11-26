namespace Saber.Node;

public class ReferExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new ReferExecute();
        return true;
    }
}