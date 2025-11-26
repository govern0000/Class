namespace Saber.Node;

public class PartSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Part node;
        node = arg.Node as Part;
        node.Value = arg.Field00 as Array;
        return true;
    }
}