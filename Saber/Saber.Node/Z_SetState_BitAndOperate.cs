namespace Saber.Node;

public class BitAndOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BitAndOperate node;
        node = arg.Node as BitAndOperate;
        node.Lite = arg.Field00 as Operate;
        node.Rite = arg.Field01 as Operate;
        return true;
    }
}