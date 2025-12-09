namespace Z.Tool.SourceSpace;

class Entry : EntryEntry
{
    protected override long ExecuteMain()
    {
        SourceSpace k;
        k = new SourceSpace();
        k.Init();

        k.Path = this.Arg.GetAt(0) as String;

        long a;
        a = k.Execute();
        return a;
    }

    [STAThread]
    static int Main(string[] arg)
    {
        return EntryEntry.Main(new Entry(), arg);
    }
}