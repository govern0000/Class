namespace Saber.Class;

public class LibraryMake : TextAdd
{
    public override bool Init()
    {
        base.Init();
        this.ListInfra = ListInfra.This;
        this.StorageInfra = StorageInfra.This;
        this.ClassInfra = ClassInfra.This;
        this.StorageComp = StorageComp.This;

        this.MakeLoad = this.CreateMakeLoad();
        this.InitGen = this.CreateInitGen();
        this.BaseGen = this.CreateBaseGen();
        this.CompGen = this.CreateCompGen();
        this.StringGen = this.CreateStringGen();
        this.Gen = this.CreateGen();
        this.ModuleRefGen = this.CreateModuleRefGen();
        this.TModuleRef = this.CreateModuleRef();

        this.SSystemDotInfra = this.S("System.Infra");
        this.SLibrary = this.S("Library");
        this.SC = this.S("c");
        this.SModule = this.S("Module");
        this.SExe = this.S("Exe");
        this.SMain = this.S("Main");
        return true;
    }

    protected virtual LibraryMakeLoad CreateMakeLoad()
    {
        LibraryMakeLoad a;
        a = new LibraryMakeLoad();
        a.Init();
        return a;
    }

    protected virtual LibraryInitGen CreateInitGen()
    {
        LibraryInitGen a;
        a = new LibraryInitGen();
        a.Init();
        return a;
    }

    protected virtual LibraryBaseGen CreateBaseGen()
    {
        LibraryBaseGen a;
        a = new LibraryBaseGen();
        a.Init();
        return a;
    }

    protected virtual LibraryCompGen CreateCompGen()
    {
        LibraryCompGen a;
        a = new LibraryCompGen();
        a.Init();
        return a;
    }

    protected virtual LibraryStringGen CreateStringGen()
    {
        LibraryStringGen a;
        a = new LibraryStringGen();
        a.Init();
        return a;
    }

    protected virtual LibraryGen CreateGen()
    {
        LibraryGen a;
        a = new LibraryGen();
        a.Init();
        return a;
    }

    protected virtual LibraryModuleRefGen CreateModuleRefGen()
    {
        LibraryModuleRefGen a;
        a = new LibraryModuleRefGen();
        a.Init();
        return a;
    }

    protected virtual ModuleRef CreateModuleRef()
    {
        return this.ClassInfra.ModuleRefCreate(null, 0);
    }

    public virtual ModuleRef ModuleRef { get; set; }
    public virtual ModulePort ModulePort { get; set; }
    public virtual BinaryRead BinaryRead { get; set; }
    public virtual String ClassPath { get; set; }
    public virtual long Status { get; set; }
    protected virtual ListInfra ListInfra { get; set; }
    protected virtual StorageInfra StorageInfra { get; set; }
    protected virtual ClassInfra ClassInfra { get; set; }
    protected virtual StorageComp StorageComp { get; set; }
    protected virtual LibraryMakeLoad MakeLoad { get; set; }
    protected virtual LibraryInitGen InitGen { get; set; }
    protected virtual LibraryBaseGen BaseGen { get; set; }
    protected virtual LibraryCompGen CompGen { get; set; }
    protected virtual LibraryStringGen StringGen { get; set; }
    protected virtual LibraryGen Gen { get; set; }
    protected virtual LibraryModuleRefGen ModuleRefGen { get; set; }
    protected virtual ClassModule SystemInfraModule { get; set; }
    protected virtual SystemClass System { get; set; }
    protected virtual String ModuleRefString { get; set; }
    protected virtual BinaryBinary Binary { get; set; }
    protected virtual ClassModule Module { get; set; }
    protected virtual Table BinaryTable { get; set; }
    protected virtual Table ModuleTable { get; set; }
    protected virtual Array InitArray { get; set; }
    protected virtual Array BaseArray { get; set; }
    protected virtual Array CompArray { get; set; }
    protected virtual Array StringArray { get; set; }
    protected virtual String LibraryPath { get; set; }
    protected virtual String ModuleExeText { get; set; }
    protected virtual String GenModuleFoldPath { get; set; }
    protected virtual ModuleRef TModuleRef { get; set; }
    protected virtual String ModuleExeString { get; set; }
    protected virtual long Stage { get; set; }
    protected virtual String SSystemDotInfra { get; set; }
    protected virtual String SLibrary { get; set; }
    protected virtual String SC { get; set; }
    protected virtual String SModule { get; set; }
    protected virtual String SExe { get; set; }
    protected virtual String SMain { get; set; }

