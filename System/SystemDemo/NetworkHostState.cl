class NetworkHostState : StateA
{
    field prusate Demo Demo { get { return data; } set { data : value; } }
    field prusate Int Count { get { return data; } set { data : value; } }

    maide prusate Bool Execute()
    {
        this.Count : 0;

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
        host.Demo : this.Demo;

        this.Demo.Host : host;

        host.Port : port;

        this..Demo.Host.Open();

        var Thread thread;
        thread : share ThreadThis.Thread;

        var Int ka;
        ka : thread.ExecuteMain();

        this.Demo.Host.Close();
        this.Demo.Host.Final();

        this.Demo.Host : null;

        return true;
    }

    maide prusate Bool ExitNetwork(var Int status, var Network peer)
    {
        this.Demo.Host.ClosePeer(peer);

        var String k;

        var Bool ba;
        ba : status = 0;
        inf (ba)
        {
            k : "Success";
        }
        inf (~ba)
        {
            k : "Fail";
        }

        this.Demo.Console.Out.Write(this.AddClear().Add("Network Host ").Add(k).Add(", status: ").Add(this.StringInt(status)).AddLine().AddResult());

        this.Count : this.Count + 1;

        var Bool b;
        b : this.Count = 2;

        inf (b)
        {
            var Thread thread;
            thread : share ThreadThis.Thread;

            thread.Exit(status);
        }
        return true;
    }
}