namespace Saber.Node;

public class BitOrnOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BitOrnOperate();
        return true;
    }
}