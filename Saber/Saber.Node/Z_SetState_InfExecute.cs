namespace Saber.Node;

public class InfExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        InfExecute node;
        node = arg.Node as InfExecute;
        node.Cond = arg.Field00 as Operate;
        node.Then = arg.Field01 as State;
        return true;
    }
}