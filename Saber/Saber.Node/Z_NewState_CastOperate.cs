namespace Saber.Node;

public class CastOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new CastOperate();
        return true;
    }
}