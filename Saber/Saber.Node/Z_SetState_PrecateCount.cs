namespace Saber.Node;

public class PrecateCountSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        PrecateCount node;
        node = arg.Node as PrecateCount;
        return true;
    }
}