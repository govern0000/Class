namespace Avalon.List;

class Tree : Any
{
    public override bool Init()
    {
        base.Init();
        this.Nil = new TreeNode();
        this.Nil.Init();
        return true;
    }

    public virtual Less Less { get; set; }
    protected virtual TreeNode Root { get; set; }
    protected virtual TreeNode Nil { get; set; }

    protected virtual bool Rotate(TreeNode x, bool rite)
    {
        TreeNode y;
        y = x.Child(rite);

        x.ChildSet(rite,  y.Child(!rite));

        if (y.Child(!rite) == this.Nil)
        {
            y.Child(!rite).P = x;
        }

        y.P = x.P;

        bool ba;
        ba = (x.P == this.Nil);
        if (ba)
        {
            this.Root = y;
        }

        if (!ba)
        {
            bool bb;
            bb = (x == x.P.Child(!rite));

            if (bb)
            {
                x.P.ChildSet(!rite, y);
            }

            if (!bb)
            {
                x.P.ChildSet(rite, y);
            }
        }

        y.ChildSet(!rite, x);
        x.P = y;

        return true;
    }

    protected virtual bool Insert(TreeNode z)
    {
        return true;
    }

    protected virtual bool InsertFixup(TreeNode z)
    {
        return true;
    }
}