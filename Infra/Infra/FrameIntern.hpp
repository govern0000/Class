#pragma once

#include <QWidget>
#include <QEvent>
#include <QPaintEvent>
#include <QPainter>
#include <QWindowStateChangeEvent>

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
    void resizeEvent(QResizeEvent* ev) override;
    void changeEvent(QEvent* ev) override;

private:
    Int TypeEventHandle(Int index, Int value);
    Int DrawEventHandle();
    Int SizeEventHandle();
    Int CaseEventHandle();
};
