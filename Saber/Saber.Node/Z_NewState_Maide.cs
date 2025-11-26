namespace Saber.Node;

public class MaideNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Maide();
        return true;
    }
}