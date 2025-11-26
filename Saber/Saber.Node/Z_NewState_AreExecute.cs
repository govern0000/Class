namespace Saber.Node;

public class AreExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new AreExecute();
        return true;
    }
}