    public virtual bool Load()
    {
        this.ModuleExeText = this.StorageInfra.TextRead(this.S("Saber.Class.data/ModuleExe.txt"));

        if (this.ModuleExeText == null)
        {
            return false;
        }

        return true;
    }

    public virtual bool Execute()
    {
        bool b;
        b = this.ExecuteAll();

        this.TModuleRef.Name = null;
        this.SystemInfraModule = null;
        this.System = null;
        this.Binary = null;
        this.Module = null;
        this.BinaryTable = null;
        this.ModuleTable = null;
        this.InitArray = null;
        this.BaseArray = null;
        this.CompArray = null;
        this.StringArray = null;
        this.GenModuleFoldPath = null;
        this.ModuleExeString = null;

        return b;
    }

    protected virtual bool ExecuteAll()
    {
        this.Status = 0;

        bool b;

        b = this.ExecuteModuleLoad();

        if (!b)
        {
            return false;
        }

        this.SystemInfraModuleSet();
        this.SystemSet();
        this.BinarySet();
        this.ModuleSet();

        this.ExecuteInit();

        this.ExecuteBase();

        this.ExecuteComp();

        this.ExecuteString();

        this.LibraryPath = this.AddClear().Add(this.ClassPath).Add(this.TextInfra.PathCombine)
            .Add(this.SLibrary).AddResult();

        this.ModuleRefString = this.ClassInfra.ModuleRefString(this.ModuleRef);

        String genFoldPath;
        genFoldPath = this.S("Saber.Class.data/Gen");

        this.GenModuleFoldPath = this.AddClear().Add(genFoldPath).Add(this.TextInfra.PathCombine)
            .Add(this.ModuleRefString).AddResult();

        this.Stage = 1;

        b = this.StorageComp.FoldCreate(this.GenModuleFoldPath);

        if (!b)
        {
            return this.Error();
        }

        this.Stage = this.Stage + 1;

        b = this.ExecuteClean();
        if (!b)
        {
            return this.Error();
        }

        this.Stage = this.Stage + 1;

        b = this.ExecuteClassSource();
        if (!b)
        {
            return this.Error();
        }

        this.Stage = this.Stage + 1;

        b = this.ExecuteMakeLib();
        if (!b)
        {
            return this.Error();
        }

        if (!(this.Module.Entry == null))
        {
            this.Stage = 10;

            b = this.ExecuteModuleRefString();
            if (!b)
            {
                return this.Error();
            }

            this.Stage = this.Stage + 1;

            b = this.ExecuteModuleExeSource();
            if (!b)
            {
                return this.Error();
            }

            this.Stage = this.Stage + 1;

            b = this.ExecuteMakeExe();
            if (!b)
            {
                return this.Error();
            }
        }

        this.Stage = 20;

        b = this.StorageComp.FoldDelete(this.GenModuleFoldPath);

        if (!b)
        {
            return this.Error();
        }

        return true;
    }

    protected virtual bool ExecuteModuleLoad()
    {
        bool b;

        this.MakeLoad.ModuleRef = this.ModuleRef;
        this.MakeLoad.ModulePort = this.ModulePort;
        this.MakeLoad.BinaryRead = this.BinaryRead;
        this.MakeLoad.ClassPath = this.ClassPath;

        b = this.MakeLoad.Execute();

        long k;
        k = this.MakeLoad.Status;

        this.BinaryTable = this.MakeLoad.BinaryTable;
        this.ModuleTable = this.MakeLoad.ModuleTable;

        this.MakeLoad.ModuleTable = null;
        this.MakeLoad.BinaryTable = null;
        this.MakeLoad.Status = 0;
        this.MakeLoad.ClassPath = null;
        this.MakeLoad.BinaryRead = null;
        this.MakeLoad.ModulePort = null;
        this.MakeLoad.ModuleRef = null;

        if (!b)
        {
            this.Status = 400 + k;
            return false;
        }

        return true;
    }

