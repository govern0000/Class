#include "Play.hpp"

CppClassNew(Play)

Int Play_Init(Int o)
{
    Play* m;
    m = CP(o);
    m->Intern = new PlayIntern;
    m->Intern->Play = o;
    m->Intern->Init();
    return true;
}

Int Play_Final(Int o)
{
    Play* m;
    m = CP(o);

    delete m->Intern;

    return true;
}

CppField(Play, Source)

Int Play_SourceThisSet(Int o)
{
    Play* m;
    m = CP(o);

    Int stream;
    stream = m->Source;

    Int ka;
    ka = Stream_Intern(stream);

    QIODevice* u;
    u = (QIODevice*)ka;

    m->Intern->setSourceDevice(u);
    return true;
}

Int Play_Execute(Int o)
{
    Play* m;
    m = CP(o);
    m->Intern->play();
    return true;
}

Int Play_Pause(Int o)
{
    Play* m;
    m = CP(o);
    m->Intern->pause();
    return true;
}

Int Play_Stop(Int o)
{
    Play* m;
    m = CP(o);
    m->Intern->stop();
    return true;
}

CppFieldGet(Play, VideoOut)

Int Play_VideoOutSet(Int o, Int value)
{
    Play* m;
    m = CP(o);
    m->VideoOut = value;

    if (m->VideoOut == null)
    {
        m->Intern->setVideoOutput(null);
        return true;
    }

    Int oa;
    oa = VideoOut_Intern(m->VideoOut);
    VideoOutIntern* ua;
    ua = (VideoOutIntern*)oa;

    QVideoSink* u;
    u = ua;

    m->Intern->setVideoOutput(u);
    return true;
}

CppFieldGet(Play, AudioOut)

Int Play_AudioOutSet(Int o, Int value)
{
    Play* m;
    m = CP(o);
    m->AudioOut = value;

    if (m->AudioOut == null)
    {
        m->Intern->setAudioOutput(null);
        return true;
    }

    Int u;
    u = AudioOut_Intern(m->AudioOut);

    QAudioOutput* audioOutput;
    audioOutput = (QAudioOutput*)u;

    m->Intern->setAudioOutput(audioOutput);
    return true;
}

Int Play_HasVideo(Int o)
{
    Play* m;
    m = CP(o);
    bool bu;
    bu = m->Intern->hasVideo();
    Bool a;
    a = bu;
    return a;
}

Int Play_HasAudio(Int o)
{
    Play* m;
    m = CP(o);
    bool bu;
    bu = m->Intern->hasAudio();
    Bool a;
    a = bu;
    return a;
}

Int Play_TimeGet(Int o)
{
    Play* m;
    m = CP(o);
    qint64 u;
    u = m->Intern->duration();
    Int a;
    a = u;
    return a;
}

FieldDefaultSet(Play, Time)

Int Play_PosGet(Int o)
{
    Play* m;
    m = CP(o);
    qint64 u;
    u = m->Intern->position();
    Int a;
    a = u;
    return a;
}

Int Play_PosSet(Int o, Int value)
{
    Play* m;
    m = CP(o);

    qint64 u;
    u = value;
    m->Intern->setPosition(u);
    return true;
}

CppField(Play, StatusState);
CppField(Play, CaseState);
CppField(Play, RateState);
CppField(Play, PosState);

Int Play_StatusEvent(Int o)
{
    Play* m;
    m = CP(o);

    Int state;
    state = m->StatusState;

    if (state == null)
    {
        return true;
    }

    Int aa;
    aa = State_MaideGet(state);
    Int arg;
    arg = State_ArgGet(state);

    if (aa == null)
    {
        return true;
    }

    Play_Status_Maide maide;
    maide = (Play_Status_Maide)aa;

    maide(o, arg);

    return true;
}

Int Play_CaseEvent(Int o)
{
    Play* m;
    m = CP(o);

    Int state;
    state = m->CaseState;

    if (state == null)
    {
        return true;
    }

    Int aa;
    aa = State_MaideGet(state);
    Int arg;
    arg = State_ArgGet(state);

    if (aa == null)
    {
        return true;
    }

    Play_Case_Maide maide;
    maide = (Play_Case_Maide)aa;

    maide(o, arg);

    return true;
}

Int Play_RateEvent(Int o)
{
    Play* m;
    m = CP(o);

    Int state;
    state = m->RateState;

    if (state == null)
    {
        return true;
    }

    Int aa;
    aa = State_MaideGet(state);
    Int arg;
    arg = State_ArgGet(state);

    if (aa == null)
    {
        return true;
    }

    Play_Rate_Maide maide;
    maide = (Play_Rate_Maide)aa;

    maide(o, arg);

    return true;
}

Int Play_PosEvent(Int o)
{
    Play* m;
    m = CP(o);

    Int state;
    state = m->PosState;

    if (state == null)
    {
        return true;
    }

    Int aa;
    aa = State_MaideGet(state);
    Int arg;
    arg = State_ArgGet(state);

    if (aa == null)
    {
        return true;
    }

    Play_Pos_Maide maide;
    maide = (Play_Pos_Maide)aa;

    maide(o, arg);

    return true;
}