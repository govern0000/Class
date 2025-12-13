class PathInn : StringInn
{
    maide prusate Bool Init()
    {
        base.Init();
        this.PathIntern : share PathIntern;
        return true;
    }

    field private PathIntern PathIntern { get { return data; } set { data : value; } }

    maide prusate String Read()
    {
        this.PathIntern.Phore.Open();

        var String k;
        k : base.Read();

        this.PathIntern.Phore.Close();

        return k;
    }
}