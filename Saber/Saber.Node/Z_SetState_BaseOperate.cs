namespace Saber.Node;

public class BaseOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BaseOperate node;
        node = arg.Node as BaseOperate;
        return true;
    }
}