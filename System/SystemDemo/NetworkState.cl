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
        return true;
    }

    maide prusate Bool ExitNetwork(var Int status)
    {
        var NetworkA network;
        network : this.Network;

        network.Close();

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

        share Console.Out.Write(this.AddClear().Add("Network ").Add(k).Add(", status: ").Add(this.StringInt(status)).AddLine().AddResult());

        var ThreadThis varThis;
        varThis : new ThreadThis;
        varThis.Init();

        varThis.Thread.Exit(status);
        return true;
    }
}