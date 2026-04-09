
namespace Avalon.List;

class LessCompare : Any, ICompare
{
    public virtual Less Less { get; set; }

    public int Compare(object lite, object rite)
    {
        long k;
        k = this.Less.Execute(lite, rite);

        int a;
        a = (int)k;
        return a;
    }
}