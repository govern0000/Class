namespace Avalon.Console;

class Intern : Any
{
    public static Intern This { get; } = ShareCreate();

    private static Intern ShareCreate()
    {
        Intern share;
        share = new Intern();
        Any a;
        a = share;
        a.Init();
        return share;
    }
}