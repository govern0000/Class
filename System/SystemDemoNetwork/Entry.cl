class Entry : ModuleEntry
{
    maide precate Int ExecuteMain()
    {
        var NetworkState state;
        state : new NetworkState;
        state.Init();

        state.Execute();
        return 0;
    }
}