namespace Saber.Node;

public class OperateExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        OperateExecute node;
        node = arg.Node as OperateExecute;
        node.Any = arg.Field00 as Operate;
        return true;
    }
}