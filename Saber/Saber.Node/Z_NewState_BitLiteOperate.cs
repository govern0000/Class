namespace Saber.Node;

public class BitLiteOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BitLiteOperate();
        return true;
    }
}