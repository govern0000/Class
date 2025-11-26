namespace Saber.Node;

public class BitRiteOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BitRiteOperate();
        return true;
    }
}