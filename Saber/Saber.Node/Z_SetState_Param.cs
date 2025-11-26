namespace Saber.Node;

public class ParamSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Param node;
        node = arg.Node as Param;
        node.Value = arg.Field00 as Array;
        return true;
    }
}