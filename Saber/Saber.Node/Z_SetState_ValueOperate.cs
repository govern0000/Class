namespace Saber.Node;

public class ValueOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        ValueOperate node;
        node = arg.Node as ValueOperate;
        node.Value = arg.Field00 as Value;
        return true;
    }
}