class Demo : Any
{
    maide prusate Bool Execute()
    {
        this.WriteInn();
        this.WriteInn();

        share Console.Out.Write("DemoNetwork Start\n");

        var NetworkState state;
        state : new NetworkState;
        state.Init();

        state.Execute();

        share Console.Out.Write("DemoNetwork End\n");
        return true;
    }

    maide private Bool WriteInn()
    {
        var String k;
        k : share Console.Inn.Read();

        share Console.Out.Write("Inn Sta\n");
        share Console.Out.Write(k);
        share Console.Out.Write("\nInn End\n");

        return true;
    }
}