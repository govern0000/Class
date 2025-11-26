namespace Saber.Node;

public class ReturnExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        ReturnExecute node;
        node = arg.Node as ReturnExecute;
        node.Result = arg.Field00 as Operate;
        return true;
    }
}