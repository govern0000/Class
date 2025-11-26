namespace Saber.Node;

public class OperateExecuteNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new OperateExecute();
        return true;
    }
}