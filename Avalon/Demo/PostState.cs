namespace Demo;

class PostState : State
{
    public virtual Demo Demo { get; set; }    

    public override bool Execute()
    {
        ThreadThread thread;
        thread = ThreadThis.This.Thread;
        thread.Exit(0x89f6);

        Console console;
        console = Console.This;
        console.Out.Write(this.Demo.S("PostState.Execute Aaa\n"));
        return true;
    }
}