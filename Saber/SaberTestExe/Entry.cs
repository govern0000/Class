namespace Saber.Test.Exe;

class Entry
{
    [STAThread]
    static int Main(string[] arg)
    {
        return EntryEntry.Main(new ModuleEntry(), arg);
    }
}