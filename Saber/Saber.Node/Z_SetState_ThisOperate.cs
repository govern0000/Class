namespace Saber.Node;

public class ThisOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        ThisOperate node;
        node = arg.Node as ThisOperate;
        return true;
    }
}