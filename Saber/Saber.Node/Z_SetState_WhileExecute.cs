namespace Saber.Node;

public class WhileExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        WhileExecute node;
        node = arg.Node as WhileExecute;
        node.Cond = arg.Field00 as Operate;
        node.Loop = arg.Field01 as State;
        return true;
    }
}