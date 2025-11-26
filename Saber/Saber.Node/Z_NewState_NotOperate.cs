namespace Saber.Node;

public class NotOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new NotOperate();
        return true;
    }
}