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

void FrameIntern::mousePressEvent(QMouseEvent* ev)
{
    ev->accept();
}

void FrameIntern::mouseReleaseEvent(QMouseEvent* ev)
{
    ev->accept();
}

void FrameIntern::mouseMoveEvent(QMouseEvent* ev)
{
    ev->accept();
}

void FrameIntern::mouseDoubleClickEvent(QMouseEvent* ev)
{
    ev->accept();
}

void FrameIntern::wheelEvent(QWheelEvent* ev)
{

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

Int FrameIntern::PointerEventHandle(Int kind, Int index, Int valueA, Int valueB)
{
    return true;
}