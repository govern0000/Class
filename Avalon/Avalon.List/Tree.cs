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

        if (x.P == this.Nil)
        {
            
        }
    }
}