#include "FrameIntern.hpp"

Bool FrameIntern::Init()
{
    return true;
}

void FrameIntern::keyPressEvent(QKeyEvent* ev)
{
    this->TypeEventHandle(true, ev);
}

void FrameIntern::keyReleaseEvent(QKeyEvent* ev)
{
    this->TypeEventHandle(false, ev);
}

void FrameIntern::paintEvent(QPaintEvent* ev)
{
    this->DrawEventHandle();
}

void FrameIntern::changedEvent(QEvent* ev)
{
    if (ev->type() == QEvent::WindowStateChange)
    {
        this->CaseEventHandle();
    }
}

Int FrameIntern::TypeEventHandle(Int press, QKeyEvent* ev)
{
    Int frame;
    frame = this->Frame;
    Int index;
    index = ev->key();
    Int value;
    value = press;

    Frame_TypeEvent(frame, index, value);
    return true;
}

Int FrameIntern::DrawEventHandle()
{
    Int frame;
    frame = this->Frame;

    Frame_DrawEvent(frame);
    return true;
}

Int FrameIntern::SizeEventHandle()
{
    Int frame;
    frame = this->Frame;

    Frame_SizeEvent(frame);
    return true;
}

Int FrameIntern::CaseEventHandle()
{
    Int frame;
    frame = this->Frame;

    Frame_CaseEvent(frame);
    return true;
}