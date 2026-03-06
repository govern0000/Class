namespace Avalon.Infra;

public class IntLess : Less
{
    public override bool Init()
    {
        base.Init();
        this.LessInt = new LessInt();
        this.LessInt.Init();
        return true;
    }

    protected virtual LessInt LessInt { get; set; }

    public override long Execute(object lite, object rite)
    {
        Value liteValue;
        Value riteValue;
        liteValue = lite as Value;
        riteValue = rite as Value;

        long k;
        k = this.LessInt.Execute(liteValue.Int, riteValue.Int);

        return k;
    }
}