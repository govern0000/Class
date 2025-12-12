namespace Avalon.Console;

class PathInn : StringInn
{
    public override String Read()
    {
        PathIntern.This.Phore.Open();

        String k;
        k = base.Read();

        PathIntern.This.Phore.Close();

        return k;
    }
}