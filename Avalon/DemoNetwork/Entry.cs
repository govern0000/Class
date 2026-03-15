namespace DemoNetwork;

class Entry : EntryEntry
{
    protected override long Main()
    {
        Demo demo;
        demo = new Demo();
        demo.Init();
        demo.Execute();
        return 0;
    }

    [STAThread]
    static int Main(string[] arg)
    {
        return EntryEntry.Main(new Entry(), arg);
    }
}