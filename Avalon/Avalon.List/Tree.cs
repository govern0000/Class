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
    protected virtual TreeNode Nil { get; set; }
}