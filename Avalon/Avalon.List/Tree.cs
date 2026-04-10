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

    protected virtual bool Rotate(TreeNode x)
    {
        TreeNode y;
        y = x.Child(true);
        
        x.ChildSet(true,  y.Child(false));

        if (y.Child(false) == this.Nil)
        {
            y.Child(false).P = x;
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
            bb = (x == x.P.Child(false));

            if (bb)
            {
                x.P.ChildSet(false, y);
            }

            if (!bb)
            {
                x.P.ChildSet(true, y);
            }
        }

        y.ChildSet(false, x);
        x.P = y;

        return true;
    }
}