namespace Saber.Node;

public class NullOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new NullOperate();
        return true;
    }
}