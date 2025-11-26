namespace Saber.Node;

public class IntHexValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        IntHexValue node;
        node = arg.Node as IntHexValue;
        node.Value = arg.FieldInt;
        return true;
    }
}