    protected virtual bool SystemInfraModuleSet()
    {
        this.TModuleRef.Name = this.SSystemDotInfra;
        this.TModuleRef.Ver = 0;

        this.SystemInfraModule = this.ModuleTable.Get(this.TModuleRef) as ClassModule;
        return true;
    }

    protected virtual bool SystemSet()
    {
        this.System = new SystemClass();
        this.System.Init();
        this.System.Any = this.SystemInfraModule.Class.Get(this.S("Any")) as ClassClass;
        this.System.Bool = this.SystemInfraModule.Class.Get(this.S("Bool")) as ClassClass;
        this.System.Int = this.SystemInfraModule.Class.Get(this.S("Int")) as ClassClass;
        this.System.String = this.SystemInfraModule.Class.Get(this.S("String")) as ClassClass;
        return true;
    }

    protected virtual bool BinarySet()
    {
        this.Binary = this.BinaryTable.Get(this.ModuleRef) as BinaryBinary;
        return true;
    }

    protected virtual bool ModuleSet()
    {
        this.Module = this.ModuleTable.Get(this.ModuleRef) as ClassModule;
        return true;
    }

    protected virtual bool ExecuteInit()
    {
        this.InitGen.Module = this.Module;
        this.InitGen.AnyClass = this.System.Any;

        this.InitGen.Execute();

        this.InitArray = this.InitGen.Result;

        this.InitGen.Result = null;
        this.InitGen.AnyClass = null;
        this.InitGen.Module = null;
        return true;
    }

    protected virtual bool ExecuteBase()
    {
        long count;
        count = this.Module.Class.Count;

        Array array;
        array = this.ListInfra.ArrayCreate(count);

        this.BaseArray = array;

        Iter iter;
        iter = this.Module.Class.IterCreate();

        this.Module.Class.IterSet(iter);

        long i;
        i = 0;
        while (i < count)
        {
            iter.Next();

            ClassClass varClass;
            varClass = iter.Value as ClassClass;

            this.BaseGen.Class = varClass;

            this.BaseGen.Execute();

            Array a;
            a = this.BaseGen.Result;

            this.BaseGen.Result = null;
            this.BaseGen.Class = null;

            array.SetAt(i, a);

            i = i + 1;
        }

        return true;
    }

    protected virtual bool ExecuteComp()
    {
        long count;
        count = this.Module.Class.Count;

        Array array;
        array = this.ListInfra.ArrayCreate(count);

        this.CompArray = array;

        Iter iter;
        iter = this.Module.Class.IterCreate();

        this.Module.Class.IterSet(iter);

        long i;
        i = 0;
        while (i < count)
        {
            iter.Next();

            ClassClass varClass;
            varClass = iter.Value as ClassClass;
        
            Array baseArray;
            baseArray = this.BaseArray.GetAt(i) as Array;

            this.CompGen.Class = varClass;
            this.CompGen.BaseArray = baseArray;

            this.CompGen.Execute();

            LibraryComp a;
            a = this.CompGen.Result;

            this.CompGen.Result = null;
            this.CompGen.BaseArray = null;
            this.CompGen.Class = null;

            array.SetAt(i, a);

            i = i + 1;
        }

        return true;
    }

    protected virtual bool ExecuteString()
    {
        this.StringGen.State = this.Binary.State;

        this.StringGen.Execute();

        this.StringArray = this.StringGen.Result;

        this.StringGen.Result = null;
        this.StringGen.State = null;

        return true;
    }

    protected virtual bool ExecuteClean()
    {
        String libFilePath;
        libFilePath = this.AddClear().Add(this.LibraryPath).Add(this.TextInfra.PathCombine).Add(this.ModuleRefString).AddS(".dll").AddResult();

        this.StorageComp.FileDelete(libFilePath);

        String exeFilePath;
        exeFilePath = this.AddClear().Add(this.LibraryPath).Add(this.TextInfra.PathCombine).Add(this.ModuleRefString).AddS(".exe").AddResult();

        this.StorageComp.FileDelete(exeFilePath);

        return true;
    }

