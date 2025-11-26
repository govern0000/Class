namespace Saber.Node;

public class WhileExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new WhileExecute();
        return true;
    }
}