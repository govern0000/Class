class PathIntern : Any
{
    maide prusate Bool Init()
    {
        base.Init();
        this.Phore : new Phore;
        this.Phore.InitCount : 1;
        this.Phore.Init();
        return true;
    }

    maide prusate Bool Final()
    {
        this.Phore.Final();
        this.Phore : null;
        return true;
    }

    field prusate Phore Phore { get { return data; } set { data : value; } }
}