namespace Saber.Node;

public class MaideNameNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new MaideName();
        return true;
    }
}