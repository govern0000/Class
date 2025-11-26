namespace Saber.Node;

public class PrusateCountSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        PrusateCount node;
        node = arg.Node as PrusateCount;
        return true;
    }
}