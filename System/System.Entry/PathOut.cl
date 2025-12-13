class PathOut : StringOut
{
    maide prusate Bool Init()
    {
        base.Init();
        this.PathIntern : share PathIntern;
        return true;
    }

    field private PathIntern PathIntern { get { return data; } set { data : value; } }

    maide prusate Bool Write(var String value)
    {
        this.PathIntern.Phore.Open();

        base.Write(value);

        this.PathIntern.Phore.Close();
        return true;
    }
}