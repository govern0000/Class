namespace Saber.Node;

public class ValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Value node;
        node = arg.Node as Value;
        return true;
    }
}