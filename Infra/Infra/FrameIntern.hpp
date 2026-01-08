#pragma once

#include <QWidget>
#include <QPaintEvent>
#include <QPainter>
#include <QMouseEvent>
#include <QWheelEvent>
#include <QCursor>

#include "Pronate.hpp"

class FrameIntern : public QWidget
{
    Q_OBJECT

public:
    Int Frame;
    Int Init();

protected:
    void paintEvent(QPaintEvent* ev) override;
    void keyPressEvent(QKeyEvent* ev) override;
    void keyReleaseEvent(QKeyEvent* ev) override;
    void mousePressEvent(QMouseEvent* ev) override;
    void mouseReleaseEvent(QMouseEvent* ev) override;
    void mouseMoveEvent(QMouseEvent* ev) override;
    void mouseDoubleClickEvent(QMouseEvent* ev) override;
    void wheelEvent(QWheelEvent* ev) override;

private:
    Int TypeEventHandle(Int index, Int value);
    Int DrawEventHandle();
    Int DualEventHandle(Int kind, Int index, Int valueA, Int valueB, Int valueC, Int valueD);
    Int PointEventHandle(Int kind, Int index, Int valueA, Int valueB, Int valueC, Int valueD);
};
