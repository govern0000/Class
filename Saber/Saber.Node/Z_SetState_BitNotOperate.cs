namespace Saber.Node;

public class BitNotOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BitNotOperate node;
        node = arg.Node as BitNotOperate;
        node.Value = arg.Field00 as Operate;
        return true;
    }
}