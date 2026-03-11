#include "FrameIntern.hpp"

Bool FrameIntern::Init()
{
    return true;
}

void FrameIntern::paintEvent(QPaintEvent* ev)
{
    this->DrawEventHandle();
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

void FrameIntern::mousePressEvent(QMouseEvent* ev)
{
    Int kind;
    kind = 0;

    if (ev->button() == Qt::LeftButton)
    {
        kind = 2;
    }

    if (ev->button() == Qt::RightButton)
    {
        kind = 3;
    }

    if (!(kind == 0))
    {
        this->PointEventHandle(2, kind, 0, 0);
    }

    ev->accept();
}

void FrameIntern::mouseReleaseEvent(QMouseEvent* ev)
{
    Int index;
    index = ev->buttons().toInt();

    Int valueA;
    Int valueB;
    valueA = ev->pos().x();
    valueB = ev->pos().y();

    this->PointEventHandle(2, index, valueA, valueB, 0, 0);

    ev->accept();
}

void FrameIntern::mouseMoveEvent(QMouseEvent* ev)
{
    Int index;
    index = ev->buttons().toInt();

    Int valueA;
    Int valueB;
    valueA = ev->pos().x();
    valueB = ev->pos().y();

    this->PointEventHandle(0, valueA, valueB);

    ev->accept();
}

void FrameIntern::mouseDoubleClickEvent(QMouseEvent* ev)
{
    Int index;
    index = ev->buttons().toInt();

    this->PointEventHandle(4, index, valueA, valueB, 0, 0);

    ev->accept();
}

void FrameIntern::wheelEvent(QWheelEvent* ev)
{
    Int valueA;
    Int valueB;
    valueA = ev->angleDelta().x();
    valueB = ev->angleDelta().y();

    this->PointEventHandle(1, valueA, valueB);

    ev->accept();
}

Int FrameIntern::DrawEventHandle()
{
    Int frame;
    frame = this->Frame;

    Frame_DrawEvent(frame);
    return true;
}

Int FrameIntern::TypeEventHandle(Int index, Int value)
{
    Int frame;
    frame = this->Frame;

    Frame_TypeEvent(frame, index, value);
    return true;
}

Int FrameIntern::PointEventHandle(Int kind, Int valueA, Int valueB)
{
    Int frame;
    frame = this->Frame;

    Frame_PointerEvent(frame, kind, valueA, valueB);
    return true;
}