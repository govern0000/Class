namespace Saber.Node;

public class OrnOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new OrnOperate();
        return true;
    }
}