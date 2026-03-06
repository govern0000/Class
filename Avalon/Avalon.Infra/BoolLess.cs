namespace Avalon.Infra;

public class BoolLess : Less
{
    public override bool Init()
    {
        base.Init();
        this.LessBool = new LessBool();
        this.LessBool.Init();
        return true;
    }

    protected virtual LessBool LessBool { get; set; }

    public override long Execute(object lite, object rite)
    {
        Value liteValue;
        Value riteValue;
        liteValue = lite as Value;
        riteValue = rite as Value;

        long k;
        k = this.LessBool.Execute(liteValue.Bool, riteValue.Bool);

        return k;
    }
}