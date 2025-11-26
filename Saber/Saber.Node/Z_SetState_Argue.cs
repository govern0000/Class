namespace Saber.Node;

public class ArgueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Argue node;
        node = arg.Node as Argue;
        node.Value = arg.Field00 as Array;
        return true;
    }
}