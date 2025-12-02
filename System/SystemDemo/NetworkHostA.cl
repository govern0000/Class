class NetworkHostA : NetworkHost
{
    field prusate Demo Demo { get { return data; } set { data : value; } }
    field prusate NetworkHostState ThreadState { get { return data; } set { data : value; } }

    maide prusate Bool NewPeer()
    {
        var Network network;
        network : this.OpenPeer();
        return true;
    }

    maide precate Network CreatePeer(var Any peer)
    {
        var NetworkB a;
        a : new NetworkB;
        a.HostPeer : peer;
        a.Init();
        a.ThreadState : this.ThreadState;
        return a;
    }
}