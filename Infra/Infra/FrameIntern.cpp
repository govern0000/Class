#include "FrameIntern.hpp"

Bool FrameIntern::Init()
{
    return true;
}

void FrameIntern::keyPressEvent(QKeyEvent* ev)
{
    Int index;
    index = ev->key();

    this->TypeEventHandle(index, true);
}

void FrameIntern::keyReleaseEvent(QKeyEvent* ev)
{
    Int index;
    index = ev->key();

    this->TypeEventHandle(index, false);
}

void FrameIntern::paintEvent(QPaintEvent* ev)
{
    this->DrawEventHandle();
}

void FrameIntern::changeEvent(QEvent* ev)
{
    if (ev->type() == QEvent::WindowStateChange)
    {
        this->CaseEventHandle();
    }
}

Int FrameIntern::TypeEventHandle(Int index, Int value)
{
    Int frame;
    frame = this->Frame;

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