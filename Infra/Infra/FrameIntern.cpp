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

    this->PointerEventHandle(1, index, valueA, valueB);

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

    this->PointerEventHandle(2, index, valueA, valueB);

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

    this->PointerEventHandle(3, index, valueA, valueB);

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

    this->PointerEventHandle(4, index, valueA, valueB);

    ev->accept();
}

void FrameIntern::wheelEvent(QWheelEvent* ev)
{
    Int index;
    index = ev->buttons().toInt();

    Int valueA;
    Int valueB;
    valueA = ev->angleDelta().x();
    valueB = ev->angleDelta().y();

    this->PointerEventHandle(5, index, valueA, valueB);

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

Int FrameIntern::PointerEventHandle(Int kind, Int index, Int valueA, Int valueB, Int valueC, Int valueD)
{
    return true;
}