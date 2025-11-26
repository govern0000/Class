namespace Saber.Node;

public class NewOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        NewOperate node;
        node = arg.Node as NewOperate;
        node.Class = arg.Field00 as ClassName;
        return true;
    }
}