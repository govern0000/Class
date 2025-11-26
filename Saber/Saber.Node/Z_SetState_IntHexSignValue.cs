namespace Saber.Node;

public class IntHexSignValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        IntHexSignValue node;
        node = arg.Node as IntHexSignValue;
        node.Value = arg.FieldInt;
        return true;
    }
}