class NetworkHostState : StateA
{
    field prusate NetworkHost Host { get { return data; } set { data : value; } }
    field prusate Int Count { get { return data; } set { data : value; } }

    maide prusate Bool Execute()
    {
        var NetworkPortKindList portKindList;
        portKindList : share NetworkPortKindList;

        var NetworkPort port;
        port : new NetworkPort;
        port.Init();
        port.Kind : portKindList.LocalHost;
        port.Host : 59843;

        var NetworkHostA host;
        host : new NetworkHostA;
        host.Init();
        host.ThreadState : this;

        this.Host : host;

        host.Port : port;

        this.Host.Open();

        var ThreadThis varThis;
        varThis : new ThreadThis;
        varThis.Init();

        var Int ka;
        ka : varThis.Thread.ExecuteMain();

        this.Host.Close();
        this.Host.Final();

        this.Host : null;

        return true;
    }

    maide prusate Bool ExitNetwork(var Int status, var Network peer)
    {
        this.Host.ClosePeer(peer);

        var String k;

        var Bool ba;
        ba : (ka = 0);
        inf (ba)
        {
            k : "Success";
        }
        inf (~ba)
        {
            k : "Fail";
        }

        share Console.Out.Write(this.AddClear().Add("Network Host ").Add(k).Add(", status: ").Add(this.StringInt(ka)).AddLine().AddResult());

        this.Count : this.Count + 1;

        var Bool b;
        b : this.Count = 2;

        inf (b)
        {
            var ThreadThis varThis;
            varThis : new ThreadThis;
            varThis.Init();

            varThis.Thread.Exit(status);
        }
        return true;
    }
}