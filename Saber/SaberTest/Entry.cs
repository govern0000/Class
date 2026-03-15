namespace Saber.Test;

public class Entry : EntryEntry
{
    protected override long Main()
    {
        Test a;
        a = new Test();
        a.Init();

        long o;
        o = a.Execute();
        return o;
    }
}