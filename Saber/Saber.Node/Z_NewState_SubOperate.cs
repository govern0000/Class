namespace Saber.Node;

public class SubOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new SubOperate();
        return true;
    }
}