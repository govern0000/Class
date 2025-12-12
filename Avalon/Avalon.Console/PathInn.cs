namespace Avalon.Console;

class PathInn : StringInn
{
    public override String Read()
    {
        Intern.This.Phore.Open();

        String k;
        k = base.Read();

        Intern.This.Phore.Close();

        return k;
    }
}