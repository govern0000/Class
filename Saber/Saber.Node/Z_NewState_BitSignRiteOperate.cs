namespace Saber.Node;

public class BitSignRiteOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BitSignRiteOperate();
        return true;
    }
}