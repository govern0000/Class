namespace SaberDocueExe;

class Entry
{
    [STAThread]
    static int Main(string[] arg)
    {
        return EntryEntry.Main(new ModuleEntry(), arg);
    }
}