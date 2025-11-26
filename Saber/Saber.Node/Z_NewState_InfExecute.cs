namespace Saber.Node;

public class InfExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new InfExecute();
        return true;
    }
}