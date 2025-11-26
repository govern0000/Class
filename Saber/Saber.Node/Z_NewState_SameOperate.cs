namespace Saber.Node;

public class SameOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new SameOperate();
        return true;
    }
}