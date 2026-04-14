namespace Avalon.List;

class TreeNode : Any
{
    public virtual TreeNode P { get; set; }
    public virtual TreeNode Lite { get; set; }
    public virtual TreeNode Rite { get; set; }
    public virtual bool Color { get; set; }
    public virtual object Index { get; set; }
    public virtual object Value { get; set; }

    public virtual TreeNode Child(bool rite)
    {
        TreeNode a;
        a = this.Lite;

        if (rite)
        {
            a = this.Rite;
        }

        return a;
    }

    public virtual bool ChildSet(bool rite, TreeNode value)
    {
        if (!rite)
        {
            this.Lite = value;
        }

        if (rite)
        {
            this.Rite = value;
        }

        return true;
    }
}