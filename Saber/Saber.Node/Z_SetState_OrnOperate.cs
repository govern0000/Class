namespace Saber.Node;

public class OrnOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        OrnOperate node;
        node = arg.Node as OrnOperate;
        node.Lite = arg.Field00 as Operate;
        node.Rite = arg.Field01 as Operate;
        return true;
    }
}