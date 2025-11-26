namespace Saber.Node;

public class MulOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new MulOperate();
        return true;
    }
}