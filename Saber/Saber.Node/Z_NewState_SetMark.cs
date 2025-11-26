namespace Saber.Node;

public class SetMarkNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new SetMark();
        return true;
    }
}