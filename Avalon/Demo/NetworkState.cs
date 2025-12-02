namespace Demo;

public class NetworkState : State
{
    public override bool Init()
    {
        base.Init();
        this.TextInfra = TextInfra.This;
        this.NetworkStatusList = NetworkStatusList.This;
        this.NetworkCaseList = NetworkCaseList.This;
        return true;
    }

    public virtual TextInfra TextInfra { get; set; }
    public virtual NetworkStatusList NetworkStatusList { get; set; }
    public virtual NetworkCaseList NetworkCaseList { get; set; }
    public virtual NetworkA Network { get; set; }
    public virtual long Count { get; set; }

    public override bool Execute()
    {
        String hostName;
        hostName = this.S("localhost");
        long hostPort;
        hostPort = 50920;

        NetworkA network;
        network = new NetworkA();
        network.Init();

        network.ThreadState = this;

        network.HostName = hostName;
        network.HostPort = hostPort;

        this.Network = network;

        network.Open();

        ThreadThread thread;
        thread = ThreadThis.This.Thread;

        long o;
        o = thread.ExecuteMain();

        network.Final();

        this.Network = null;
        return true;
    }

    public virtual bool ExitNetwork(long code)
    {
        NetworkA network;
        network = this.Network;

        network.Close();

        string k;
        k = null;
        bool ba;
        ba = (code == 0);
        if (ba)
        {
            k = "Success";
        }
        if (!ba)
        {
            k = "Fail";
        }

        Console.This.Out.Write(this.S("Network " + k + ", code: " + code + "\n"));

        this.Count = this.Count + 1;

        bool b;
        b = (this.Count == 2);

        if (b)
        {
            ThreadThread thread;
            thread = ThreadThis.This.Thread;

            thread.Exit(code);
        }

        if (!b)
        {
            network.Open();
        }
        return true;
    }

    private String S(string o)
    {
        return this.TextInfra.S(o);
    }
}