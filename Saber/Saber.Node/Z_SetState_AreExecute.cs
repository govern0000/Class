namespace Saber.Node;

public class AreExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        AreExecute node;
        node = arg.Node as AreExecute;
        node.Mark = arg.Field00 as Mark;
        node.Value = arg.Field01 as Operate;
        return true;
    }
}