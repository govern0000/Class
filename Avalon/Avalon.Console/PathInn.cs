namespace Avalon.Console;

class PathInn : StringInn
{
    public override bool Init()
    {
        base.Init();
        this.PathIntern = PathIntern.This;
        return true;
    }

    private PathIntern PathIntern { get; set; }

    public override String Read()
    {
        this.PathIntern.Phore.Open();

        String k;
        k = base.Read();

        this.PathIntern.Phore.Close();

        return k;
    }
}