namespace Saber.Node;

public class IntSignValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        IntSignValue node;
        node = arg.Node as IntSignValue;
        node.Value = arg.FieldInt;
        return true;
    }
}