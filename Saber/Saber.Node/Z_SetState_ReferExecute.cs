namespace Saber.Node;

public class ReferExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        ReferExecute node;
        node = arg.Node as ReferExecute;
        node.Var = arg.Field00 as Var;
        return true;
    }
}