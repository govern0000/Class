class Rand : Any
{
    maide prusate Bool Init()
    {
        base.Init();
        this.Extern : share Extern;

        var Extern extern;
        extern : this.Extern;

        this.Intern : extern.Rand_New();
        extern.Rand_Init(this.Intern);
        return true;
    }

    maide prusate Bool Final()
    {
        var Extern extern;
        extern : this.Extern;

        extern.Rand_Final(this.Intern);
        extern.Rand_Delete(this.Intern);
        return true;
    }

    field private Extern Extern { get { return data; } set { data : value; } }
    field private Int Intern { get { return data; } set { data : value; } }

    field prusate Int Seed
    {
        get
        {
            var Int k;
            k : this.Extern.Rand_SeedGet(this.Intern);
            var Int a;
            a : k;
            return a;
        }
        set
        {
            var Int k;
            k : value;
            this.Extern.Rand_SeedSet(this.Intern, k);
        }
    }

    maide prusate Int Execute()
    {
        var Int k;
        k : this.Extern.Rand_Execute(this.Intern);
        var Int a;
        a : k;
        return a;
    }
}