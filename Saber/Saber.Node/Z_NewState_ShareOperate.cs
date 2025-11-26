namespace Saber.Node;

public class ShareOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new ShareOperate();
        return true;
    }
}