namespace Avalon.List;

class Tree : Any
{
    public override bool Init()
    {
        base.Init();
        this.Nil = new TreeNode();
        this.Nil.Init();

        this.Root = this.Nil;
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
        TreeNode y;
        TreeNode x;

        y = this.Nil;
        x = this.Root;

        while (!(x == this.Nil))
        {
            y = x;

            bool ba;
            ba = (this.Less.Execute(z, x) < 0);

            if (ba)
            {
                x = x.Child(false);
            }

            if (!ba)
            {
                x = x.Child(true);
            }
        }

        z.P = y;

        bool bb;
        bb = (y == this.Nil);

        if (bb)
        {
            this.Root = z;
        }
        
        if (!bb)
        {
            bool bc;
            bc = (this.Less.Execute(z, y) < 0);

            if (bc)
            {
                y.ChildSet(false, z);
            }

            if (!bc)
            {
                y.ChildSet(true, z);
            }
        }

        z.ChildSet(false, this.Nil);
        z.ChildSet(true, this.Nil);
        z.Red = true;

        this.InsertFixup(z);
        return true;
    }

    protected virtual bool InsertFixup(TreeNode z)
    {
        while (z.P.Red)
        {
            bool b;
            b = (z.P == z.P.P.Child(false));

            TreeNode y;
            y = z.P.P.Child(b);

            bool bb;
            bb = y.Red;

            if (bb)
            {
                z.P.Red = false;
                y.Red = false;
                z.P.P.Red = true;
                z = z.P.P;
            }

            if (!bb)
            {
                if (z == z.P.Child(b))
                {
                    z = z.P;

                    this.Rotate(z, !b);
                }

                z.P.Red = false;
                z.P.P.Red = true;

                this.Rotate(z.P.P, b);
            }
        }

        this.Root.Red = false;
        return true;
    }

    protected virtual TreeNode Minimum(TreeNode x)
    {
        while (!(x.Child(false) == this.Nil))
        {
            x = x.Child(false);
        }
        return x;
    }

    protected virtual bool Transplant(TreeNode u, TreeNode v)
    {
        bool b;
        b = (u.P == this.Nil);

        if (b)
        {
            this.Root = v;
        }

        if (!b)
        {
            bool ba;
            ba = (u == u.P.Child(false));

            if (ba)
            {
                u.P.ChildSet(false, v);
            }

            if (!ba)
            {
                u.P.ChildSet(true, v);
            }
        }

        v.P = u.P;
        return true;
    }
}