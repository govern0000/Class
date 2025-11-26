namespace Saber.Node;

public class CallOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new CallOperate();
        return true;
    }
}