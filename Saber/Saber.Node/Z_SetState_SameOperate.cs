namespace Saber.Node;

public class SameOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        SameOperate node;
        node = arg.Node as SameOperate;
        node.Lite = arg.Field00 as Operate;
        node.Rite = arg.Field01 as Operate;
        return true;
    }
}