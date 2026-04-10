namespace Avalon.List;

class TreeNode : Any
{
    public virtual TreeNode P { get; set; }
    public virtual TreeNode Lite { get; set; }
    public virtual TreeNode Rite { get; set; }
    public virtual bool Red { get; set; }
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
}