namespace Avalon.Console;

class PathOut : StringOut
{
    public override bool Write(String value)
    {
        Intern.This.Phore.Open();

        base.Write(value);

        Intern.This.Phore.Close();
        return true;
    }
}