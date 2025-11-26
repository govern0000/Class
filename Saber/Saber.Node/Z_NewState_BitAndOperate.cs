namespace Saber.Node;

public class BitAndOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BitAndOperate();
        return true;
    }
}