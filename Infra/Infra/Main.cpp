#include "Main.hpp"

Main D_Var;

Int Main_Init(Int argc, Int argv)
{
    Main* m;
    m = &D_Var;

    m->ThreadStorage = Thread_CreateStore();

    m->ArgC = argc;
    m->ArgV = argv;

    m->Argc = 1;

    m->Argv[0] = (char*)"Application";

    QCoreApplication::addLibraryPath(".");

    m->Intern = new QApplication(m->Argc, m->Argv);

    m->Intern->setQuitOnLastWindowClosed(false);

    m->Share = Share_New();
    Share_Init(m->Share);

    m->MainThread = Thread_New();
    Thread_InitMainThread(m->MainThread);

    Console_OS_Init();

    bool ba;
    ba = (QSysInfo::buildCpuArchitecture() == QString("x86_64"));

    Bool b;
    b = ba;

    m->Compute = b;

    Main_InitArg();

    Environ_VarInit();

    QScreen* k;
    k = m->Intern->primaryScreen();

    Int screen;
    screen = CastInt(k);

    m->Screen = Screen_New();
    Screen_InternSet(m->Screen, screen);
    Screen_Init(m->Screen);

    QObject::connect(k, &QScreen::physicalSizeChanged, &Main_ScreenDimendHandle);

    QObject::connect(k, &QScreen::orientationChanged, &Main_ScreenOrientHandle);

    return true;
}

Int Main_Final()
{
    Main* m;
    m = &D_Var;

    Screen_Final(m->Screen);
    Screen_Delete(m->Screen);

    Environ_VarFinal();

    Main_FinalArg();

    Thread_FinalMainThread(m->MainThread);
    Thread_Delete(m->MainThread);

    Share_Final(m->Share);
    Share_Delete(m->Share);

    delete m->Intern;

    Thread_DeleteStore(m->ThreadStorage);

    return true;
}

Int Main_Arg()
{
    Main* m;
    m = &D_Var;

    Int a;
    a = m->Arg;
    return a;
}

Int Main_InitArg()
{
    Main* m;
    m = &D_Var;

    Int a;
    a = Main_OS_Arg(m->ArgC, m->ArgV);

    m->Arg = a;

    return true;
}

Int Main_FinalArg()
{
    Main* m;
    m = &D_Var;

    Int array;
    array = m->Arg;

    Int count;
    count = Array_CountGet(array);

    Int i;
    i = 0;
    while (i < count)
    {
        Int index;
        index = count - 1 - i;

        Int a;
        a = Array_ItemGet(array, index);

        Int value;
        value = String_ValueGet(a);

        String_Final(a);

        String_Delete(a);

        Environ_Delete(value);

        i = i + 1;
    }

    Array_Final(array);

    Array_Delete(array);

    return true;
}

Int Main_ExecuteMain()
{
    int u;
    u = QApplication::exec();
    Int a;
    a = u;
    return a;
}

Int Main_Exit(Int status)
{
    int u;
    u = status;
    QApplication::exit(u);
    return true;
}

Int Main_ThreadStorage()
{
    Main* m;
    m = &D_Var;
    return m->ThreadStorage;
}

Int Main_Compute()
{
    Main* m;
    m = &D_Var;
    return m->Compute;
}

Int Main_Screen()
{
    Main* m;
    m = &D_Var;
    return m->Screen;
}

void Main_ScreenDimendHandle(const QSizeF &size)
{
    Int screen;
    screen = Main_Screen();

    Screen_Dimend(screen);

    Screen_DimendEvent(screen);
}

void Main_ScreenOrientHandle(Qt::ScreenOrientation orientation)
{
    Int screen;
    screen = Main_Screen();

    Screen_Size(screen);

    Screen_OrientEvent(screen);
}

Int Main_TerminateStateGet()
{
    Main* m;
    m = &D_Var;
    return m->TerminateState;
}

Int Main_TerminateStateSet(Int value)
{
    Main* m;
    m = &D_Var;
    m->TerminateState = value;
    return true;
}

void Main_SignalHandle(int signo)
{
    Main* m;
    m = &D_Var;
    Int state;
    state = m->TerminateState;
    Int a;
    a = State_MaideGet(state);
    Int arg;
    arg = State_ArgGet(state);
    Main_Terminate_Maide maide;
    maide = (Main_Terminate_Maide)a;
    if (!(maide == null))
    {
        maide(arg);
    }
}

Int Infra_Share()
{
    Main* m;
    m = &D_Var;
    return m->Share;
}