    protected virtual bool ExecuteClassSource()
    {
        long count;
        count = this.BaseArray.Count;
        long i;
        i = 0;
        while (i < count)
        {
            Array array;
            array = this.BaseArray.GetAt(i) as Array;

            if (0x100 < array.Count)
            {
                return false;
            }

            i = i + 1;
        }

        this.Gen.Module = this.Module;
        this.Gen.Binary = this.Binary;
        this.Gen.ModuleCount = this.ModuleTable.Count;
        this.Gen.SystemInfraModule = this.SystemInfraModule;
        this.Gen.System = this.System;
        this.Gen.InitArray = this.InitArray;
        this.Gen.BaseArray = this.BaseArray;
        this.Gen.CompArray = this.CompArray;
        this.Gen.StringArray = this.StringArray;

        this.Gen.Execute();

        String k;
        k = this.Gen.Result;

        this.Gen.Result = null;
        this.Gen.StringArray = null;
        this.Gen.CompArray = null;
        this.Gen.BaseArray = null;
        this.Gen.InitArray = null;
        this.Gen.System = null;
        this.Gen.SystemInfraModule = null;
        this.Gen.ModuleCount = 0;
        this.Gen.Binary = null;
        this.Gen.Module = null;

        String fileName;
        fileName = this.AddClear().Add(this.SModule).Add(this.ClassInfra.TextDot).Add(this.SC).AddResult();

        String filePath;
        filePath = this.AddClear().Add(this.GenModuleFoldPath).Add(this.TextInfra.PathCombine).Add(fileName).AddResult();

        bool b;
        b = this.StorageInfra.TextWrite(filePath, k);

        if (!b)
        {
            return false;
        }

        return true;
    }

    protected virtual Array ModuleRefStringArray()
    {
        long count;
        count = this.ModuleTable.Count;

        count = count - 1;

        Array array;
        array = this.ListInfra.ArrayCreate(count);

        Iter iter;
        iter = this.ModuleTable.IterCreate();
        this.ModuleTable.IterSet(iter);

        long i;
        i = 0;
        while (i < count)
        {
            iter.Next();

            ModuleRef k;
            k = iter.Index as ModuleRef;

            String a;
            a = this.ClassInfra.ModuleRefString(k);

            array.SetAt(i, a);

            i = i + 1;
        }

        return array;
    }

    protected virtual bool ExecuteMakeLib()
    {
        return this.ExecuteMake(false);
    }

    protected virtual bool ExecuteMakeExe()
    {
        return this.ExecuteMake(true);
    }

    protected virtual bool ExecuteMake(bool exe)
    {
        Program program;
        program = null;

        ulong ka;
        ka = Extern.Environ_System();

        long kb;
        kb = (long)ka;

        bool b;
        b = (2 < kb & kb < 5);

        if (b)
        {
            program = this.CreateMakeProgramWindows(exe);
        }

        if (!b)
        {
            program = this.CreateMakeProgramLinux(exe);
        }

        program.Execute();

        program.Wait();

        long k;
        k = program.Status;

        this.FinalMakeProgram(program);

        if (!(k == 0))
        {
            return false;
        }

        return true;
    }

    protected virtual bool ExecuteModuleRefString()
    {
        this.ModuleRefGen.Gen = this.Gen;
        this.ModuleRefGen.Module = this.Module;

        this.ModuleRefGen.Execute();

        this.ModuleExeString = this.ModuleRefGen.Result;

        this.ModuleRefGen.Result = null;
        this.ModuleRefGen.Module = null;
        this.ModuleRefGen.Gen = null;

        return true;
    }

