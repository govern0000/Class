namespace Saber.Node;

public class CompSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Comp node;
        node = arg.Node as Comp;
        return true;
    }
}