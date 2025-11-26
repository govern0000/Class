namespace Saber.Node;

public class AddOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        AddOperate node;
        node = arg.Node as AddOperate;
        node.Lite = arg.Field00 as Operate;
        node.Rite = arg.Field01 as Operate;
        return true;
    }
}