    protected virtual bool ExecuteModuleExeSource()
    {
        Text ka;
        ka = this.TextCreate(this.ModuleExeText);
        ka = this.TextPlace(ka, this.TA(this.S("#ModuleString#")), this.TB(this.ModuleExeString));

        String k;
        k = this.StringCreate(ka);

        String fileName;
        fileName = this.AddClear().Add(this.SMain).Add(this.ClassInfra.TextDot).Add(this.SC).AddResult();

        String filePath;
        filePath = this.AddClear().Add(this.GenModuleFoldPath).Add(this.TextInfra.PathCombine).Add(fileName).AddResult();

        bool b;
        b = this.StorageInfra.TextWrite(filePath, k);

        if (!b)
        {
            return false;
        }

        return true;
    }

    protected virtual Program CreateMakeProgramLinux(bool exe)
    {
        String ka;
        ka = this.TextInfra.Zero;

        if (exe)
        {
            ka = this.SExe;
        }

        List list;
        list = new List();
        list.Init();
        list.Add(this.AddClear().AddS("./Make").Add(ka).AddS(".sh").AddResult());
        list.Add(this.ModuleRefString);

        Program program;
        program = new Program();
        program.Init();
        program.Name = this.S("bash");
        program.Argue = list;
        program.WorkFold = this.S("Saber.Class.data");
        program.Environ = null;

        return program;
    }

    protected virtual Program CreateMakeProgramWindows(bool exe)
    {
        List list;
        list = new List();
        list.Init();
        list.Add(this.S("-pipe"));
        list.Add(this.S("-fno-strict-aliasing"));
        list.Add(this.S("-O0"));
        list.Add(this.S("-std=gnu11"));
        list.Add(this.S("-Wall"));
        list.Add(this.S("-Wno-ignored-attributes"));
        list.Add(this.S("-Wno-bitwise-instead-of-logical"));
        list.Add(this.S("-Wno-unused-but-set-variable"));
        list.Add(this.S("-Wno-unused-variable"));
        list.Add(this.S("-I."));
        list.Add(this.S("-I../.."));

        if (!exe)
        {
            list.Add(this.S("-Wl,-s"));
            list.Add(this.S("-shared"));
            list.Add(this.S("-Wl,-subsystem,windows"));
        }

        if (exe)
        {
            list.Add(this.S("-Wl,-s"));
            list.Add(this.S("-Wl,-subsystem,console"));
        }

        list.Add(this.AddClear().AddS("-L../../../").Add(this.ClassPath).Add(this.TextInfra.PathCombine).AddS("Infra").AddResult());
        list.Add(this.AddClear().AddS("-L../../../").Add(this.LibraryPath).AddResult());
        list.Add(this.S("-lInfra"));
        list.Add(this.S("-lInfraIntern"));

        if (!exe)
        {
            Array moduleRefStringArray;
            moduleRefStringArray = this.ModuleRefStringArray();

            long count;
            count = moduleRefStringArray.Count;

            long i;
            i = 0;
            while (i < count)
            {
                String ka;
                ka = moduleRefStringArray.GetAt(i) as String;

                list.Add(this.AddClear().AddS("-l").Add(ka).AddResult());

                i = i + 1;
            }
        }

        if (exe)
        {
            list.Add(this.AddClear().AddS("-l").Add(this.ModuleRefString).AddResult());
        }

        list.Add(this.S("-o"));

        if (!exe)
        {
            list.Add(this.AddClear().AddS("../../../").Add(this.LibraryPath).Add(this.TextInfra.PathCombine).Add(this.ModuleRefString).AddS(".dll").AddResult());
            list.Add(this.S("Module.c"));
        }

        if (exe)
        {
            list.Add(this.AddClear().AddS("../../../").Add(this.LibraryPath).Add(this.TextInfra.PathCombine).Add(this.ModuleRefString).AddS(".exe").AddResult());
            list.Add(this.S("Main.c"));
        }

        Program program;
        program = new Program();
        program.Init();
        program.Name = this.S("clang.exe");
        program.Argue = list;
        program.WorkFold = this.GenModuleFoldPath;
        program.Environ = null;

        return program;
    }

    protected virtual bool FinalMakeProgram(Program a)
    {
        a.Final();
        return true;
    }

    protected virtual bool Error()
    {
        long k;
        k = this.Stage;
        k = k * 10;

        this.Status = k;

        return false;
    }
}