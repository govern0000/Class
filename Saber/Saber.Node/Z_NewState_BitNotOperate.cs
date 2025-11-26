namespace Saber.Node;

public class BitNotOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BitNotOperate();
        return true;
    }
}