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
    Int index;
    index = ev->buttons().toInt();

    Int valueA;
    Int valueB;
    valueA = ev->pos().x();
    valueB = ev->pos().y();

    this->PointEventHandle(1, index, valueA, valueB, 0, 0);

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

    this->PointEventHandle(3, index, valueA, valueB, 0, 0);

    ev->accept();
}

void FrameIntern::mouseDoubleClickEvent(QMouseEvent* ev)
{
    Int index;
    index = ev->buttons().toInt();

    Int valueA;
    Int valueB;
    valueA = ev->pos().x();
    valueB = ev->pos().y();

    this->PointEventHandle(4, index, valueA, valueB, 0, 0);

    ev->accept();
}

void FrameIntern::wheelEvent(QWheelEvent* ev)
{
    Int index;
    index = ev->buttons().toInt();

    QPoint ka;
    ka = QCursor::pos();

    Int valueA;
    Int valueB;
    Int valueC;
    Int valueD;
    valueA = ka.x();
    valueB = ka.y();
    valueC = ev->angleDelta().x();
    valueD = ev->angleDelta().y();

    this->PointEventHandle(5, index, valueA, valueB, valueC, valueD);

    ev->accept();
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

Int FrameIntern::DualEventHandle(Int kind, Int index, Int valueA, Int valueB, Int valueC, Int valueD)
{
    Int frame;
    frame = this->Frame;

    Frame_DualEvent(frame, kind, index, valueA, valueB, valueC, valueD);
    return true;
}

Int FrameIntern::PointEventHandle(Int kind, Int index, Int valueA, Int valueB, Int valueC, Int valueD)
{
    Int frame;
    frame = this->Frame;

    Frame_PointEvent(frame, kind, index, valueA, valueB, valueC, valueD);
    return true;
}