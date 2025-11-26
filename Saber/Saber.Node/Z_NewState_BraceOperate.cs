namespace Saber.Node;

public class BraceOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BraceOperate();
        return true;
    }
}