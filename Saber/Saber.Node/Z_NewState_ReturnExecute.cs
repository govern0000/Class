namespace Saber.Node;

public class ReturnExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new ReturnExecute();
        return true;
    }
}