namespace Saber.Node;

public class VarMarkSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        VarMark node;
        node = arg.Node as VarMark;
        node.Var = arg.Field00 as VarName;
        return true;
    }
}