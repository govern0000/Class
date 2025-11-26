namespace Saber.Node;

public class PronateCountSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        PronateCount node;
        node = arg.Node as PronateCount;
        return true;
    }
}