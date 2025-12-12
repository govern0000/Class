namespace Avalon.Console;

public class PathOut : StringOut
{
    public override bool Init()
    {
        base.Init();
        this.PathIntern = PathIntern.This;
        return true;
    }

    private PathIntern PathIntern { get; set; }

    public override bool Write(String value)
    {
        this.PathIntern.Phore.Open();

        base.Write(value);

        this.PathIntern.Phore.Close();
        return true;
    }
}