class ConsoleOut : Out
{
    field pronate ConsoleIntern Intern { get { return data; } set { data : value; } }
    field pronate Int Stream { get { return data; } set { data : value; } }

    maide prusate Bool Write(var String value)
    {
        this.Intern.Write(this.Stream, value);
        return true;
    }
}