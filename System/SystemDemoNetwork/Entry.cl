class Entry : ModuleEntry
{
    maide precate Int Main()
    {
        var Demo demo;
        demo : new Demo;
        demo.Init();

        demo.Execute();
        return 0;
    }
}