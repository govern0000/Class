namespace Saber.Node;

public class CastOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        CastOperate node;
        node = arg.Node as CastOperate;
        node.Class = arg.Field00 as ClassName;
        node.Any = arg.Field01 as Operate;
        return true;
    }
}