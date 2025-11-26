namespace Saber.Node;

public class VarOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        VarOperate node;
        node = arg.Node as VarOperate;
        node.Var = arg.Field00 as VarName;
        return true;
    }
}