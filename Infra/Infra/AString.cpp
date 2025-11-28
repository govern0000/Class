#include "AString.hpp"

CppClassNew(String)

Int String_Init(Int o)
{
    return true;
}

Int String_Final(Int o)
{
    return true;
}

CppField(String, Value)
CppField(String, Count)

Int String_Char(Int o, Int index)
{
    String* m;
    m = CP(o);

    Char* ka;
    ka = (Char*)(m->Value);

    Char k;
    k = ka[index];

    Int a;
    a = k;
    return a;
}

Int String_Equal(Int o, Int other)
{
    String* m;
    m = CP(o);
    String* d;
    d = (String*)(other);

    Bool ba;    
    ba = (m->Count == d->Count);
    if (!ba)
    {
        return false;
    }

    Char* mf;    
    mf = (Char*)(m->Value);
    Char* df;
    df = (Char*)(d->Value);

    Int count;
    count = m->Count;
    Int i;
    i = 0;
    while (i < count)
    {
        if (!(mf[i] == df[i]))
        {
            return false;
        }
        i = i + 1;
    }
    return true;
}

Int String_ConstantCount(Int o)
{
    Byte* p;
    p = (Byte*)o;

    Int k;
    k = 0;
    while (!((*p) == '\0'))
    {
        k = k + 1;
        p = p + 1;
    }
    return k;
}

Int String_ConstantCreate(Int o)
{
    Int count;
    count = String_ConstantCount(o);

    Int share;
    share = Infra_Share();
    Int stat;
    stat = Share_Stat(share);

    Int innKind;
    innKind = Stat_TextCodeKindUtf8(stat);
    Int outKind;
    outKind = Stat_TextCodeKindUtf32(stat);

    Int innDataValue;
    Int innDataCount;
    innDataValue = o;
    innDataCount = count;

    Int k;
    k = TextCode_ExecuteCount(0, innKind, outKind, innDataValue, innDataCount);

    Int outDataValue;
    Int outDataCount;
    outDataValue = Environ_New(k);
    outDataCount = k;

    TextCode_ExecuteResult(0, outDataValue, innKind, outKind, innDataValue, innDataCount);

    Int stringCount;
    stringCount = outDataCount / sizeof(Char);

    Int kk;
    kk = String_New();
    String_Init(kk);
    String_ValueSet(kk, outDataValue);
    String_CountSet(kk, stringCount);

    Int a;
    a = kk;
    return a;
}

Int String_ConstantDelete(Int o)
{
    Int data;
    data = String_ValueGet(o);

    String_Final(o);
    String_Delete(o);

    Environ_Delete(data);
    return true;
}

Int String_QStringSet(Int result, Int a)
{
    Int value;
    value = String_ValueGet(a);
    Int count;
    count = String_CountGet(a);

    const char32_t* valueU;
    valueU = (const char32_t*)value;
    qsizetype countU;
    countU = count;

    QString* u;
    u = (QString*)result;
    *u = QString::fromUcs4(valueU, countU);
    return true;
}

Int String_StringCreate(Int qstring)
{
    QString* ka;
    ka = (QString*)qstring;

    QList<uint> kk;
    kk = ka->toUcs4();

    qsizetype countU;
    countU = kk.size();

    Int count;
    count = countU;

    Int dataCount;
    dataCount = count * Constant_CharByteCount();

    Int value;
    value = Environ_New(dataCount);

    Char* p;
    p = (Char*)value;

    Int i;
    i = 0;
    while (i < count)
    {
        qsizetype iU;
        iU = i;
        
        uint n;
        n = kk.at(iU);

        p[i] = n;

        i = i + 1;
    }

    Int k;
    k = String_New();
    String_Init(k);
    String_ValueSet(k, value);
    String_CountSet(k, count);

    Int a;
    a = k;
    return a;
}