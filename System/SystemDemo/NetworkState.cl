class NetworkState : StateA
{
    maide prusate Bool Init()
    {
        base.Init();
        this.TextInfra : share TextInfra;
        this.NetworkStatusList : share NetworkStatusList;
        this.NetworkCaseList : share NetworkCaseList;
        return true;
    }

    field prusate TextInfra TextInfra { get { return data; } set { data : value; } }
    field prusate NetworkStatusList NetworkStatusList { get { return data; } set { data : value; } }
    field prusate NetworkCaseList NetworkCaseList { get { return data; } set { data : value; } }
    field prusate NetworkA Network { get { return data; } set { data : value; } }
    field prusate Int Count { get { return data; } set { data : value; } }

    maide prusate Bool Execute()
    {
        var String hostName;
        hostName : "localhost";
        var Int hostPort;
        hostPort : 59843;

        var NetworkA network;
        network : new NetworkA;
        network.Init();

        network.ThreadState : this;

        network.HostName : hostName;
        network.HostPort : hostPort;

        this.Network : network;

        network.Open();

        var Thread thread;
        thread : share ThreadThis.Thread;

        var Int ka;
        ka : thread.ExecuteMain();

        network.Final();

        this.Network : null;

        var String k;

        var Bool b;
        b : (ka = 0);
        inf (b)
        {
            k : "Success";
        }
        inf (~b)
        {
            k : "Fail";
        }

        share Console.Out.Write(this.AddClear().Add("Network ").Add(k).Add(", status: ").Add(this.StringInt(ka)).AddLine().AddResult());
        return true;
    }

    maide prusate Bool ExitNetwork(var Int status)
    {
        this.Network.Close();

        var ThreadThis varThis;
        varThis : new ThreadThis;
        varThis.Init();

        varThis.Thread.Exit(status);
        return true;
    }
}